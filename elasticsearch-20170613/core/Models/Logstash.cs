// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class Logstash : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, string> Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-07-13T03:58:07.253Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dataNode")]
        [Validation(Required=false)]
        public bool? DataNode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ls-cn-abc</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4749897600000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("endpointList")]
        [Validation(Required=false)]
        public List<LogstashEndpointList> EndpointList { get; set; }
        public class LogstashEndpointList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>172.16.xx.xx</para>
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9200</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ls-cn-n6w1o5jq****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public LogstashNetworkConfig NetworkConfig { get; set; }
        public class LogstashNetworkConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-abc</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-*</para>
            /// </summary>
            [NameInMap("vsArea")]
            [Validation(Required=false)]
            public string VsArea { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-def</para>
            /// </summary>
            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public long? NodeAmount { get; set; }

        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public LogstashNodeSpec NodeSpec { get; set; }
        public class LogstashNodeSpec : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("disk")]
            [Validation(Required=false)]
            public long? Disk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("diskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>logstash.n4.small</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>postpaid</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfm2h5vbzd****</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<LogstashTags> Tags { get; set; }
        public class LogstashTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("tagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-07-18T10:10:04.484Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6.7.0_with_X-Pack</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("zoneCount")]
        [Validation(Required=false)]
        public long? ZoneCount { get; set; }

        [NameInMap("zoneInfos")]
        [Validation(Required=false)]
        public List<LogstashZoneInfos> ZoneInfos { get; set; }
        public class LogstashZoneInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
