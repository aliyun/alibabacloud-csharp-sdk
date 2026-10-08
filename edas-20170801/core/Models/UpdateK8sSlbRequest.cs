// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sSlbRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Call <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a> to get this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5a166fbd-<b><b>-</b></b>-a286-781659d9f54c</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster. Call <a href="https://help.aliyun.com/document_detail/181437.html">GetK8sCluster</a> to get this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>712082c3-<b><b>-</b></b>-9217-a947b5cde6ee</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable overwriting the SLB listener configuration.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Disables overwriting.</para>
        /// </description></item>
        /// <item><description><para>false: Allows overwriting.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableForceOverride")]
        [Validation(Required=false)]
        public bool? DisableForceOverride { get; set; }

        /// <summary>
        /// <para>The frontend port. The value ranges from 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm of the SLB instance. If you do not set this parameter, rr is used. The supported algorithms are round-robin (rr) and weighted round-robin (wrr).</para>
        /// <list type="bullet">
        /// <item><description><para>Weighted round-robin (wrr): Backend servers with higher weights receive more requests.</para>
        /// </description></item>
        /// <item><description><para>Round-robin (rr): Requests are distributed to backend servers in sequence.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>This parameter is used for scenarios that involve multiple ports or protocols other than TCP. The value must be a JSON array. For example:
        /// [{&quot;targetPort&quot;:8080,&quot;port&quot;:82,&quot;loadBalancerProtocol&quot;:&quot;TCP&quot;},{&quot;port&quot;:81,&quot;certId&quot;:&quot;1362469756373809_16c185d6fa2_1914500329_-xxxxxxx&quot;,&quot;targetPort&quot;:8181,&quot;loadBalancerProtocol&quot;:&quot;HTTPS&quot;}]</para>
        /// <list type="bullet">
        /// <item><description><para>port: Required. The frontend port. The value ranges from 1 to 65535. Each port number must be unique.</para>
        /// </description></item>
        /// <item><description><para>targetPort: Required. The backend port. The value ranges from 1 to 65535.</para>
        /// </description></item>
        /// <item><description><para>loadBalancerProtocol: Required. Only TCP and HTTPS are supported. For HTTP listeners, set this parameter to TCP.</para>
        /// </description></item>
        /// <item><description><para>certId: This parameter is required for HTTPS listeners. It specifies the ID of a certificate that you can purchase in the SLB console.</para>
        /// </description></item>
        /// <item><description><para>Note: This parameter is used to support multiple ports and must be used with the appId, clusterId, type, and slbId parameters.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;targetPort&quot;:8080,&quot;port&quot;:82,&quot;loadBalancerProtocol&quot;:&quot;TCP&quot;},{&quot;port&quot;:81,&quot;certId&quot;:&quot;136246975637380916c185d6fa21914500329_-xxxxxxx&quot;,&quot;targetPort&quot;:8181,&quot;lo adBalancerProtocol&quot;:&quot;HTTPS&quot;}</para>
        /// </summary>
        [NameInMap("ServicePortInfos")]
        [Validation(Required=false)]
        public string ServicePortInfos { get; set; }

        /// <summary>
        /// <para>The name of the SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLB_doctest</para>
        /// </summary>
        [NameInMap("SlbName")]
        [Validation(Required=false)]
        public string SlbName { get; set; }

        /// <summary>
        /// <para>The protocol of the SLB instance. Currently, only TCP is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("SlbProtocol")]
        [Validation(Required=false)]
        public string SlbProtocol { get; set; }

        /// <summary>
        /// <para>The specification of the SLB instance. The following specifications are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>slb.s1.small</para>
        /// </description></item>
        /// <item><description><para>slb.s2.small</para>
        /// </description></item>
        /// <item><description><para>slb.s2.medium</para>
        /// </description></item>
        /// <item><description><para>slb.s3.small</para>
        /// </description></item>
        /// <item><description><para>slb.s3.medium</para>
        /// </description></item>
        /// <item><description><para>slb.s3.large</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not set this parameter, the default value is slb.s1.small.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// <para>The backend port, which is the service port of the application. The value ranges from 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8082</para>
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public string TargetPort { get; set; }

        /// <summary>
        /// <para>The type of the SLB instance.</para>
        /// <list type="bullet">
        /// <item><description><para>Internet: An Internet-facing instance.</para>
        /// </description></item>
        /// <item><description><para>Intranet: An internal-facing instance.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
