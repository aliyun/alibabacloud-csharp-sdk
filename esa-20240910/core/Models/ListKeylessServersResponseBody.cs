// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListKeylessServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-280B-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result array.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListKeylessServersResponseBodyResult> Result { get; set; }
        public class ListKeylessServersResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The CA certificate used to verify the Keyless server certificate. This parameter takes effect only when Verify is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----****</para>
            /// </summary>
            [NameInMap("CaCertificate")]
            [Validation(Required=false)]
            public string CaCertificate { get; set; }

            /// <summary>
            /// <para>The client certificate. This parameter must be used together with the client private key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----****</para>
            /// </summary>
            [NameInMap("ClientCertificate")]
            [Validation(Required=false)]
            public string ClientCertificate { get; set; }

            /// <summary>
            /// <para>The client private key. This parameter must be used together with the client certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN RSA PRIVATE KEY-----****</para>
            /// </summary>
            [NameInMap("ClientPrivateKey")]
            [Validation(Required=false)]
            public string ClientPrivateKey { get; set; }

            /// <summary>
            /// <para>The creation time. The time follows the format YYYY-MM-DDTHH:MM:SS+08:00 in the UTC/GMT time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-18T20:33:31+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Keyless server hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>Keyless server ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>babab9db65ee5efcca9f3d41d4b5****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The Keyless server name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Keyless server port. Valid values: 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// <para>The update time. The time follows the format YYYY-MM-DDTHH:MM:SS+08:00 in the UTC/GMT time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-18T20:33:31+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether to verify the Keyless server certificate. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Verify")]
            [Validation(Required=false)]
            public bool? Verify { get; set; }

        }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54362329990032</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The site name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
