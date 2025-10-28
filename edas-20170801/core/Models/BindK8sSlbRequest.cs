// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class BindK8sSlbRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5a166fbd-<b><b>-</b></b>-a286-781659d9f54c</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>712082c3-f554-<b><b>-</b></b>-a947b5cde6ee</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The frontend port. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm for the SLB instance. If you do not specify this parameter, the default value rr is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>wrr: weighted round-robin scheduling. Backend servers that have higher weights receive more requests than those that have lower weights.</description></item>
        /// <item><description>rr: round-robin scheduling. Requests are sequentially distributed to backend servers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The information about the ports. This parameter is required if you want to configure multi-port mappings or use a protocol other than TCP. You must set this parameter to a JSON array. Example: [{&quot;targetPort&quot;:8080,&quot;port&quot;:82,&quot;loadBalancerProtocol&quot;:&quot;TCP&quot;},{&quot;port&quot;:81,&quot;certId&quot;:&quot;1362469756373809_16c185d6fa2_1914500329_-xxxxxxx&quot;,&quot;targetPort&quot;:8181,&quot;lo adBalancerProtocol&quot;:&quot;HTTPS&quot;}]</para>
        /// <list type="bullet">
        /// <item><description>port: The frontend port. Valid values: 1 to 65535. This parameter is required. Each port must be unique.</description></item>
        /// <item><description>targetPort: The backend port. Valid values: 1 to 65535. This parameter is required.</description></item>
        /// <item><description>loadBalancerProtocol: This parameter is required. Valid values: TCP and HTTPS. If the HTTP protocol is used, set this parameter to TCP.</description></item>
        /// <item><description>certId: the ID of the certificate. This parameter is required if the HTTPS protocol is used. You can purchase an SLB instance in the SLB console.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The ServicePortInfos parameter is specified to support multi-port mappings. If you want this parameter to take effect, make sure that you have set the AppId, ClusterId, Type, and SlbId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;targetPort&quot;:8080,&quot;port&quot;:82,&quot;loadBalancerProtocol&quot;:&quot;TCP&quot;},{&quot;port&quot;:81,&quot;certId&quot;:&quot;136246975637380916c185d6fa21914500329_-988as&quot;,&quot;targetPort&quot;:8181,&quot;lo adBalancerProtocol&quot;:&quot;HTTPS&quot;}]</para>
        /// </summary>
        [NameInMap("ServicePortInfos")]
        [Validation(Required=false)]
        public string ServicePortInfos { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance. If you leave this parameter empty, Enterprise Distributed Application Service (EDAS) automatically purchases an SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2ze1quax9t****iz82bjt</para>
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <para>The protocol used by the SLB instance. Valid values: TCP, HTTP, and HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("SlbProtocol")]
        [Validation(Required=false)]
        public string SlbProtocol { get; set; }

        /// <summary>
        /// <para>The instance type of the SLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>slb.s1.small</description></item>
        /// <item><description>slb.s2.small</description></item>
        /// <item><description>slb.s2.medium</description></item>
        /// <item><description>slb.s3.small</description></item>
        /// <item><description>slb.s3.medium</description></item>
        /// <item><description>slb.s3.large</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// <para>The backend port, which is also the service port of the application. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public string TargetPort { get; set; }

        /// <summary>
        /// <para>The type of the SLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>internet: Internet-facing SLB instance</description></item>
        /// <item><description>intranet: internal-facing SLB instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
