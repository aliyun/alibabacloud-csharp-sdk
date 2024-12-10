// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class SendCustomEventRequest : TeaModel {
        /// <summary>
        /// <para>User ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1214484929940219</para>
        /// </summary>
        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// <para>Data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aegis_suspicious_event</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// <para>Event details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>疑似病毒木马启动运行。</para>
        /// </summary>
        [NameInMap("EventDescription")]
        [Validation(Required=false)]
        public string EventDescription { get; set; }

        /// <summary>
        /// <para>Alert event details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;提示&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;在您的系统上发现可疑进程启动行为，通常与病毒木马或入侵事件相关&quot;},{&quot;name&quot;:&quot;ATT&amp;CK攻击阶段&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;代码执行&quot;},{&quot;name&quot;:&quot;恶意行为&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;可疑的漏洞利用代码执行&quot;},{&quot;name&quot;:&quot;规则类型&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;进程启动&quot;},{&quot;name&quot;:&quot;规则引擎&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;精准攻击识别引擎&quot;},{&quot;name&quot;:&quot;处置动作&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;阻断行为&quot;},{&quot;name&quot;:&quot;进程路径&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;/usr/bin/python3.9&quot;},{&quot;name&quot;:&quot;命令行&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;python3 /root/poc/python/cve-2018-15473.py --username root --port 22&quot;},{&quot;name&quot;:&quot;父进程路径&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;/bin/gunkit&quot;},{&quot;name&quot;:&quot;父进程命令行&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;gunkit serve-grpc --addr unix:///data/gunkit-grpc.sock&quot;},{&quot;name&quot;:&quot;进程ID&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;22714&quot;},{&quot;name&quot;:&quot;父进程ID&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;2986&quot;},{&quot;name&quot;:&quot;描述&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;主动防御检测到可疑进程启动行为，这类可疑进程通常存在于特殊的系统目录，或通过后缀伪装成文档/音频/图片等文件诱导用户运行，该异常行为已被成功拦截&quot;},{&quot;name&quot;:&quot;处置建议&quot;,&quot;type&quot;:&quot;text&quot;,&quot;value&quot;:&quot;请您及时排查是否是正常的业务操作，如果您觉得此次拦截是非预期的，那您可以在主动防御 - 恶意行为防御页面中，关闭“可疑进程启动“规则集或者将受影响机器从管理主机中移除&quot;},{&quot;name&quot;:&quot;父进程关系&quot;,&quot;type&quot;:&quot;processChain&quot;,&quot;value&quot;:&quot;1:::/usr/lib/systemd/systemd --switched-root --system --deserialize 22 &amp;&amp;&amp; 2939:::/usr/local/bin/containerd-shim-runc-v2 -namespace moby -id 270f164903b47d4e219b410b8d11d9079a7ad1bac8133aea604598300d3b03d5 -address /run/containerd/containerd.sock &amp;&amp;&amp; 2962:::/usr/bin/python3 /usr/bin/supervisord -n &amp;&amp;&amp; 2986:::gunkit serve-grpc --addr unix:///data/gunkit-grpc.sock&quot;}]</para>
        /// </summary>
        [NameInMap("EventDetails")]
        [Validation(Required=false)]
        public string EventDetails { get; set; }

        /// <summary>
        /// <para>Event name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客户端离线</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>Event type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUSP_CUSTOM_CFW</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>Alert discovery time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-23 14:47:34</para>
        /// </summary>
        [NameInMap("FindTime")]
        [Validation(Required=false)]
        public long? FindTime { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf60h3ns25bzq9eyf8ps</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>猫吉-售卖-MDR扫描器集群1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Whether to send.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsSend")]
        [Validation(Required=false)]
        public string IsSend { get; set; }

        /// <summary>
        /// <para>Event level.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serious</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The first occurrence time of the alert event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1724956996000</para>
        /// </summary>
        [NameInMap("OccurrenceTime")]
        [Validation(Required=false)]
        public long? OccurrenceTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>Product name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudSecCenter</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>Unique ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68888f02-98f2-492b-a2b2-5b13295755b7</para>
        /// </summary>
        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// <para>UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93B6CDAB-7D2E-33D2-9EBA-25D561A2E95F</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
