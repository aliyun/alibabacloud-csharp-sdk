// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetKeylessServerRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keyless.example.com</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verify")]
        [Validation(Required=false)]
        public bool? Verify { get; set; }

    }

}
