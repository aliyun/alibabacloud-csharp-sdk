// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamResourceCidrsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("IpamResourceCidrs")]
        [Validation(Required=false)]
        public List<ListIpamResourceCidrsResponseBodyIpamResourceCidrs> IpamResourceCidrs { get; set; }
        public class ListIpamResourceCidrsResponseBodyIpamResourceCidrs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>132193271328****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.1.0/32</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Compliant</para>
            /// </summary>
            [NameInMap("ComplianceStatus")]
            [Validation(Required=false)]
            public string ComplianceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IpUsage")]
            [Validation(Required=false)]
            public string IpUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-pool-alloc-112za33e4****</para>
            /// </summary>
            [NameInMap("IpamAllocationId")]
            [Validation(Required=false)]
            public string IpamAllocationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-uq5dcfc2eqhpf4****</para>
            /// </summary>
            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-pool-6rcq3tobayc20t***</para>
            /// </summary>
            [NameInMap("IpamPoolId")]
            [Validation(Required=false)]
            public string IpamPoolId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-scope-glfmcyldpm8lsy****</para>
            /// </summary>
            [NameInMap("IpamScopeId")]
            [Validation(Required=false)]
            public string IpamScopeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Managed</para>
            /// </summary>
            [NameInMap("ManagementStatus")]
            [Validation(Required=false)]
            public string ManagementStatus { get; set; }

            [NameInMap("OverlapDetail")]
            [Validation(Required=false)]
            public List<ListIpamResourceCidrsResponseBodyIpamResourceCidrsOverlapDetail> OverlapDetail { get; set; }
            public class ListIpamResourceCidrsResponseBodyIpamResourceCidrsOverlapDetail : TeaModel {
                [NameInMap("OverlapResourceCidr")]
                [Validation(Required=false)]
                public string OverlapResourceCidr { get; set; }

                [NameInMap("OverlapResourceId")]
                [Validation(Required=false)]
                public string OverlapResourceId { get; set; }

                [NameInMap("OverlapResourceRegion")]
                [Validation(Required=false)]
                public string OverlapResourceRegion { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Nonoverlapping</para>
            /// </summary>
            [NameInMap("OverlapStatus")]
            [Validation(Required=false)]
            public string OverlapStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-bp16qjewdsunr41m1****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>132193271328****</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.1.0/24</para>
            /// </summary>
            [NameInMap("SourceCidr")]
            [Validation(Required=false)]
            public string SourceCidr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>49A9DE56-B68C-5FFC-BC06-509D086F287C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
