// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ContextualRetrievalShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The conversation or tool invocation history. The latest message is at the end of the list (with an index number of n-1), whereas the earliest message is at the beginning of the list (with an index number of 0). Historical messages must be provided in user-assistant pairs. The maximum number of messages that you can specify is 2\*n+1. The current question cannot exceed 1,000 characters in length. The maximum number of historical messages allowed is 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public string MessagesShrink { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information, see <a href="https://help.aliyun.com/zh/imm/getting-started/create-a-project-1?spm=a2c4g.11186623.help-menu-search-62354.d_0">CreateProject</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable recall-only (embedding-based search). If you set this parameter to true, returned results have not been re-ranked and can be ranked in custom order. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RecallOnly")]
        [Validation(Required=false)]
        public bool? RecallOnly { get; set; }

        /// <summary>
        /// <para>The IDs of clusters from which results are retrieved.</para>
        /// </summary>
        [NameInMap("SmartClusterIds")]
        [Validation(Required=false)]
        public string SmartClusterIdsShrink { get; set; }

    }

}
