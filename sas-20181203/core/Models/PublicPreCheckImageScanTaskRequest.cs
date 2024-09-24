// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicPreCheckImageScanTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6a5e103187b31a94592a47a5858617f7****</para>
        /// </summary>
        [NameInMap("Digests")]
        [Validation(Required=false)]
        public string Digests { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-uf6j8vq9l4r5ntht****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acr</para>
        /// </summary>
        [NameInMap("RegistryTypes")]
        [Validation(Required=false)]
        public string RegistryTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>crr-vridcl4****</para>
        /// </summary>
        [NameInMap("RepoIds")]
        [Validation(Required=false)]
        public string RepoIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>centos</para>
        /// </summary>
        [NameInMap("RepoNames")]
        [Validation(Required=false)]
        public string RepoNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hanghai-namespace</para>
        /// </summary>
        [NameInMap("RepoNamespaces")]
        [Validation(Required=false)]
        public string RepoNamespaces { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
