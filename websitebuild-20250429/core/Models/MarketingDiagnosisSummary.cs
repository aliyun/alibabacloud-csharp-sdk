// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class MarketingDiagnosisSummary : TeaModel {
        /// <summary>
        /// <para>The brand mention rate, as a percentage from 0 to 100, where 25 indicates 25%. This field is empty when the value is missing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.42</para>
        /// </summary>
        [NameInMap("BrandMentionRate")]
        [Validation(Required=false)]
        public double? BrandMentionRate { get; set; }

        /// <summary>
        /// <para>The brand name used for analysis or diagnosis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example Technology</para>
        /// </summary>
        [NameInMap("BrandName")]
        [Validation(Required=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// <para>The diagnosis completion time, as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1795658460000</para>
        /// </summary>
        [NameInMap("CompletedAt")]
        [Validation(Required=false)]
        public long? CompletedAt { get; set; }

        /// <summary>
        /// <para>The ID of the diagnosis record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>diagnosis_example001</para>
        /// </summary>
        [NameInMap("DiagnosisId")]
        [Validation(Required=false)]
        public string DiagnosisId { get; set; }

        /// <summary>
        /// <para>The web address of the diagnosis target.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/">https://example.com/</a></para>
        /// </summary>
        [NameInMap("TargetUrl")]
        [Validation(Required=false)]
        public string TargetUrl { get; set; }

        /// <summary>
        /// <para>The task ID used to query the processing progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bwb_example001</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
