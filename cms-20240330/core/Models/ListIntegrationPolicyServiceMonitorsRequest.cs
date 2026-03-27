// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyServiceMonitorsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>release-12345678</para>
        /// </summary>
        [NameInMap("addonReleaseName")]
        [Validation(Required=false)]
        public string AddonReleaseName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("encryptYaml")]
        [Validation(Required=false)]
        public bool? EncryptYaml { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>arms-prom</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
