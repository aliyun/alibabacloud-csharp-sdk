// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateExperimentRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the experiment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: Visible to all users.</description></item>
        /// <item><description>PRIVATE: Visible only to the creator and the Alibaba Cloud account.</description></item>
        /// </list>
        /// <para>Default value: PRIVATE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The default artifact output path for all tasks associated with the experiment. Currently, only OSS paths are supported.</para>
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
        /// <para>The name of the experiment. The name must meet the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a lowercase or uppercase letter.</description></item>
        /// <item><description>The name can contain uppercase letters, lowercase letters, digits, underscores (_), or hyphens (-).</description></item>
        /// <item><description>The name must be 1 to 63 characters in length.</description></item>
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
