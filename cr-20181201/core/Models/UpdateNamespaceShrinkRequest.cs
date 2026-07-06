// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateNamespaceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Whether to automatically create a repository when an image is pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoCreateRepo")]
        [Validation(Required=false)]
        public bool? AutoCreateRepo { get; set; }

        /// <summary>
        /// <para>The default configuration for automatically created repositories.</para>
        /// </summary>
        [NameInMap("DefaultRepoConfiguration")]
        [Validation(Required=false)]
        public string DefaultRepoConfigurationShrink { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The default type for automatically created repositories. This parameter applies only if <c>AutoCreateRepo</c> is set to <c>true</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PUBLIC</c>: a public repository</para>
        /// </description></item>
        /// <item><description><para><c>PRIVATE</c>: a private repository</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("DefaultRepoType")]
        [Validation(Required=false)]
        [Obsolete]
        public string DefaultRepoType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

    }

}
