// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMetaCollectionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collection administrator. This parameter is valid only for the album type. Default value: the current user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("Administrator")]
        [Validation(Required=false)]
        public string Administrator { get; set; }

        /// <summary>
        /// <para>The user ID of the creator. This parameter is valid only for the album type. Default value: the current user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CreateUser")]
        [Validation(Required=false)]
        public string CreateUser { get; set; }

        /// <summary>
        /// <para>The collection description. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test collection</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The collection name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data Asset Subject Domain</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc (default)</description></item>
        /// <item><description>Desc</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the parent node collection object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>as78d756asd</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Id (default)</description></item>
        /// <item><description>Name: name.</description></item>
        /// <item><description>CreateUser: creator ID.</description></item>
        /// <item><description>CreateTime: creation time.</description></item>
        /// <item><description>ModifyTime: modification time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The collection type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Category: category.</description></item>
        /// <item><description>Album: data album.</description></item>
        /// <item><description>AlbumCategory: album subcategory.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Category</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
