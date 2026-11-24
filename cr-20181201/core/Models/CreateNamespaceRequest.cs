// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic creation of an image repository is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoCreateRepo")]
        [Validation(Required=false)]
        public bool? AutoCreateRepo { get; set; }

        [NameInMap("DefaultRepoConfiguration")]
        [Validation(Required=false)]
        public RepoConfiguration DefaultRepoConfiguration { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The default repository type for automatic creation. Valid values:</para>
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
        /// <para>The name of the namespace. The name must be 2 to 120 characters in length and can contain lowercase letters and digits. The following separators are supported: underscores (_), hyphens (-), and periods (.). A separator cannot be placed at the beginning or end of the name.</para>
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
