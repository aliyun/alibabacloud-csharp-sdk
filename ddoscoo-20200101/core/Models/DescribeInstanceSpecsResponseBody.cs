// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceSpecsResponseBody : TeaModel {
        /// <summary>
        /// <para>The specifications of the Anti-DDoS Pro or Anti-DDoS Premium instances.</para>
        /// </summary>
        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceSpecsResponseBodyInstanceSpecs> InstanceSpecs { get; set; }
        public class DescribeInstanceSpecsResponseBodyInstanceSpecs : TeaModel {
            /// <summary>
            /// <para>The clean bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BandwidthMbps")]
            [Validation(Required=false)]
            public int? BandwidthMbps { get; set; }

            /// <summary>
            /// <para>The basic protection bandwidth. Unit: Gbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("BaseBandwidth")]
            [Validation(Required=false)]
            public int? BaseBandwidth { get; set; }

            /// <summary>
            /// <para>The minimum mitigation bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BaseProtectionBandwidth")]
            [Validation(Required=false)]
            public long? BaseProtectionBandwidth { get; set; }

            /// <summary>
            /// <para>The concurrent connections limit of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("ConnLimit")]
            [Validation(Required=false)]
            public long? ConnLimit { get; set; }

            /// <summary>
            /// <para>The new connections limit of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("CpsLimit")]
            [Validation(Required=false)]
            public long? CpsLimit { get; set; }

            /// <summary>
            /// <para>The number of available advanced mitigation sessions for the current month. A value of <b>-1</b> indicates an unlimited number of sessions.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the <b>RegionId</b> request parameter is set to <b>ap-southeast-1</b>, which indicates that Anti-DDoS Pro or Anti-DDoS Premium instances outside the Chinese mainland are queried.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DefenseCount")]
            [Validation(Required=false)]
            public int? DefenseCount { get; set; }

            /// <summary>
            /// <para>The number of domain names that can be protected by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DomainLimit")]
            [Validation(Required=false)]
            public int? DomainLimit { get; set; }

            /// <summary>
            /// <para>The burstable protection bandwidth. Unit: Gbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ElasticBandwidth")]
            [Validation(Required=false)]
            public int? ElasticBandwidth { get; set; }

            /// <summary>
            /// <para>The burstable clean bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("ElasticBw")]
            [Validation(Required=false)]
            public int? ElasticBw { get; set; }

            /// <summary>
            /// <para>The billing method for the burstable clean bandwidth of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>day</b>: daily 95th percentile metering method.</description></item>
            /// <item><description><b>month</b>: monthly 95th percentile metering method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("ElasticBwModel")]
            [Validation(Required=false)]
            public string ElasticBwModel { get; set; }

            /// <summary>
            /// <para>The burstable QPS. Unit: QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ElasticQps")]
            [Validation(Required=false)]
            public long? ElasticQps { get; set; }

            /// <summary>
            /// <para>The billing method for the burstable QPS of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>day</b>: daily 95th percentile metering method.</description></item>
            /// <item><description><b>month</b>: monthly 95th percentile metering method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("ElasticQpsMode")]
            [Validation(Required=false)]
            public string ElasticQpsMode { get; set; }

            /// <summary>
            /// <para>The feature edition of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: Standard feature edition.</description></item>
            /// <item><description><b>enhance</b>: Enhanced feature edition.</description></item>
            /// <item><description><b>cnhk</b>: Acceleration line.</description></item>
            /// <item><description><b>cnhk_default</b>: Standard secure acceleration line feature.</description></item>
            /// <item><description><b>cnhk_enhance</b>: Enhanced secure acceleration line feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("FunctionVersion")]
            [Validation(Required=false)]
            public string FunctionVersion { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-zvp2eibz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of ports that can be protected by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PortLimit")]
            [Validation(Required=false)]
            public int? PortLimit { get; set; }

            /// <summary>
            /// <para>The clean queries per second (QPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("QpsLimit")]
            [Validation(Required=false)]
            public int? QpsLimit { get; set; }

            /// <summary>
            /// <para>The clean bandwidth throttling limit of the instance. Valid values: 0 to 15360. A value of 0 indicates that no throttling is applied. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RealLimitBw")]
            [Validation(Required=false)]
            public long? RealLimitBw { get; set; }

            /// <summary>
            /// <para>The number of sites that can be protected by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SiteLimit")]
            [Validation(Required=false)]
            public int? SiteLimit { get; set; }

        }

        /// <summary>
        /// <para>The request ID. This ID is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E3A9B5F-5DDB-593D-A1E6-F1F451DB5E0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
