// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateChartRepositoryRequest : TeaModel {
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
        /// <para>The name of the image repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo01</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace01</para>
        /// </summary>
        [NameInMap("RepoNamespaceName")]
        [Validation(Required=false)]
        public string RepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The default type of the repository. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PUBLIC</c>: public repository</para>
        /// </description></item>
        /// <item><description><para><c>PRIVATE</c>: private repository</para>
        /// </description></item>
        /// </list>
        /// <para>Specify either RepoType or Summary. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("RepoType")]
        [Validation(Required=false)]
        public string RepoType { get; set; }

        /// <summary>
        /// <para>The summary of the repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>summary</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

    }

}
