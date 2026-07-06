// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateNamespaceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether a repository is automatically created when an image is pushed to a repository that does not yet exist in the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoCreateRepo")]
        [Validation(Required=false)]
        public bool? AutoCreateRepo { get; set; }

        [NameInMap("DefaultRepoConfiguration")]
        [Validation(Required=false)]
        public string DefaultRepoConfigurationShrink { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The default type of automatically created repositories. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PUBLIC</c>: public</para>
        /// </description></item>
        /// <item><description><para><c>PRIVATE</c>: private</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
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
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the namespace. The name must be 2 to 120 characters long and can contain only lowercase letters, digits, and the following separators: underscores (_), hyphens (-), and periods (.). A separator cannot be used as the first or last character.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace1</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

    }

}
