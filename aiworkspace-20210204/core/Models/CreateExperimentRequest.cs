// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateExperimentRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the experiment. It can be PRIVATE (visible only to the creator and the creator\&quot;s Alibaba Cloud account) or PUBLIC (visible to all users). This parameter is optional. The default value is PRIVATE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The default output path of artifacts for all tasks that are associated with the experiment. Only Object Storage Service (OSS) paths are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket.oss-cn-hangzhou.aliyuncs.com/test</para>
        /// </summary>
        [NameInMap("ArtifactUri")]
        [Validation(Required=false)]
        public string ArtifactUri { get; set; }

        /// <summary>
        /// <para>The labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<LabelInfo> Labels { get; set; }

        /// <summary>
        /// <para>The name of the experiment. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Start with an uppercase or lowercase letter.</para>
        /// </description></item>
        /// <item><description><para>Contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Be 1 to 63 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
