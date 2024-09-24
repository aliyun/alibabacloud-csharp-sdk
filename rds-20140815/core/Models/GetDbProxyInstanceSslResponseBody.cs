// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GetDbProxyInstanceSslResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of SSL encryption settings.</para>
        /// </summary>
        [NameInMap("DbProxyCertListItems")]
        [Validation(Required=false)]
        public GetDbProxyInstanceSslResponseBodyDbProxyCertListItems DbProxyCertListItems { get; set; }
        public class GetDbProxyInstanceSslResponseBodyDbProxyCertListItems : TeaModel {
            [NameInMap("DbProxyCertListItems")]
            [Validation(Required=false)]
            public List<GetDbProxyInstanceSslResponseBodyDbProxyCertListItemsDbProxyCertListItems> DbProxyCertListItems { get; set; }
            public class GetDbProxyInstanceSslResponseBodyDbProxyCertListItemsDbProxyCertListItems : TeaModel {
                /// <summary>
                /// <para>The dedicated proxy endpoint for which SSL encryption is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1234.rwlb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("CertCommonName")]
                [Validation(Required=false)]
                public string CertCommonName { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-t4n3axxxxx</para>
                /// </summary>
                [NameInMap("DbInstanceName")]
                [Validation(Required=false)]
                public string DbInstanceName { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated proxy endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>buxxxxxxx</para>
                /// </summary>
                [NameInMap("EndpointName")]
                [Validation(Required=false)]
                public string EndpointName { get; set; }

                /// <summary>
                /// <para>The default identifier of the dedicated proxy endpoint. The value is fixed as <b>RWSplit</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RWSplit</para>
                /// </summary>
                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// <para>The time at which the certificate expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-16T08:43:20Z</para>
                /// </summary>
                [NameInMap("SslExpiredTime")]
                [Validation(Required=false)]
                public string SslExpiredTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D330E60C-8AAA-4D63-8F64-5B78F4692F98</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
