// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class GetPolicyDefaultOptionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code, 00000 indicates success; others indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EnableSensitiveInputCheck")]
        [Validation(Required=false)]
        public int? EnableSensitiveInputCheck { get; set; }

        [NameInMap("EnableSensitiveOutputCheck")]
        [Validation(Required=false)]
        public int? EnableSensitiveOutputCheck { get; set; }

        /// <summary>
        /// <para>List of harmful category objects</para>
        /// </summary>
        [NameInMap("HarmfulCategoryInfoList")]
        [Validation(Required=false)]
        public List<GetPolicyDefaultOptionsResponseBodyHarmfulCategoryInfoList> HarmfulCategoryInfoList { get; set; }
        public class GetPolicyDefaultOptionsResponseBodyHarmfulCategoryInfoList : TeaModel {
            /// <summary>
            /// <para>Harmful category ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
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
            /// <para>True</para>
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

        /// <summary>
        /// <para>Return message.</para>
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
        /// <para>Prompt attack detection result object</para>
        /// </summary>
        [NameInMap("PromptAttackInfo")]
        [Validation(Required=false)]
        public GetPolicyDefaultOptionsResponseBodyPromptAttackInfo PromptAttackInfo { get; set; }
        public class GetPolicyDefaultOptionsResponseBodyPromptAttackInfo : TeaModel {
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
        /// <para>Prompt attack list</para>
        /// </summary>
        [NameInMap("PromptAttackInfoList")]
        [Validation(Required=false)]
        public List<GetPolicyDefaultOptionsResponseBodyPromptAttackInfoList> PromptAttackInfoList { get; set; }
        public class GetPolicyDefaultOptionsResponseBodyPromptAttackInfoList : TeaModel {
            /// <summary>
            /// <para>Harmful category ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public int? SecurityLevel { get; set; }

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

        [NameInMap("SensitiveDataTypeList")]
        [Validation(Required=false)]
        public List<GetPolicyDefaultOptionsResponseBodySensitiveDataTypeList> SensitiveDataTypeList { get; set; }
        public class GetPolicyDefaultOptionsResponseBodySensitiveDataTypeList : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("Example")]
            [Validation(Required=false)]
            public string Example { get; set; }

            [NameInMap("ExampleProcessed")]
            [Validation(Required=false)]
            public string ExampleProcessed { get; set; }

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

        /// <summary>
        /// <para>Indicates whether the operation was successful. <c>true</c> means success, <c>false</c> means failure.</para>
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
        public List<GetPolicyDefaultOptionsResponseBodyTopicConfigInfoList> TopicConfigInfoList { get; set; }
        public class GetPolicyDefaultOptionsResponseBodyTopicConfigInfoList : TeaModel {
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
            /// <para>0</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public int? SecurityLevel { get; set; }

            /// <summary>
            /// <para>Sensitive topic ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
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
        public List<GetPolicyDefaultOptionsResponseBodyWordGroupInfoList> WordGroupInfoList { get; set; }
        public class GetPolicyDefaultOptionsResponseBodyWordGroupInfoList : TeaModel {
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
