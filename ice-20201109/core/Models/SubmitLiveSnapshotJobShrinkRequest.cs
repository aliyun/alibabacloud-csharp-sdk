// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveSnapshotJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The snapshot callback URL.</para>
        /// <list type="bullet">
        /// <item><description>It cannot exceed 255 characters in length.</description></item>
        /// <item><description>Both HTTP and HTTPS URLs are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/snapshot/callback">http://www.aliyun.com/snapshot/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The name of the job.</para>
        /// <list type="bullet">
        /// <item><description>It cannot exceed 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The information about the output snapshot.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SnapshotOutput")]
        [Validation(Required=false)]
        public string SnapshotOutputShrink { get; set; }

        /// <summary>
        /// <para>The information about the input stream.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public string StreamInputShrink { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
