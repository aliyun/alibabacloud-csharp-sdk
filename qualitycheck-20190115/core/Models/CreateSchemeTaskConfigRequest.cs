// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class CreateSchemeTaskConfigRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Input parameter in JSON format. For details, see Request Parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;manualReview&quot;:0,&quot;name&quot;:&quot;检测任务 2022-09-21 16:59:50&quot;,&quot;asrTaskPriority&quot;:2,&quot;modeCustomizationId&quot;:&quot;englishxxx&quot;,&quot;vocabId&quot;:&quot;xxxx5b98d98f8405xxxxxe5dbb383ca1df&quot;,&quot;dataConfig&quot;:{&quot;assignConfigs&quot;:[{&quot;assignConfigContests&quot;:[{&quot;name&quot;:&quot;fileName&quot;,&quot;symbol&quot;:1,&quot;value&quot;:[&quot;1&quot;],&quot;dataType&quot;:2}]}]},&quot;schemeIdList&quot;:[187],&quot;sourceDataType&quot;:1}</para>
        /// </summary>
        [NameInMap("jsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
