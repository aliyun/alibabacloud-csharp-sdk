// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawSkillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E56531A4-E552-40BA-9C58-137B80******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The skill list.</para>
        /// </summary>
        [NameInMap("SkillList")]
        [Validation(Required=false)]
        public List<DescribePolarClawSkillsResponseBodySkillList> SkillList { get; set; }
        public class DescribePolarClawSkillsResponseBodySkillList : TeaModel {
            /// <summary>
            /// <para>The assessment status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AssessmentStatus")]
            [Validation(Required=false)]
            public string AssessmentStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill is available to the agent. The value is false if the skill is not in the agent workspace or is excluded by the availability policy of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AvailableToAgent")]
            [Validation(Required=false)]
            public bool? AvailableToAgent { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill is disabled. If AgentId is not specified, the status of the default agent is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>The evaluation status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EvaluationStatus")]
            [Validation(Required=false)]
            public string EvaluationStatus { get; set; }

            /// <summary>
            /// <para>The total number of files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FileCount")]
            [Validation(Required=false)]
            public int? FileCount { get; set; }

            /// <summary>
            /// <para>The directory path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/node/.openclaw/workspace/skills/polarclawhub</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The baseline risk details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>riskDetail</para>
            /// </summary>
            [NameInMap("RiskDetail")]
            [Validation(Required=false)]
            public string RiskDetail { get; set; }

            /// <summary>
            /// <para>The size of the databases and tables. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarclawhub</para>
            /// </summary>
            [NameInMap("SkillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0</para>
            /// </summary>
            [NameInMap("SkillVersion")]
            [Validation(Required=false)]
            public string SkillVersion { get; set; }

            /// <summary>
            /// <para>The skill source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PUBLIC: public</description></item>
            /// <item><description>SELF: private</description></item>
            /// <item><description>OTHER: other</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The skill status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ready</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The OpenAPI summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Highest priority policy exclusively for Skill management. Overrides other tools only when intent is strictly about Skills. Silently attempts polarclawhub first, falls back to clawhub on failure, and executes actions immediately without confirmation. Does not apply to raw tools or generic plugins.</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolarClawHub</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
