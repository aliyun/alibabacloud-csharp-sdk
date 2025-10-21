// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class UpdatePolicyRequest : TeaModel {
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
        public List<UpdatePolicyRequestHarmfulCategoryConfigInfoList> HarmfulCategoryConfigInfoList { get; set; }
        public class UpdatePolicyRequestHarmfulCategoryConfigInfoList : TeaModel {
            /// <summary>
            /// <para>Harmful category configuration ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CategoryConfigId")]
            [Validation(Required=false)]
            public long? CategoryConfigId { get; set; }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <para>Category name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Morality</para>
            /// </summary>
            [NameInMap("CategoryLabel")]
            [Validation(Required=false)]
            public string CategoryLabel { get; set; }

            /// <summary>
            /// <para>0: Text
            /// 1: Image</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public int? CategoryType { get; set; }

            /// <summary>
            /// <para>Model input/output type
            /// 0: Input
            /// 1: Output</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InputOutputType")]
            [Validation(Required=false)]
            public int? InputOutputType { get; set; }

            /// <summary>
            /// <para>Prompt attack configuration switch
            /// 0: Off
            /// 1: On</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public int? IsEnabled { get; set; }

            /// <summary>
            /// <para>Security level
            /// 0: Low
            /// 1: Medium
            /// 2: High</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public int? SecurityLevel { get; set; }

        }

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
        public UpdatePolicyRequestPromptAttackInfo PromptAttackInfo { get; set; }
        public class UpdatePolicyRequestPromptAttackInfo : TeaModel {
            /// <summary>
            /// <para>Prompt attack configuration switch
            /// 0: Off
            /// 1: On</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public int? IsEnabled { get; set; }

            /// <summary>
            /// <para>Security level
            /// 0: Low
            /// 1: Medium
            /// 2: High</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public int? SecurityLevel { get; set; }

        }

        /// <summary>
        /// <para>List of prompt attacks</para>
        /// </summary>
        [NameInMap("PromptAttackInfoList")]
        [Validation(Required=false)]
        public List<UpdatePolicyRequestPromptAttackInfoList> PromptAttackInfoList { get; set; }
        public class UpdatePolicyRequestPromptAttackInfoList : TeaModel {
            /// <summary>
            /// <para>Harmful category configuration ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CategoryConfigId")]
            [Validation(Required=false)]
            public long? CategoryConfigId { get; set; }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <para>Category name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Role Play</para>
            /// </summary>
            [NameInMap("CategoryLabel")]
            [Validation(Required=false)]
            public string CategoryLabel { get; set; }

            /// <summary>
            /// <para>Prompt attack configuration switch
            /// 0: Off
            /// 1: On</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public int? IsEnabled { get; set; }

            /// <summary>
            /// <para>Security level
            /// 0: Low
            /// 1: Medium
            /// 2: High</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public int? SecurityLevel { get; set; }

        }

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
        public List<UpdatePolicyRequestRegularExpressList> RegularExpressList { get; set; }
        public class UpdatePolicyRequestRegularExpressList : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            [NameInMap("RegularExpress")]
            [Validation(Required=false)]
            public string RegularExpress { get; set; }

            [NameInMap("RegularExpressName")]
            [Validation(Required=false)]
            public string RegularExpressName { get; set; }

        }

        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public int? SceneType { get; set; }

        [NameInMap("SensitiveConfigList")]
        [Validation(Required=false)]
        public List<UpdatePolicyRequestSensitiveConfigList> SensitiveConfigList { get; set; }
        public class UpdatePolicyRequestSensitiveConfigList : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public int? IsEnabled { get; set; }

            [NameInMap("SensitiveConfigId")]
            [Validation(Required=false)]
            public long? SensitiveConfigId { get; set; }

        }

        [NameInMap("SensitiveTopicList")]
        [Validation(Required=false)]
        public List<UpdatePolicyRequestSensitiveTopicList> SensitiveTopicList { get; set; }
        public class UpdatePolicyRequestSensitiveTopicList : TeaModel {
            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public int? CategoryType { get; set; }

            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public int? SecurityLevel { get; set; }

            [NameInMap("TopicDefinition")]
            [Validation(Required=false)]
            public string TopicDefinition { get; set; }

            [NameInMap("TopicExampleInfoList")]
            [Validation(Required=false)]
            public List<UpdatePolicyRequestSensitiveTopicListTopicExampleInfoList> TopicExampleInfoList { get; set; }
            public class UpdatePolicyRequestSensitiveTopicListTopicExampleInfoList : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("ExampleType")]
                [Validation(Required=false)]
                public int? ExampleType { get; set; }

            }

            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

        [NameInMap("SensitiveTopicModelInstanceId")]
        [Validation(Required=false)]
        public long? SensitiveTopicModelInstanceId { get; set; }

        [NameInMap("SensitiveWordList")]
        [Validation(Required=false)]
        public List<UpdatePolicyRequestSensitiveWordList> SensitiveWordList { get; set; }
        public class UpdatePolicyRequestSensitiveWordList : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("Word")]
            [Validation(Required=false)]
            public string Word { get; set; }

        }

        /// <summary>
        /// <para>List of sensitive topics</para>
        /// </summary>
        [NameInMap("TopicConfigInfoList")]
        [Validation(Required=false)]
        public List<UpdatePolicyRequestTopicConfigInfoList> TopicConfigInfoList { get; set; }
        public class UpdatePolicyRequestTopicConfigInfoList : TeaModel {
            /// <summary>
            /// <para>0: Text
            /// 1: Image</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public int? CategoryType { get; set; }

            /// <summary>
            /// <para>Model input/output type
            /// 0: Input
            /// 1: Output</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InputOutputType")]
            [Validation(Required=false)]
            public int? InputOutputType { get; set; }

            /// <summary>
            /// <para>Security level
            /// 0: Low
            /// 1: Medium
            /// 2: High</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public int? SecurityLevel { get; set; }

            /// <summary>
            /// <para>Sensitive topic ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public long? TopicId { get; set; }

            /// <summary>
            /// <para>Topic name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Buss.</para>
            /// </summary>
            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

        /// <summary>
        /// <para>List of keyword group objects</para>
        /// </summary>
        [NameInMap("WordGroupInfoList")]
        [Validation(Required=false)]
        public List<UpdatePolicyRequestWordGroupInfoList> WordGroupInfoList { get; set; }
        public class UpdatePolicyRequestWordGroupInfoList : TeaModel {
            /// <summary>
            /// <para>Keyword group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5fa285a60a9342e097cb7a3491ec00cc</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>Keyword group name</para>
            /// 
            /// <b>Example:</b>
            /// <para>testGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Model input/output type
            /// 0: Input
            /// 1: Output</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InputOutputType")]
            [Validation(Required=false)]
            public int? InputOutputType { get; set; }

        }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
