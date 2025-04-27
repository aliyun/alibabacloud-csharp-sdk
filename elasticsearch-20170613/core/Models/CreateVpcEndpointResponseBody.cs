// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateVpcEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoint domain name, which is used to configure the connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC47D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint on the service VPC side.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateVpcEndpointResponseBodyResult Result { get; set; }
        public class CreateVpcEndpointResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ep-bp1tah7zbrwmkjef****.epsrv-bp1w0p3jdirbfmt6****.cn-hangzhou.privatelink.aliyuncs.com</para>
            /// </summary>
            [NameInMap("endpointDomain")]
            [Validation(Required=false)]
            public string EndpointDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ep-bp1tah7zbrwmkjef****</para>
            /// </summary>
            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpcElasticSearchABC</para>
            /// </summary>
            [NameInMap("endpointName")]
            [Validation(Required=false)]
            public string EndpointName { get; set; }

            /// <summary>
            /// <para>The name of the service VPC-side endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>epsrv-bp1w0p3jdirbfmt6****</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

        }

    }

}
