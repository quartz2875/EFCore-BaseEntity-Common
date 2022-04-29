/*
** BurakQuartz v1.0.0 ()
** Copyright © 2022 BurakQuartz. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;
namespace EFCore.BaseEntity.Common
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; } = default!;
    }
}