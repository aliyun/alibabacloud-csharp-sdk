// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateRepositoryRequest : TeaModel {
        /// <summary>
        /// <para>The repository description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo-for-test</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

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
        /// <para>The repository ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-tquyps22md8p****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsp/domain-microapp</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The name of the repository namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ejiayou-other</para>
        /// </summary>
        [NameInMap("RepoNamespaceName")]
        [Validation(Required=false)]
        public string RepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The repository type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PUBLIC</c>: public repository</description></item>
        /// <item><description><c>PRIVATE</c>: private repository</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("RepoType")]
        [Validation(Required=false)]
        public string RepoType { get; set; }

        /// <summary>
        /// <para>The summary.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test repo</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>Specifies whether image tag immutability is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enabled</description></item>
        /// <item><description><c>false</c>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TagImmutability")]
        [Validation(Required=false)]
        public bool? TagImmutability { get; set; }

    }

}
