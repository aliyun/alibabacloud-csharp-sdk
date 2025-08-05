// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrivateDnsEndpointListResponseBody : TeaModel {
        [NameInMap("AccessInstanceList")]
        [Validation(Required=false)]
        public List<DescribePrivateDnsEndpointListResponseBodyAccessInstanceList> AccessInstanceList { get; set; }
        public class DescribePrivateDnsEndpointListResponseBodyAccessInstanceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("AccessInstanceId")]
            [Validation(Required=false)]
            public string AccessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AccessInstanceName")]
            [Validation(Required=false)]
            public string AccessInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1379490574415****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DomainNameCount")]
            [Validation(Required=false)]
            public long? DomainNameCount { get; set; }

            [NameInMap("FirewallType")]
            [Validation(Required=false)]
            public List<string> FirewallType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1715075765</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public int? IpProtocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1844802493****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("PrimaryDns")]
            [Validation(Required=false)]
            public string PrimaryDns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("PrivateDnsType")]
            [Validation(Required=false)]
            public string PrivateDnsType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.1.1.2</para>
            /// </summary>
            [NameInMap("StandbyDns")]
            [Validation(Required=false)]
            public string StandbyDns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-2zelphbaourpun****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>850A84D6-0DE4-4797-A1E8-00090****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
