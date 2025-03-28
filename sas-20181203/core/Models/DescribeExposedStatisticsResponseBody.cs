// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of high-risk vulnerabilities that are exposed on the Internet and can be exploited by attackers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExposedAsapVulCount")]
        [Validation(Required=false)]
        public int? ExposedAsapVulCount { get; set; }

        /// <summary>
        /// <para>The total number of system components that are exposed on the Internet. The components include OpenSSL and OpenSSH.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ExposedComponentCount")]
        [Validation(Required=false)]
        public int? ExposedComponentCount { get; set; }

        /// <summary>
        /// <para>The number of ApsaraDB for MongoDB instances that are exposed on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExposedDdsCount")]
        [Validation(Required=false)]
        public int? ExposedDdsCount { get; set; }

        /// <summary>
        /// <para>The number of Elastic Compute Service (ECS) instances that are exposed on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ExposedEcsCount")]
        [Validation(Required=false)]
        public int? ExposedEcsCount { get; set; }

        /// <summary>
        /// <para>The total number of assets that are exposed on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ExposedInstanceCount")]
        [Validation(Required=false)]
        public int? ExposedInstanceCount { get; set; }

        /// <summary>
        /// <para>The total number of IP addresses that are exposed on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ExposedIpCount")]
        [Validation(Required=false)]
        public int? ExposedIpCount { get; set; }

        /// <summary>
        /// <para>The number of ApsaraDB for Redis instances that are exposed on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ExposedKvstoreCount")]
        [Validation(Required=false)]
        public int? ExposedKvstoreCount { get; set; }

        /// <summary>
        /// <para>The total number of medium-risk vulnerabilities that are exposed on the Internet and can be exploited by attackers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ExposedLaterVulCount")]
        [Validation(Required=false)]
        public int? ExposedLaterVulCount { get; set; }

        /// <summary>
        /// <para>The total number of low-risk vulnerabilities that are exposed on the Internet and can be exploited by attackers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExposedNntfVulCount")]
        [Validation(Required=false)]
        public int? ExposedNntfVulCount { get; set; }

        /// <summary>
        /// <para>The total number of ports that are exposed on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ExposedPortCount")]
        [Validation(Required=false)]
        public int? ExposedPortCount { get; set; }

        /// <summary>
        /// <para>The number of ApsaraDB RDS instances that are exposed on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExposedRdsCount")]
        [Validation(Required=false)]
        public int? ExposedRdsCount { get; set; }

        /// <summary>
        /// <para>The total number of system keys that are detected on your servers and are exposed on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ExposedWeekPasswordMachineCount")]
        [Validation(Required=false)]
        public int? ExposedWeekPasswordMachineCount { get; set; }

        /// <summary>
        /// <para>The total number of gateway assets that are exposed on the Internet. The gateway assets include NAT gateways and Server Load Balancer (SLB) instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("GatewayAssetCount")]
        [Validation(Required=false)]
        public int? GatewayAssetCount { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B897D10-B3CD-4A93-A5FA-591F3ED12A86</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
