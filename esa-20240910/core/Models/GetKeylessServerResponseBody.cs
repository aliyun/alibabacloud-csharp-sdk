// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetKeylessServerResponseBody : TeaModel {
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
        /// <para>baba39055622c008b90285a8838e****</para>
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
        /// <para>The Keyless server port. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3558df77-8a7a-4060-a900-2d794940****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
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
        /// <para>The modification time. The time follows the format YYYY-MM-DDTHH:MM:SS+08:00 in the UTC/GMT time zone.</para>
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

}
