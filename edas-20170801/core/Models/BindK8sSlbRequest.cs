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
        /// <para>The frontend port. The value must be an integer from 1 to 65,535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. If you do not specify this parameter, \<c>rr\\</c> is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>wrr: weighted round-robin. Backend servers with higher weights receive more requests.</para>
        /// </description></item>
        /// <item><description><para>rr: round-robin. Requests are distributed to backend servers in sequence.</para>
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
        /// <para>The information about the service ports. Use this parameter to configure multiple listeners or use protocols other than TCP.
        /// This parameter must be a JSON array. Example:
        /// [{&quot;targetPort&quot;:8080,&quot;port&quot;:82,&quot;loadBalancerProtocol&quot;:&quot;TCP&quot;},{&quot;port&quot;:81,&quot;certId&quot;:&quot;1362469756373809_16c185d6fa2_1914500329_-xxxxxxx&quot;,&quot;targetPort&quot;:8181,&quot;loadBalancerProtocol&quot;:&quot;HTTPS&quot;}]</para>
        /// <list type="bullet">
        /// <item><description><para>port: Required. The frontend port. The value must be an integer from 1 to 65,535. Each port number must be unique.</para>
        /// </description></item>
        /// <item><description><para>targetPort: Required. The backend port. The value must be an integer from 1 to 65,535.</para>
        /// </description></item>
        /// <item><description><para>loadBalancerProtocol: Required. The frontend protocol. Valid values: TCP and HTTPS. For HTTP, use TCP.</para>
        /// </description></item>
        /// <item><description><para>certId: Required if you use the HTTPS protocol. You can purchase a certificate in the SLB console.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is used to configure multiple listeners. You must use it with the appId, clusterId, type, and slbId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;targetPort&quot;:8080,&quot;port&quot;:82,&quot;loadBalancerProtocol&quot;:&quot;TCP&quot;},{&quot;port&quot;:81,&quot;certId&quot;:&quot;136246975637380916c185d6fa21914500329_-988as&quot;,&quot;targetPort&quot;:8181,&quot;lo adBalancerProtocol&quot;:&quot;HTTPS&quot;}]</para>
        /// </summary>
        [NameInMap("ServicePortInfos")]
        [Validation(Required=false)]
        public string ServicePortInfos { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance. If you do not specify this parameter, EDAS automatically purchases a new SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2ze1quax9t****iz82bjt</para>
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <para>The frontend protocol for the SLB instance. Valid values: TCP, HTTP, and HTTPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("SlbProtocol")]
        [Validation(Required=false)]
        public string SlbProtocol { get; set; }

        /// <summary>
        /// <para>The specification of the SLB instance.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// <para>The backend port. This port is also the service port of the application. The value must be an integer from 1 to 65,535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public string TargetPort { get; set; }

        /// <summary>
        /// <para>The type of the SLB instance.</para>
        /// <list type="bullet">
        /// <item><description><para>internet: an internet-facing SLB instance.</para>
        /// </description></item>
        /// <item><description><para>intranet: an internal-facing SLB instance.</para>
        /// </description></item>
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
