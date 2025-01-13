// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeGroupEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The service token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nzc5N2FhNTM4OTQ0YzBmYTIy<b><b>ZTUxN2NkYjg4MTJmMWQxZmY1</b></b></para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>The endpoints of service groups.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public DescribeGroupEndpointsResponseBodyEndpoints Endpoints { get; set; }
        public class DescribeGroupEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>The backend access ID, which varies based on the value of the EndpointType parameter.</para>
            /// <list type="bullet">
            /// <item><description>If you set EndpointType to DefaultGateway, the value of this parameter is default.</description></item>
            /// <item><description>If you set EndpointType to PrivateGateway, the value of this parameter is the ID of the dedicated gateway.</description></item>
            /// <item><description>If you set EndpointType to Nlb, the value of this parameter is the ID of the NLB instance.</description></item>
            /// <item><description>If you set EndpointType to Nacos, the value of this parameter is the ID of the Nacos instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>gw-26340kjxjx8l3r****</para>
            /// </summary>
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            /// <summary>
            /// <para>The service endpoint type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DefaultGateway: the shared gateway.</description></item>
            /// <item><description>PrivateGateway: the dedicated gateway.</description></item>
            /// <item><description>Nlb: Associate the service with the Network Load Balancer (NLB) instance.</description></item>
            /// <item><description>Nacos: Associate the service with the Nacos instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrivateGateway</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The public endpoints.</para>
            /// </summary>
            [NameInMap("InternetEndpoints")]
            [Validation(Required=false)]
            public List<string> InternetEndpoints { get; set; }

            /// <summary>
            /// <para>The internal endpoints.</para>
            /// </summary>
            [NameInMap("IntranetEndpoints")]
            [Validation(Required=false)]
            public List<string> IntranetEndpoints { get; set; }

            /// <summary>
            /// <para>The path type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Group: the path of the service group.</description></item>
            /// <item><description>Service: the path of the service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Group</para>
            /// </summary>
            [NameInMap("PathType")]
            [Validation(Required=false)]
            public string PathType { get; set; }

            /// <summary>
            /// <para>The port number. This parameter takes effect only when you associate the service with an NLB or Nacos instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9090</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>890772EF-3AD6-129A-8E15-8F349C944783</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
