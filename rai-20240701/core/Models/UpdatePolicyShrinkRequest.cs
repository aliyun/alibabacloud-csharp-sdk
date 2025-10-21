// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class UpdatePolicyShrinkRequest : TeaModel {
        [NameInMap("ContentSafeModelInstanceId")]
        [Validation(Required=false)]
        public long? ContentSafeModelInstanceId { get; set; }

        [NameInMap("EnableSensitiveInputCheck")]
        [Validation(Required=false)]
        public int? EnableSensitiveInputCheck { get; set; }

        [NameInMap("EnableSensitiveOutputCheck")]
        [Validation(Required=false)]
        public int? EnableSensitiveOutputCheck { get; set; }

        /// <summary>
        /// <para>List of harmful category configurations</para>
        /// </summary>
        [NameInMap("HarmfulCategoryConfigInfoList")]
        [Validation(Required=false)]
        public string HarmfulCategoryConfigInfoListShrink { get; set; }

        [NameInMap("InputSafeAnswer")]
        [Validation(Required=false)]
        public string InputSafeAnswer { get; set; }

        [NameInMap("InputSafeAnswerSwitch")]
        [Validation(Required=false)]
        public int? InputSafeAnswerSwitch { get; set; }

        [NameInMap("IsSidecarPolicy")]
        [Validation(Required=false)]
        public int? IsSidecarPolicy { get; set; }

        [NameInMap("OutputSafeAnswer")]
        [Validation(Required=false)]
        public string OutputSafeAnswer { get; set; }

        [NameInMap("OutputSafeAnswerSwitch")]
        [Validation(Required=false)]
        public int? OutputSafeAnswerSwitch { get; set; }

        /// <summary>
        /// <para>Detection policy ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>Detection policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPolicy</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>Prompt attack detection result object</para>
        /// </summary>
        [NameInMap("PromptAttackInfo")]
        [Validation(Required=false)]
        public string PromptAttackInfoShrink { get; set; }

        /// <summary>
        /// <para>List of prompt attacks</para>
        /// </summary>
        [NameInMap("PromptAttackInfoList")]
        [Validation(Required=false)]
        public string PromptAttackInfoListShrink { get; set; }

        [NameInMap("PromptAttackModelInstanceId")]
        [Validation(Required=false)]
        public long? PromptAttackModelInstanceId { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RegularExpressList")]
        [Validation(Required=false)]
        public string RegularExpressListShrink { get; set; }

        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public int? SceneType { get; set; }

        [NameInMap("SensitiveConfigList")]
        [Validation(Required=false)]
        public string SensitiveConfigListShrink { get; set; }

        [NameInMap("SensitiveTopicList")]
        [Validation(Required=false)]
        public string SensitiveTopicListShrink { get; set; }

        [NameInMap("SensitiveTopicModelInstanceId")]
        [Validation(Required=false)]
        public long? SensitiveTopicModelInstanceId { get; set; }

        [NameInMap("SensitiveWordList")]
        [Validation(Required=false)]
        public string SensitiveWordListShrink { get; set; }

        /// <summary>
        /// <para>List of sensitive topics</para>
        /// </summary>
        [NameInMap("TopicConfigInfoList")]
        [Validation(Required=false)]
        public string TopicConfigInfoListShrink { get; set; }

        /// <summary>
        /// <para>List of keyword group objects</para>
        /// </summary>
        [NameInMap("WordGroupInfoList")]
        [Validation(Required=false)]
        public string WordGroupInfoListShrink { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
