// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListLineageRelationshipsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination result.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListLineageRelationshipsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListLineageRelationshipsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of data tables.</para>
            /// </summary>
            [NameInMap("LineageRelationships")]
            [Validation(Required=false)]
            public List<LineageRelationship> LineageRelationships { get; set; }

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
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used for locating and troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDFSDFSDF-SDFSDF-SDFDSF-SDFSDF</para>
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
