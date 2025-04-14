// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMetaCollectionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMetaCollectionsResponseBodyData Data { get; set; }
        public class ListMetaCollectionsResponseBodyData : TeaModel {
            [NameInMap("MetaCollections")]
            [Validation(Required=false)]
            public List<ListMetaCollectionsResponseBodyDataMetaCollections> MetaCollections { get; set; }
            public class ListMetaCollectionsResponseBodyDataMetaCollections : TeaModel {
                [NameInMap("Administrators")]
                [Validation(Required=false)]
                public List<string> Administrators { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1668568601000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>456789</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>category.123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1668568601000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_category</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>category.1</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Category</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E25887B7-579C-54A5-9C4F-83A0DE367DDE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
