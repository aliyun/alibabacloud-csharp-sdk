// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListSkillGroupConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSkillGroupConfigResponseBodyData Data { get; set; }
        public class ListSkillGroupConfigResponseBodyData : TeaModel {
            [NameInMap("SkillGroupConfig")]
            [Validation(Required=false)]
            public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfig> SkillGroupConfig { get; set; }
            public class ListSkillGroupConfigResponseBodyDataSkillGroupConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AllContentQualityCheck")]
                [Validation(Required=false)]
                public int? AllContentQualityCheck { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>223</para>
                /// </summary>
                [NameInMap("AllRids")]
                [Validation(Required=false)]
                public string AllRids { get; set; }

                [NameInMap("AllRuleList")]
                [Validation(Required=false)]
                public ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleList AllRuleList { get; set; }
                public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleList : TeaModel {
                    [NameInMap("RuleNameInfo")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleListRuleNameInfo> RuleNameInfo { get; set; }
                    public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleListRuleNameInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>221</para>
                        /// </summary>
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-01T15:12Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>221</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>211</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public long? ModelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QualityCheckType")]
                [Validation(Required=false)]
                public int? QualityCheckType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2221</para>
                /// </summary>
                [NameInMap("Rid")]
                [Validation(Required=false)]
                public string Rid { get; set; }

                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleList RuleList { get; set; }
                public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleList : TeaModel {
                    [NameInMap("RuleNameInfo")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleListRuleNameInfo> RuleNameInfo { get; set; }
                    public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleListRuleNameInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2221</para>
                        /// </summary>
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>x\&quot;x\&quot;x</para>
                        /// </summary>
                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ScreenSwitch")]
                [Validation(Required=false)]
                public bool? ScreenSwitch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SkillGroupFrom")]
                [Validation(Required=false)]
                public int? SkillGroupFrom { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("SkillGroupName")]
                [Validation(Required=false)]
                public string SkillGroupName { get; set; }

                [NameInMap("SkillGroupScreens")]
                [Validation(Required=false)]
                public ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreens SkillGroupScreens { get; set; }
                public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreens : TeaModel {
                    [NameInMap("SkillGroupScreen")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreensSkillGroupScreen> SkillGroupScreen { get; set; }
                    public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreensSkillGroupScreen : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public int? DataType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>customerName</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Symbol")]
                        [Validation(Required=false)]
                        public int? Symbol { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-01T19:28Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>323</para>
                /// </summary>
                [NameInMap("VocabId")]
                [Validation(Required=false)]
                public long? VocabId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("VocabName")]
                [Validation(Required=false)]
                public string VocabName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3CEA0495-341B-4482-9AD9-8191EF4***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
