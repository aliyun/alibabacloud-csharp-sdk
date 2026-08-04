// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CreateAlgorithmRequest : TeaModel {
        /// <summary>
        /// <para>The description of the algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tongyi Qwen large language model training algorithm.</para>
        /// </summary>
        [NameInMap("AlgorithmDescription")]
        [Validation(Required=false)]
        public string AlgorithmDescription { get; set; }

        /// <summary>
        /// <para>The name of the algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm_training</para>
        /// </summary>
        [NameInMap("AlgorithmName")]
        [Validation(Required=false)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// <para>The display name of the algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Large language model training</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
