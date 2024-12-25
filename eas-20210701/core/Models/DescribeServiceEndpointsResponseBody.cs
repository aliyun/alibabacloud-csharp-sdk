// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Nzc5N2FhN<b><b>TQ0YzBmYTIyN2MxZTUxN2NkYjg4MTJmMWQxZmY1</b></b></para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public DescribeServiceEndpointsResponseBodyEndpoints Endpoints { get; set; }
        public class DescribeServiceEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>nlb-5q4sp7u6oorkha****</para>
            /// </summary>
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Nlb</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            [NameInMap("InternetEndpoints")]
            [Validation(Required=false)]
            public List<string> InternetEndpoints { get; set; }

            [NameInMap("IntranetEndpoints")]
            [Validation(Required=false)]
            public List<string> IntranetEndpoints { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Service</para>
            /// </summary>
            [NameInMap("PathType")]
            [Validation(Required=false)]
            public string PathType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9090</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>739998B5-FB39-12A3-8323-0FA340317298</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
