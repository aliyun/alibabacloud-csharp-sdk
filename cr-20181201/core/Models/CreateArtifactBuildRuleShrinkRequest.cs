// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateArtifactBuildRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The type of the accelerated image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ACCELERATED_IMAGE</c>: accelerated image.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACCELERATED_IMAGE</para>
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-cxreylqvcyje****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The additional parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The ID of the scope in which the rule takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The ID of the image repository.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-pmajihou6cg0****</para>
        /// </summary>
        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// <para>The scope in which the rule takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>REPOSITORY</c>: repository level.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REPOSITORY</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
