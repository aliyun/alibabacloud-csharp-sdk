// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class UpdateJobPlanRequest : TeaModel {
        /// <summary>
        /// <para>The current step of the task plan. Set this parameter to <c>DatasetSynthesisAndModelTrain</c> for the full process or <c>DatasetSynthesisModelTrain</c> for step-by-step execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DatasetSynthesisAndModelTrain</para>
        /// </summary>
        [NameInMap("JobPlanCurrentStep")]
        [Validation(Required=false)]
        public string JobPlanCurrentStep { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateJobPlanRequestTag> Tag { get; set; }
        public class UpdateJobPlanRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. If the tag key already exists, the tag is updated. Otherwise, a new tag is added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>foo</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag key. If the tag key already exists, the tag is updated. Otherwise, a new tag is added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bar</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
