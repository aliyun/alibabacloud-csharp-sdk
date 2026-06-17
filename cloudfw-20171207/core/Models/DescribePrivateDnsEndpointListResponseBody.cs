// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrivateDnsEndpointListResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of private instances.</para>
        /// </summary>
        [NameInMap("AccessInstanceList")]
        [Validation(Required=false)]
        public List<DescribePrivateDnsEndpointListResponseBodyAccessInstanceList> AccessInstanceList { get; set; }
        public class DescribePrivateDnsEndpointListResponseBodyAccessInstanceList : TeaModel {
            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("AccessInstanceId")]
            [Validation(Required=false)]
            public string AccessInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the private instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AccessInstanceName")]
            [Validation(Required=false)]
            public string AccessInstanceName { get; set; }

            /// <summary>
            /// <para>The UID of the Alibaba Cloud account that owns the Cloud Firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1379490574415****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The number of domain names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DomainNameCount")]
            [Validation(Required=false)]
            public long? DomainNameCount { get; set; }

            /// <summary>
            /// <para>The type of Cloud Firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>internet</b></para>
            /// </description></item>
            /// <item><description><para><b>vpc</b></para>
            /// </description></item>
            /// <item><description><para><b>nat</b></para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("FirewallType")]
            [Validation(Required=false)]
            public List<string> FirewallType { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The value is a UNIX timestamp measured in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715075765</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The IP protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>TCP</b></para>
            /// </description></item>
            /// <item><description><para><b>UDP</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public int? IpProtocol { get; set; }

            /// <summary>
            /// <para>The UID of the Cloud Firewall member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1844802493****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// <para>The port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The primary DNS server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("PrimaryDns")]
            [Validation(Required=false)]
            public string PrimaryDns { get; set; }

            /// <summary>
            /// <para>The type of private DNS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PrivateZone</b></para>
            /// </description></item>
            /// <item><description><para><b>Custom</b> (default)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("PrivateDnsType")]
            [Validation(Required=false)]
            public string PrivateDnsType { get; set; }

            /// <summary>
            /// <para>The ID of the region where the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The standby DNS server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.2</para>
            /// </summary>
            [NameInMap("StandbyDns")]
            [Validation(Required=false)]
            public string StandbyDns { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>creating</b>: The instance is being created.</para>
            /// </description></item>
            /// <item><description><para><b>deleting</b>: The instance is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>normal</b>: The instance is running as expected.</para>
            /// </description></item>
            /// <item><description><para><b>updating</b>: The instance is being updated.</para>
            /// </description></item>
            /// <item><description><para><b>abnormal</b>: The instance is in an abnormal state.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The unique ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zelphbaourpun****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84D6-0DE4-4797-A1E8-00090****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
