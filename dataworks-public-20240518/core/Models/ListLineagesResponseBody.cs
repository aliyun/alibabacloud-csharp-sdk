// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListLineagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination result.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListLineagesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListLineagesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The lineage information list.</para>
            /// </summary>
            [NameInMap("Lineages")]
            [Validation(Required=false)]
            public List<ListLineagesResponseBodyPagingInfoLineages> Lineages { get; set; }
            public class ListLineagesResponseBodyPagingInfoLineages : TeaModel {
                /// <summary>
                /// <para>The destination entity.</para>
                /// </summary>
                [NameInMap("DstEntity")]
                [Validation(Required=false)]
                public LineageEntity DstEntity { get; set; }

                /// <summary>
                /// <para>The lineage details.</para>
                /// </summary>
                [NameInMap("Relationships")]
                [Validation(Required=false)]
                public List<LineageRelationship> Relationships { get; set; }

                /// <summary>
                /// <para>The source entity.</para>
                /// </summary>
                [NameInMap("SrcEntity")]
                [Validation(Required=false)]
                public LineageEntity SrcEntity { get; set; }

            }

            /// <summary>
            /// <para>The requested page number for pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total record count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
