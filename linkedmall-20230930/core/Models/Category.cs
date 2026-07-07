// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Category : TeaModel {
        /// <summary>
        /// <para>The ID of the category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201792301</para>
        /// </summary>
        [NameInMap("categoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>Indicates whether the category is a leaf category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isLeaf")]
        [Validation(Required=false)]
        public bool? IsLeaf { get; set; }

        /// <summary>
        /// <para>The level of the category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        /// <summary>
        /// <para>The name of the category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>名称测试</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the parent category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

    }

}
