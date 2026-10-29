// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The alias of the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>337639*****24964-cn-qingdao</para>
        /// </summary>
        [NameInMap("AliasId")]
        [Validation(Required=false)]
        public string AliasId { get; set; }

        /// <summary>
        /// <para>The name of the application used by the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The callback triggered when the device status in the workspace is updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <para>The time when the workspace was created. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-28T17:00:17Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The workspace description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Shanghai Expressway Monitoring</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the workspace is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The GB/T 28181 ID associated with the workspace.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to workspaces that are accessed by using the GB/T 28181 protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3100000*****0000001</para>
        /// </summary>
        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        /// <summary>
        /// <para>The IP address of the GB/T 28181 signaling server associated with the workspace.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to workspaces that are accessed by using the GB/T 28181 protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.10</para>
        /// </summary>
        [NameInMap("GbIp")]
        [Validation(Required=false)]
        public string GbIp { get; set; }

        /// <summary>
        /// <para>The server port of the GB/T 28181 signaling server associated with the workspace.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to workspaces that are accessed by using the GB/T 28181 protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5060</para>
        /// </summary>
        [NameInMap("GbPort")]
        [Validation(Required=false)]
        public long? GbPort { get; set; }

        /// <summary>
        /// <para>The TCP port of the GB/T 28181 signaling server provided by the workspace.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to workspaces that are accessed by using the GB/T 28181 protocol.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("GbTcpPorts")]
        [Validation(Required=false)]
        public List<string> GbTcpPorts { get; set; }

        /// <summary>
        /// <para>The UDP port of the GB/T 28181 signaling server provided by the workspace.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to workspaces that are accessed by using the GB/T 28181 protocol.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("GbUdpPorts")]
        [Validation(Required=false)]
        public List<string> GbUdpPorts { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>337639****224964-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The access protocol used by the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>gb28181</description></item>
        /// <item><description>rtmp</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gb28181</para>
        /// </summary>
        [NameInMap("InProtocol")]
        [Validation(Required=false)]
        public string InProtocol { get; set; }

        /// <summary>
        /// <para>Indicates whether on-demand stream pulling is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LazyPull")]
        [Validation(Required=false)]
        public bool? LazyPull { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Shanghai Expressway Monitoring</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The playback protocol used by the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>flv</description></item>
        /// <item><description>hls</description></item>
        /// <item><description>rtmp<remarks>
        /// <para>You can specify multiple values. Separate multiple values with commas (,).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>flv,hls,rtmp</para>
        /// </summary>
        [NameInMap("OutProtocol")]
        [Validation(Required=false)]
        public string OutProtocol { get; set; }

        /// <summary>
        /// <para>The streaming domain name used by the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("PlayDomain")]
        [Validation(Required=false)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// <para>The ingest domain name used by the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("PushDomain")]
        [Validation(Required=false)]
        public string PushDomain { get; set; }

        /// <summary>
        /// <para>The region to which the workspace belongs, which is the service center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics information of the devices in the workspace.</para>
        /// </summary>
        [NameInMap("Stats")]
        [Validation(Required=false)]
        public DescribeGroupResponseBodyStats Stats { get; set; }
        public class DescribeGroupResponseBodyStats : TeaModel {
            /// <summary>
            /// <para>The total number of devices in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("DeviceNum")]
            [Validation(Required=false)]
            public long? DeviceNum { get; set; }

            /// <summary>
            /// <para>The number of intelligent devices in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IedNum")]
            [Validation(Required=false)]
            public long? IedNum { get; set; }

            /// <summary>
            /// <para>The number of cameras in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("IpcNum")]
            [Validation(Required=false)]
            public long? IpcNum { get; set; }

            /// <summary>
            /// <para>The number of platforms in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PlatformNum")]
            [Validation(Required=false)]
            public long? PlatformNum { get; set; }

        }

        /// <summary>
        /// <para>The workspace status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
