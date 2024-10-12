// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunStyleFeatureAnalysisRequest : TeaModel {
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<string> Contents { get; set; }

        [NameInMap("MaterialIds")]
        [Validation(Required=false)]
        public List<long?> MaterialIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2setzb9x4ewsd</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
