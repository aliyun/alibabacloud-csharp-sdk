// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyCustomScrapeJobRulesRequest : TeaModel {
        /// <summary>
        /// <para>Addon Release name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release12345678</para>
        /// </summary>
        [NameInMap("addonReleaseName")]
        [Validation(Required=false)]
        public string AddonReleaseName { get; set; }

        /// <summary>
        /// <para>Whether to encrypt Yaml.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("encryptYaml")]
        [Validation(Required=false)]
        public bool? EncryptYaml { get; set; }

        /// <summary>
        /// <para>Namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms-prom</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
