// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of alerts in your website assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AlarmCount")]
        [Validation(Required=false)]
        public int? AlarmCount { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The asset information related to the domain name.</para>
        /// </summary>
        [NameInMap("DomainDetailItems")]
        [Validation(Required=false)]
        public List<DescribeDomainDetailResponseBodyDomainDetailItems> DomainDetailItems { get; set; }
        public class DescribeDomainDetailResponseBodyDomainDetailItems : TeaModel {
            /// <summary>
            /// <para>The Asset Type of the asset under the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: ECS</description></item>
            /// <item><description><b>1</b>: load balancing</description></item>
            /// <item><description><b>2</b>: NAT gateway</description></item>
            /// <item><description><b>3</b>: RDS database</description></item>
            /// <item><description><b>4</b>: MongoDB database</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-m5e6w7dzsktt6mz4***</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iZm5e6w7dzsktt6mz4yimeZ-6****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The UUID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1g9dohoyin9cjhn6****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID. The China value is a unique identifier that Alibaba Cloud generates for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3A85CFCF-05C8-451A-9E41-C0D5E96BA407</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The root domain name that corresponds to the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("RootDomain")]
        [Validation(Required=false)]
        public string RootDomain { get; set; }

        /// <summary>
        /// <para>The total number of vulnerabilities in your website assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("VulCount")]
        [Validation(Required=false)]
        public int? VulCount { get; set; }

    }

}
