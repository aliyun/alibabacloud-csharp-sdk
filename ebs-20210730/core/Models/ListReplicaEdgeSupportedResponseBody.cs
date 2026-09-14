// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ListReplicaEdgeSupportedResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 500.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query. If NextToken is empty, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e71d8a535bd9c****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17EE62D8-064E-5404-8B0D-72122478****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The set of region information.</para>
        /// </summary>
        [NameInMap("SupportedRegions")]
        [Validation(Required=false)]
        public List<ListReplicaEdgeSupportedResponseBodySupportedRegions> SupportedRegions { get; set; }
        public class ListReplicaEdgeSupportedResponseBodySupportedRegions : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The set of zone information.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<ListReplicaEdgeSupportedResponseBodySupportedRegionsZones> Zones { get; set; }
            public class ListReplicaEdgeSupportedResponseBodySupportedRegionsZones : TeaModel {
                /// <summary>
                /// <para>Indicates whether replication time control is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SupportRtc")]
                [Validation(Required=false)]
                public bool? SupportRtc { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
