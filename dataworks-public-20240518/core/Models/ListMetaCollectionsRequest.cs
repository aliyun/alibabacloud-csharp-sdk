// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMetaCollectionsRequest : TeaModel {
        /// <summary>
        /// <para>The administrator ID. Valid only for album types. Default: The current user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("Administrator")]
        [Validation(Required=false)]
        public string Administrator { get; set; }

        /// <summary>
        /// <para>The creator user ID. Valid only for album types. Default: The current user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CreateUser")]
        [Validation(Required=false)]
        public string CreateUser { get; set; }

        /// <summary>
        /// <para>The collection description. Supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test collection</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The collection name. Supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Asc (default): Ascending order</para>
        /// </description></item>
        /// <item><description><para>Desc</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Default: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default: 10. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the parent collection.</para>
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
        /// <item><description><para>Id (default)</para>
        /// </description></item>
        /// <item><description><para>Name</para>
        /// </description></item>
        /// <item><description><para>CreateUser: Creator ID</para>
        /// </description></item>
        /// <item><description><para>CreateTime: Creation time</para>
        /// </description></item>
        /// <item><description><para>ModifyTime: Modification time</para>
        /// </description></item>
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
        /// <item><description><para>Category</para>
        /// </description></item>
        /// <item><description><para>Album</para>
        /// </description></item>
        /// <item><description><para>AlbumCategory: Album subcategory</para>
        /// </description></item>
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
