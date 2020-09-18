﻿using Vendr.Contrib.ProductReviews.Dto;
using Vendr.Core;
using Vendr.ProductReviews.Models;

namespace Vendr.Contrib.ProductReviews.Factories
{
    public class ProductReviewFactory
    {
        public static ProductReview BuildProductReview(ProductReviewDto dto)
        {
            dto.MustNotBeNull(nameof(dto));

            var review = new ProductReview(dto.Id)
            {
                CreatedAt = dto.CreatedAt,
                Rating = dto.Rating,
                Name = dto.Name,
                Description = dto.Description,
                CustomerReference = dto.CustomerReference,
                ProductReference = dto.ProductReference
            };

            return review;
        }

        public static ProductReviewDto BuildProductReview(ProductReview review)
        {
            review.MustNotBeNull(nameof(review));

            var dto = new ProductReviewDto
            {
                Id = review.Id,
                Rating = review.Rating,
                Name = review.Name,
                Description = review.Description,
                CustomerReference = review.CustomerReference,
                ProductReference = review.ProductReference
            };

            return dto;
        }
    }
}