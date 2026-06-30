// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class SubmitQualityCheckTaskRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID.</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>The complete JSON string. For details, see the following sections.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{&quot;jobName&quot;:&quot;任务 2020-03-19 14:16:55&quot;,&quot;jobType&quot;:0,&quot;jsonStr&quot;:{&quot;dataSetIds&quot;:[123**],&quot;modeCustomizationId&quot;:&quot;046db35352904c5dbb0564****&quot;,&quot;ruleIds&quot;:[185**,185**],&quot;vocabId&quot;:&quot;0f0cd63546c747bcb306bb05***&quot;}}&quot;</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
