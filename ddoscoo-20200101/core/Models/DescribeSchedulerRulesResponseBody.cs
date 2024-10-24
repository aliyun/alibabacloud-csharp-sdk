// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSchedulerRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>11C55595-1757-4B17-9ACE-4ACB68C2D989</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SchedulerRules")]
        [Validation(Required=false)]
        public List<DescribeSchedulerRulesResponseBodySchedulerRules> SchedulerRules { get; set; }
        public class DescribeSchedulerRulesResponseBodySchedulerRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4eru5229a843****.aliyunddos0001.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("Param")]
            [Validation(Required=false)]
            public DescribeSchedulerRulesResponseBodySchedulerRulesParam Param { get; set; }
            public class DescribeSchedulerRulesResponseBodySchedulerRulesParam : TeaModel {
                [NameInMap("ParamData")]
                [Validation(Required=false)]
                public DescribeSchedulerRulesResponseBodySchedulerRulesParamParamData ParamData { get; set; }
                public class DescribeSchedulerRulesResponseBodySchedulerRulesParamParamData : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ga-bp1htlajy5509rc99****</para>
                    /// </summary>
                    [NameInMap("CloudInstanceId")]
                    [Validation(Required=false)]
                    public string CloudInstanceId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GA</para>
                /// </summary>
                [NameInMap("ParamType")]
                [Validation(Required=false)]
                public string ParamType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>doctest</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeSchedulerRulesResponseBodySchedulerRulesRules> Rules { get; set; }
            public class DescribeSchedulerRulesResponseBodySchedulerRulesRules : TeaModel {
                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("RestoreDelay")]
                [Validation(Required=false)]
                public int? RestoreDelay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>203.<em><b>.</b></em>.39</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public int? ValueType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
