// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateExperimentRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the experiment. It can be set to private (visible only to the creator and their Alibaba Cloud account) or public (visible to all users). This parameter is optional. Default value: private.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The default artifact output path for all nodes associated with the experiment. Only OSS paths are currently supported.</para>
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
        /// <para>The name of the experiment. The naming rules are as follows:</para>
        /// <list type="bullet">
        /// <item><description>Must start with a lowercase or uppercase letter.</description></item>
        /// <item><description>Can contain lowercase and uppercase letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>Must be 1 to 63 characters in length.</description></item>
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
