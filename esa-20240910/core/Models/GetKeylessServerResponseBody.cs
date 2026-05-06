// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetKeylessServerResponseBody : TeaModel {
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
        /// <para>2024-03-11T01:23:21Z</para>
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
        /// <para>baba39055622c008b90285a8838e****</para>
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
        /// <para>3558df77-8a7a-4060-a900-2d794940****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456****</para>
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
        /// <para>2025-03-13T02:13:28Z</para>
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

}
