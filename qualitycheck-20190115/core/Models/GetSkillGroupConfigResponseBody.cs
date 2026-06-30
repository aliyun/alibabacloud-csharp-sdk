// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetSkillGroupConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of <b>200</b> indicates a successful response.</para>
        /// <remarks>
        /// <para>Other values indicate a failed response. You can use this field to identify the cause of the failure.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the skill group rule configuration.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSkillGroupConfigResponseBodyData Data { get; set; }
        public class GetSkillGroupConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether to perform a full-text quality check after the real-time quality check is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: yes</para>
            /// </description></item>
            /// <item><description><para>0: no</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllContentQualityCheck")]
            [Validation(Required=false)]
            public int? AllContentQualityCheck { get; set; }

            /// <summary>
            /// <para>The ID of the rule used for the full-text quality check.</para>
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
            /// <para>The time when the configuration was created.</para>
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
            /// <para>This is an internal parameter. You can ignore it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
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
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The configuration name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The quality check type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: offline</para>
            /// </description></item>
            /// <item><description><para>1: real-time</para>
            /// </description></item>
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
            /// <para>The source of the skill group. The value is fixed at 0.</para>
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
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("SkillGroupName")]
            [Validation(Required=false)]
            public string SkillGroupName { get; set; }

            /// <summary>
            /// <para>The status of the configuration. Valid values: 0 (disabled) and 1 (enabled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The configuration type. Valid values: 1 (custom configuration) and 0 (built-in configuration).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The time when the configuration was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-01T19:28Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The hotword ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("VocabId")]
            [Validation(Required=false)]
            public long? VocabId { get; set; }

            /// <summary>
            /// <para>The hotword name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VocabName")]
            [Validation(Required=false)]
            public string VocabName { get; set; }

        }

        /// <summary>
        /// <para>The response message. If the request is successful, a value of <b>successful</b> is returned. If the request fails, an error message is returned.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// <para>The caller can use this field to determine whether the request was successful:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false or <b>null</b>: The request failed.</para>
        /// </description></item>
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
