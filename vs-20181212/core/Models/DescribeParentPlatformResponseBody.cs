// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeParentPlatformResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the parent platform automatically. Valid values:</para>
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
        /// <para>Specifies whether to enable local authentication. Valid values:</para>
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
        /// <para>The local GB ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31010*****317542006</para>
        /// </summary>
        [NameInMap("ClientGbId")]
        [Validation(Required=false)]
        public string ClientGbId { get; set; }

        /// <summary>
        /// <para>The local SIP service IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The local password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin123</para>
        /// </summary>
        [NameInMap("ClientPassword")]
        [Validation(Required=false)]
        public string ClientPassword { get; set; }

        /// <summary>
        /// <para>The local SIP service port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5160</para>
        /// </summary>
        [NameInMap("ClientPort")]
        [Validation(Required=false)]
        public long? ClientPort { get; set; }

        /// <summary>
        /// <para>The local username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("ClientUsername")]
        [Validation(Required=false)]
        public string ClientUsername { get; set; }

        /// <summary>
        /// <para>The time when the parent platform was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The description of the parent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>级联平台描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The GB ID of the parent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31000*****2170123451</para>
        /// </summary>
        [NameInMap("GbId")]
        [Validation(Required=false)]
        public string GbId { get; set; }

        /// <summary>
        /// <para>The ID of the parent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>359*****374-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The SIP service IP address of the parent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.10</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The name of the parent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>国标级联平台测试</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The SIP service port of the parent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5060</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        /// <summary>
        /// <para>The protocol of the parent platform. Valid values:</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the parent platform. Valid values:</para>
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

}
