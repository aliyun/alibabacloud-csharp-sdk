// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>337639*****24964-cn-qingdao</para>
        /// </summary>
        [NameInMap("AliasId")]
        [Validation(Required=false)]
        public string AliasId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>live</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-02-28T17:00:17Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3100000*****0000001</para>
        /// </summary>
        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.10.10.10</para>
        /// </summary>
        [NameInMap("GbIp")]
        [Validation(Required=false)]
        public string GbIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5060</para>
        /// </summary>
        [NameInMap("GbPort")]
        [Validation(Required=false)]
        public long? GbPort { get; set; }

        [NameInMap("GbTcpPorts")]
        [Validation(Required=false)]
        public List<string> GbTcpPorts { get; set; }

        [NameInMap("GbUdpPorts")]
        [Validation(Required=false)]
        public List<string> GbUdpPorts { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>337639****224964-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gb28181</para>
        /// </summary>
        [NameInMap("InProtocol")]
        [Validation(Required=false)]
        public string InProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LazyPull")]
        [Validation(Required=false)]
        public bool? LazyPull { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>flv,hls,rtmp</para>
        /// </summary>
        [NameInMap("OutProtocol")]
        [Validation(Required=false)]
        public string OutProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("PlayDomain")]
        [Validation(Required=false)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("PushDomain")]
        [Validation(Required=false)]
        public string PushDomain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Stats")]
        [Validation(Required=false)]
        public DescribeGroupResponseBodyStats Stats { get; set; }
        public class DescribeGroupResponseBodyStats : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("DeviceNum")]
            [Validation(Required=false)]
            public long? DeviceNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IedNum")]
            [Validation(Required=false)]
            public long? IedNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("IpcNum")]
            [Validation(Required=false)]
            public long? IpcNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PlatformNum")]
            [Validation(Required=false)]
            public long? PlatformNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
