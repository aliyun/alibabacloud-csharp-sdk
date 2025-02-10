// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateHttpsBasicConfigurationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256</para>
        /// </summary>
        [NameInMap("Ciphersuite")]
        [Validation(Required=false)]
        public string Ciphersuite { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("CiphersuiteGroup")]
        [Validation(Required=false)]
        public string CiphersuiteGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Http2")]
        [Validation(Required=false)]
        public string Http2 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Http3")]
        [Validation(Required=false)]
        public string Http3 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Https")]
        [Validation(Required=false)]
        public string Https { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("OcspStapling")]
        [Validation(Required=false)]
        public string OcspStapling { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5407498413****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Tls10")]
        [Validation(Required=false)]
        public string Tls10 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Tls11")]
        [Validation(Required=false)]
        public string Tls11 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Tls12")]
        [Validation(Required=false)]
        public string Tls12 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Tls13")]
        [Validation(Required=false)]
        public string Tls13 { get; set; }

    }

}
