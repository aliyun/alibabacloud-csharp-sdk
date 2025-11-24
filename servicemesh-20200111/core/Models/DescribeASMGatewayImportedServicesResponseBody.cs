// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeASMGatewayImportedServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the imported services.</para>
        /// </summary>
        [NameInMap("ImportedServices")]
        [Validation(Required=false)]
        public List<DescribeASMGatewayImportedServicesResponseBodyImportedServices> ImportedServices { get; set; }
        public class DescribeASMGatewayImportedServicesResponseBodyImportedServices : TeaModel {
            /// <summary>
            /// <para>The name of a service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>productpage</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The namespace in which the service resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("ServiceNamespace")]
            [Validation(Required=false)]
            public string ServiceNamespace { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11fd0027-c27e-41bb-a565-75583054****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
