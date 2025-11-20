// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class ListProtectedResourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJJ************MX0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ProtectedResources")]
        [Validation(Required=false)]
        public List<ListProtectedResourcesResponseBodyProtectedResources> ProtectedResources { get; set; }
        public class ListProtectedResourcesResponseBodyProtectedResources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("CreatedByProduct")]
            [Validation(Required=false)]
            public string CreatedByProduct { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>107374182400</para>
            /// </summary>
            [NameInMap("ProtectedDataSize")]
            [Validation(Required=false)]
            public long? ProtectedDataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pr-0004************gs61</para>
            /// </summary>
            [NameInMap("ProtectedResourceId")]
            [Validation(Required=false)]
            public string ProtectedResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-wz95************7zrd</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024********0703</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SnapshotCount")]
            [Validation(Required=false)]
            public long? SnapshotCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS_FILE</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EB09****-<b><b>-</b></b>-****-********6C38</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
