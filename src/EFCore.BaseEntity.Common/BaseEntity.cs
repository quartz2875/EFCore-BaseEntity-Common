/*
** BurakQuartz v1.0.1 ()
** Copyright © 2022 BurakQuartz. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;
namespace EFCore.BaseEntity.Common
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; } = default!;
#if NET5_0
        // Code specific to net5.0
#elif NET6_0
// Code specific to net6.0
#else
// Code specific to other frameworks
#endif

    }
}