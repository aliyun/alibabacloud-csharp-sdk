// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateChartNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic creation of a repository is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Automatic creation of a repository is enabled.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Automatic creation of a repository is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoCreateRepo")]
        [Validation(Required=false)]
        public bool? AutoCreateRepo { get; set; }

        /// <summary>
        /// <para>The default repository type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PUBLIC</c>: Public repository.</para>
        /// </description></item>
        /// <item><description><para><c>PRIVATE</c>: Private repository.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("DefaultRepoType")]
        [Validation(Required=false)]
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
        /// <para>The namespace name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace01</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

    }

}
