// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListLineagesResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListLineagesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListLineagesResponseBodyPagingInfo : TeaModel {
            [NameInMap("Lineages")]
            [Validation(Required=false)]
            public List<ListLineagesResponseBodyPagingInfoLineages> Lineages { get; set; }
            public class ListLineagesResponseBodyPagingInfoLineages : TeaModel {
                [NameInMap("DstEntity")]
                [Validation(Required=false)]
                public LineageEntity DstEntity { get; set; }

                [NameInMap("Relationships")]
                [Validation(Required=false)]
                public List<LineageRelationship> Relationships { get; set; }

                [NameInMap("SrcEntity")]
                [Validation(Required=false)]
                public LineageEntity SrcEntity { get; set; }

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
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
