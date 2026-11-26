// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetSkillGroupConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success.</para>
        /// <remarks>
        /// <para>Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of skill group rule configuration details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSkillGroupConfigResponseBodyData Data { get; set; }
        public class GetSkillGroupConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Specifies whether to perform full-text quality check after the real-time quality check ends. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Perform full-text quality check.</description></item>
            /// <item><description>0: Do not perform full-text quality check.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllContentQualityCheck")]
            [Validation(Required=false)]
            public int? AllContentQualityCheck { get; set; }

            /// <summary>
            /// <para>The quality check rule IDs for full-text quality check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>223</para>
            /// </summary>
            [NameInMap("AllRids")]
            [Validation(Required=false)]
            public string AllRids { get; set; }

            [NameInMap("AllRuleList")]
            [Validation(Required=false)]
            public GetSkillGroupConfigResponseBodyDataAllRuleList AllRuleList { get; set; }
            public class GetSkillGroupConfigResponseBodyDataAllRuleList : TeaModel {
                [NameInMap("RuleNameInfo")]
                [Validation(Required=false)]
                public List<GetSkillGroupConfigResponseBodyDataAllRuleListRuleNameInfo> RuleNameInfo { get; set; }
                public class GetSkillGroupConfigResponseBodyDataAllRuleListRuleNameInfo : TeaModel {
                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public long? Rid { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-01T15:12Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1212</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>An internal field. Ignore this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deprecated field</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The language model ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1321</para>
            /// </summary>
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public long? ModelId { get; set; }

            /// <summary>
            /// <para>The language model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>General model</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The configuration name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>General configuration</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The quality check type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Offline quality check.</description></item>
            /// <item><description>1: Real-time quality check.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("QualityCheckType")]
            [Validation(Required=false)]
            public int? QualityCheckType { get; set; }

            /// <summary>
            /// <para>The quality check rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2332</para>
            /// </summary>
            [NameInMap("Rid")]
            [Validation(Required=false)]
            public string Rid { get; set; }

            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public GetSkillGroupConfigResponseBodyDataRuleList RuleList { get; set; }
            public class GetSkillGroupConfigResponseBodyDataRuleList : TeaModel {
                [NameInMap("RuleNameInfo")]
                [Validation(Required=false)]
                public List<GetSkillGroupConfigResponseBodyDataRuleListRuleNameInfo> RuleNameInfo { get; set; }
                public class GetSkillGroupConfigResponseBodyDataRuleListRuleNameInfo : TeaModel {
                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public long? Rid { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

            }

            /// <summary>
            /// <para>The source of the skill group. The value is fixed to 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SkillGroupFrom")]
            [Validation(Required=false)]
            public int? SkillGroupFrom { get; set; }

            /// <summary>
            /// <para>The skill group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public string SkillGroupId { get; set; }

            /// <summary>
            /// <para>The skill group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>General skill group</para>
            /// </summary>
            [NameInMap("SkillGroupName")]
            [Validation(Required=false)]
            public string SkillGroupName { get; set; }

            /// <summary>
            /// <para>The enabling status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Custom configuration.</description></item>
            /// <item><description>0: Built-in system configuration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-01T19:28Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The hot word ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("VocabId")]
            [Validation(Required=false)]
            public long? VocabId { get; set; }

            /// <summary>
            /// <para>The hot word name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VocabName")]
            [Validation(Required=false)]
            public string VocabName { get; set; }

        }

        /// <summary>
        /// <para>The error details when an error occurs, or <b>successful</b> when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3CEA0495-341B-4482-9AD9-8191EF4***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// <para>You can use this field to determine whether the request is successful:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false/null</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
