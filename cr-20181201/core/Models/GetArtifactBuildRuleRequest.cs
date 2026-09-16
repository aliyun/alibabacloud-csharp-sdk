// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactBuildRuleRequest : TeaModel {
        /// <summary>
        /// <para>The type of the accelerated image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ACCELERATED_IMAGE</c>: generates an accelerated image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACCELERATED_IMAGE</para>
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The build rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crabr-o2670wqz2n70****</para>
        /// </summary>
        [NameInMap("BuildRuleId")]
        [Validation(Required=false)]
        public string BuildRuleId { get; set; }

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
        /// <para>The ID of the scope in which the rule takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ScopeId: the image repository ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>crr-8dz3aedjqlmk****</para>
        /// </summary>
        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// <para>The scope of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>REPOSITORY</c>: repository level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>REPOSITORY</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
