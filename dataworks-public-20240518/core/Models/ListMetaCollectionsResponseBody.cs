// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMetaCollectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paged result object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMetaCollectionsResponseBodyData Data { get; set; }
        public class ListMetaCollectionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of collections.</para>
            /// </summary>
            [NameInMap("MetaCollections")]
            [Validation(Required=false)]
            public List<ListMetaCollectionsResponseBodyDataMetaCollections> MetaCollections { get; set; }
            public class ListMetaCollectionsResponseBodyDataMetaCollections : TeaModel {
                /// <summary>
                /// <para>The list of administrator user IDs. This parameter is supported only for the album type. The administrators must be users within the same tenant. You can specify multiple administrators.</para>
                /// </summary>
                [NameInMap("Administrators")]
                [Validation(Required=false)]
                public List<string> Administrators { get; set; }

                /// <summary>
                /// <para>The creation time as a millisecond-level timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1668568601000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The user ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>456789</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The description of the collection object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test category</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the collection object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7a65sd7aasd</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The modification time as a millisecond-level timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1668568601000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the collection object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_category</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the parent node collection object. This value can be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>as78d756asd</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The collection type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Category: category.</description></item>
                /// <item><description>Album: data album.</description></item>
                /// <item><description>AlbumCategory: album subcategory.</description></item>
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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E25887B7-XXXX-54A5-9C4F-83A0DE367DDE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
