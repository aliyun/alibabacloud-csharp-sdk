// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitSmartClipTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Video editing configuration.</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfigShrink { get; set; }

        /// <summary>
        /// <para>Additional extended parameters. These parameters merge with InputConfig, OutputConfig, and EditingConfig.</para>
        /// </summary>
        [NameInMap("ExtendParam")]
        [Validation(Required=false)]
        public string ExtendParam { get; set; }

        /// <summary>
        /// <para>Input configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfigShrink { get; set; }

        /// <summary>
        /// <para>Output configuration.</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfigShrink { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud Model Studio workspace ID. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>业务空间ID</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
