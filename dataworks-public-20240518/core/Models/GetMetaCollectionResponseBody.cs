// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetMetaCollectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection details.</para>
        /// </summary>
        [NameInMap("MetaCollection")]
        [Validation(Required=false)]
        public GetMetaCollectionResponseBodyMetaCollection MetaCollection { get; set; }
        public class GetMetaCollectionResponseBodyMetaCollection : TeaModel {
            /// <summary>
            /// <para>The list of administrator IDs. Valid only for the album type. The IDs must belong to users in the same tenant. Multiple IDs can be specified.</para>
            /// </summary>
            [NameInMap("Administrators")]
            [Validation(Required=false)]
            public List<long?> Administrators { get; set; }

            /// <summary>
            /// <para>The creation time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1668568601000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>456789</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The collection description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The collection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>category.123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The last modified time in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1668568601000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The collection name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_category</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parent collection ID. This parameter can be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>category.12</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The collection type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Category</description></item>
            /// <item><description>Album</description></item>
            /// <item><description>AlbumCategory: Album subcategory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Category</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
