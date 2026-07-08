// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeParentPlatformsResponseBody : TeaModel {
        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>List of parent platforms.</para>
        /// </summary>
        [NameInMap("Platforms")]
        [Validation(Required=false)]
        public List<DescribeParentPlatformsResponseBodyPlatforms> Platforms { get; set; }
        public class DescribeParentPlatformsResponseBodyPlatforms : TeaModel {
            /// <summary>
            /// <para>Whether to enable automatically. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false (default)</description></item>
            /// <item><description>true</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoStart")]
            [Validation(Required=false)]
            public bool? AutoStart { get; set; }

            /// <summary>
            /// <para>Whether to enable local authentication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true (default)</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ClientAuth")]
            [Validation(Required=false)]
            public bool? ClientAuth { get; set; }

            /// <summary>
            /// <para>Local GB ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31010*****317542006</para>
            /// </summary>
            [NameInMap("ClientGbId")]
            [Validation(Required=false)]
            public string ClientGbId { get; set; }

            /// <summary>
            /// <para>Local SIP service IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>Local password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin123</para>
            /// </summary>
            [NameInMap("ClientPassword")]
            [Validation(Required=false)]
            public string ClientPassword { get; set; }

            /// <summary>
            /// <para>Local SIP service port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5160</para>
            /// </summary>
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public long? ClientPort { get; set; }

            /// <summary>
            /// <para>Local username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("ClientUsername")]
            [Validation(Required=false)]
            public string ClientUsername { get; set; }

            /// <summary>
            /// <para>Parent platform creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-10T21:00:00Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>Parent platform description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>国标级联平台描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Parent platform GB ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31000*****2170123451</para>
            /// </summary>
            [NameInMap("GbId")]
            [Validation(Required=false)]
            public string GbId { get; set; }

            /// <summary>
            /// <para>Parent platform ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>359*****374-cn-qingdao</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Parent platform SIP service IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.10</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Parent platform name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>国标级联平台测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Parent platform SIP service port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5060</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// <para>Parent platform protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>gb28181 (GB standard)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>gb28181</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>Parent platform status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on (online)</description></item>
            /// <item><description>off (offline)</description></item>
            /// <item><description>failed (failed)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of parent platforms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
