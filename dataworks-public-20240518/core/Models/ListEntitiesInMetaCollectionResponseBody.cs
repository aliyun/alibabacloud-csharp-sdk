// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListEntitiesInMetaCollectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination result.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListEntitiesInMetaCollectionResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListEntitiesInMetaCollectionResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of entities in the collection.</para>
            /// </summary>
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<ListEntitiesInMetaCollectionResponseBodyPagingInfoEntities> Entities { get; set; }
            public class ListEntitiesInMetaCollectionResponseBodyPagingInfoEntities : TeaModel {
                /// <summary>
                /// <para>The entity comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The creation time in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1737078994080</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description specified when the entity was added to the collection. Valid only for albums.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the entity. Currently, only the Table type is supported. If the entity is deleted, this field is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dlf-table:123456789:test_catalog:test_database::test_table</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The last modified time in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1737078994080</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The entity name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The entity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dlf-table</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F05080B0-CCE6-5D22-B284-34A51C5D4E28</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
