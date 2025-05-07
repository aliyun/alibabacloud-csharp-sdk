// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SaveStyleLearningResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("AigcResult")]
        [Validation(Required=false)]
        public string AigcResult { get; set; }

        [NameInMap("CustomTextIdList")]
        [Validation(Required=false)]
        public List<long?> CustomTextIdList { get; set; }

        [NameInMap("MaterialIdList")]
        [Validation(Required=false)]
        public List<long?> MaterialIdList { get; set; }

        [NameInMap("RewriteResult")]
        [Validation(Required=false)]
        public string RewriteResult { get; set; }

        [NameInMap("StyleName")]
        [Validation(Required=false)]
        public string StyleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
