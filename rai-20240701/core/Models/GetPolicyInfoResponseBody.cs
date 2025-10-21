// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class GetPolicyInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code, 00000 indicates success; others indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContentSafeModelInfo")]
        [Validation(Required=false)]
        public GetPolicyInfoResponseBodyContentSafeModelInfo ContentSafeModelInfo { get; set; }
        public class GetPolicyInfoResponseBodyContentSafeModelInfo : TeaModel {
            [NameInMap("EasServiceName")]
            [Validation(Required=false)]
            public string EasServiceName { get; set; }

            [NameInMap("ModelInstanceId")]
            [Validation(Required=false)]
            public long? ModelInstanceId { get; set; }

        }

        [NameInMap("EnableSensitiveInputCheck")]
        [Validation(Required=false)]
        public int? EnableSensitiveInputCheck { get; set; }

        [NameInMap("EnableSensitiveOutputCheck")]
        [Validation(Required=false)]
        public int? EnableSensitiveOutputCheck { get; set; }

        /// <summary>
        /// <para>Policy modification time</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634122349000</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>Harmful category configuration list</para>
        /// </summary>
        [NameInMap("HarmfulCategoryConfigInfoList")]
        [Validation(Required=false)]
        public List<GetPolicyInfoResponseBodyHarmfulCategoryConfigInfoList> HarmfulCategoryConfigInfoList { get; set; }
        public class GetPolicyInfoResponseBodyHarmfulCategoryConfigInfoList : TeaModel {
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
            /// <para>Harmful category configuration switch
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

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("InputSafeAnswer")]
        [Validation(Required=false)]
        public string InputSafeAnswer { get; set; }

        [NameInMap("InputSafeAnswerSwitch")]
        [Validation(Required=false)]
        public int? InputSafeAnswerSwitch { get; set; }

        [NameInMap("IsSidecarPolicy")]
        [Validation(Required=false)]
        public int? IsSidecarPolicy { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("OutputSafeAnswer")]
        [Validation(Required=false)]
        public string OutputSafeAnswer { get; set; }

        [NameInMap("OutputSafeAnswerSwitch")]
        [Validation(Required=false)]
        public int? OutputSafeAnswerSwitch { get; set; }

        /// <summary>
        /// <para>Policy identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>x1bc5xgs4uhx</para>
        /// </summary>
        [NameInMap("PolicyIdentifier")]
        [Validation(Required=false)]
        public string PolicyIdentifier { get; set; }

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
        public GetPolicyInfoResponseBodyPromptAttackInfo PromptAttackInfo { get; set; }
        public class GetPolicyInfoResponseBodyPromptAttackInfo : TeaModel {
            /// <summary>
            /// <para>Prompt attack configuration switch
            /// 0: Off
            /// 1: On</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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

        /// <summary>
        /// <para>Prompt attack list</para>
        /// </summary>
        [NameInMap("PromptAttackInfoList")]
        [Validation(Required=false)]
        public List<GetPolicyInfoResponseBodyPromptAttackInfoList> PromptAttackInfoList { get; set; }
        public class GetPolicyInfoResponseBodyPromptAttackInfoList : TeaModel {
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
            /// <para>Harmful category configuration switch
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

        [NameInMap("PromptAttackModelInfo")]
        [Validation(Required=false)]
        public GetPolicyInfoResponseBodyPromptAttackModelInfo PromptAttackModelInfo { get; set; }
        public class GetPolicyInfoResponseBodyPromptAttackModelInfo : TeaModel {
            [NameInMap("EasServiceName")]
            [Validation(Required=false)]
            public string EasServiceName { get; set; }

            [NameInMap("ModelInstanceId")]
            [Validation(Required=false)]
            public long? ModelInstanceId { get; set; }

        }

        [NameInMap("RegularExpressList")]
        [Validation(Required=false)]
        public List<GetPolicyInfoResponseBodyRegularExpressList> RegularExpressList { get; set; }
        public class GetPolicyInfoResponseBodyRegularExpressList : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            [NameInMap("InputOutputType")]
            [Validation(Required=false)]
            public int? InputOutputType { get; set; }

            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public int? IsEnabled { get; set; }

            [NameInMap("MatchAndReplace")]
            [Validation(Required=false)]
            public string MatchAndReplace { get; set; }

            [NameInMap("RegularExpress")]
            [Validation(Required=false)]
            public string RegularExpress { get; set; }

            [NameInMap("RegularExpressId")]
            [Validation(Required=false)]
            public long? RegularExpressId { get; set; }

            [NameInMap("RegularExpressName")]
            [Validation(Required=false)]
            public string RegularExpressName { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public int? SceneType { get; set; }

        [NameInMap("SensitiveConfigList")]
        [Validation(Required=false)]
        public List<GetPolicyInfoResponseBodySensitiveConfigList> SensitiveConfigList { get; set; }
        public class GetPolicyInfoResponseBodySensitiveConfigList : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            [NameInMap("InputOutputType")]
            [Validation(Required=false)]
            public int? InputOutputType { get; set; }

            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public int? IsEnabled { get; set; }

            [NameInMap("MatchAndReplace")]
            [Validation(Required=false)]
            public string MatchAndReplace { get; set; }

            [NameInMap("SensitiveConfigId")]
            [Validation(Required=false)]
            public long? SensitiveConfigId { get; set; }

            [NameInMap("SensitiveName")]
            [Validation(Required=false)]
            public string SensitiveName { get; set; }

        }

        [NameInMap("SensitiveTopicList")]
        [Validation(Required=false)]
        public List<GetPolicyInfoResponseBodySensitiveTopicList> SensitiveTopicList { get; set; }
        public class GetPolicyInfoResponseBodySensitiveTopicList : TeaModel {
            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public int? CategoryType { get; set; }

            [NameInMap("InputOutputType")]
            [Validation(Required=false)]
            public int? InputOutputType { get; set; }

            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public int? SecurityLevel { get; set; }

            [NameInMap("TopicDefinition")]
            [Validation(Required=false)]
            public string TopicDefinition { get; set; }

            [NameInMap("TopicExampleInfoList")]
            [Validation(Required=false)]
            public List<GetPolicyInfoResponseBodySensitiveTopicListTopicExampleInfoList> TopicExampleInfoList { get; set; }
            public class GetPolicyInfoResponseBodySensitiveTopicListTopicExampleInfoList : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("ExampleType")]
                [Validation(Required=false)]
                public long? ExampleType { get; set; }

            }

            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public long? TopicId { get; set; }

            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

        [NameInMap("SensitiveTopicModelInfo")]
        [Validation(Required=false)]
        public GetPolicyInfoResponseBodySensitiveTopicModelInfo SensitiveTopicModelInfo { get; set; }
        public class GetPolicyInfoResponseBodySensitiveTopicModelInfo : TeaModel {
            [NameInMap("EasServiceName")]
            [Validation(Required=false)]
            public string EasServiceName { get; set; }

            [NameInMap("ModelInstanceId")]
            [Validation(Required=false)]
            public long? ModelInstanceId { get; set; }

        }

        [NameInMap("SensitiveWordList")]
        [Validation(Required=false)]
        public List<GetPolicyInfoResponseBodySensitiveWordList> SensitiveWordList { get; set; }
        public class GetPolicyInfoResponseBodySensitiveWordList : TeaModel {
            [NameInMap("InputOutputType")]
            [Validation(Required=false)]
            public int? InputOutputType { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("Word")]
            [Validation(Required=false)]
            public string Word { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the operation was successful. <c>true</c> for success, <c>false</c> for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Sensitive topic list</para>
        /// </summary>
        [NameInMap("TopicConfigInfoList")]
        [Validation(Required=false)]
        public List<GetPolicyInfoResponseBodyTopicConfigInfoList> TopicConfigInfoList { get; set; }
        public class GetPolicyInfoResponseBodyTopicConfigInfoList : TeaModel {
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
        /// <para>Keyword group object list</para>
        /// </summary>
        [NameInMap("WordGroupInfoList")]
        [Validation(Required=false)]
        public List<GetPolicyInfoResponseBodyWordGroupInfoList> WordGroupInfoList { get; set; }
        public class GetPolicyInfoResponseBodyWordGroupInfoList : TeaModel {
            /// <summary>
            /// <para>Keyword group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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

    }

}
