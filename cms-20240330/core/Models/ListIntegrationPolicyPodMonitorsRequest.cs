// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyPodMonitorsRequest : TeaModel {
        /// <summary>
        /// <para>The addon release name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release-123456789</para>
        /// </summary>
        [NameInMap("addonReleaseName")]
        [Validation(Required=false)]
        public string AddonReleaseName { get; set; }

        /// <summary>
        /// <para>The collector identifier. If a release is available, specify the release name. Otherwise, specify the component name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>collector:metric-agent:policy:policy-bfd3d455fd6f4bc8</para>
        /// </summary>
        [NameInMap("collectorReleaseName")]
        [Validation(Required=false)]
        public string CollectorReleaseName { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the YAML content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("encryptYaml")]
        [Validation(Required=false)]
        public bool? EncryptYaml { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
