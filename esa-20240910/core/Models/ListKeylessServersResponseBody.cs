// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListKeylessServersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-280B-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListKeylessServersResponseBodyResult> Result { get; set; }
        public class ListKeylessServersResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----****</para>
            /// </summary>
            [NameInMap("CaCertificate")]
            [Validation(Required=false)]
            public string CaCertificate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----****</para>
            /// </summary>
            [NameInMap("ClientCertificate")]
            [Validation(Required=false)]
            public string ClientCertificate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-----BEGIN RSA PRIVATE KEY-----****</para>
            /// </summary>
            [NameInMap("ClientPrivateKey")]
            [Validation(Required=false)]
            public string ClientPrivateKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-06-24 07:48:51</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-20 06:18:42</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Verify")]
            [Validation(Required=false)]
            public bool? Verify { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>54362329990032</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
