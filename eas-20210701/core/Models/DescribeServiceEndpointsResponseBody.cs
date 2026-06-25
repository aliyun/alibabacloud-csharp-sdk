// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The service token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nzc5N2FhN<b><b>TQ0YzBmYTIyN2MxZTUxN2NkYjg4MTJmMWQxZmY1</b></b></para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>The list of service endpoints.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<DescribeServiceEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class DescribeServiceEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>The ID of the backend service. The value of this parameter varies based on the value of EndpointType:</para>
            /// <list type="bullet">
            /// <item><description><para>If EndpointType is DefaultGateway, this parameter is set to default.</para>
            /// </description></item>
            /// <item><description><para>If EndpointType is PrivateGateway, this parameter is the ID of the dedicated gateway.</para>
            /// </description></item>
            /// <item><description><para>If EndpointType is Nlb, this parameter is the ID of the NLB instance.</para>
            /// </description></item>
            /// <item><description><para>If EndpointType is Nacos, this parameter is the ID of the Nacos instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nlb-5q4sp7u6oorkha****</para>
            /// </summary>
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            /// <summary>
            /// <para>The connection type of the service endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DefaultGateway: The service is connected using a shared gateway.</para>
            /// </description></item>
            /// <item><description><para>PrivateGateway: The service is connected using a dedicated gateway.</para>
            /// </description></item>
            /// <item><description><para>Nlb: The service is attached to a Network Load Balancer (NLB) instance.</para>
            /// </description></item>
            /// <item><description><para>Nacos: The service is attached to a Nacos instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Nlb</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The list of internet-facing endpoints.</para>
            /// </summary>
            [NameInMap("InternetEndpoints")]
            [Validation(Required=false)]
            public List<string> InternetEndpoints { get; set; }

            /// <summary>
            /// <para>The list of internal endpoints.</para>
            /// </summary>
            [NameInMap("IntranetEndpoints")]
            [Validation(Required=false)]
            public List<string> IntranetEndpoints { get; set; }

            /// <summary>
            /// <para>The type of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Group: The endpoint of an audience group.</para>
            /// </description></item>
            /// <item><description><para>Service: The endpoint of a service.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Service</para>
            /// </summary>
            [NameInMap("PathType")]
            [Validation(Required=false)]
            public string PathType { get; set; }

            /// <summary>
            /// <para>The port number. This parameter is returned only when the service is attached to an NLB or Nacos instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9090</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Execution succeeded.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>739998B5-FB39-12A3-8323-0FA340317298</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
