// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeInstanceReportAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the report is the latest report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Latest")]
        [Validation(Required=false)]
        public bool? Latest { get; set; }

        /// <summary>
        /// <para>The detailed description of the inspection report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No critical risks were found in this inspection</para>
        /// </summary>
        [NameInMap("ReportDescription")]
        [Validation(Required=false)]
        public string ReportDescription { get; set; }

        /// <summary>
        /// <para>The ID of the instance inspection report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>report-001</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The overall score of the inspection report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("ReportScore")]
        [Validation(Required=false)]
        public long? ReportScore { get; set; }

        /// <summary>
        /// <para>The generation status of the inspection report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Completed</para>
        /// </summary>
        [NameInMap("ReportStatus")]
        [Validation(Required=false)]
        public string ReportStatus { get; set; }

        /// <summary>
        /// <para>The inspection results for each item in the report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ReportSubItems")]
        [Validation(Required=false)]
        public List<DescribeInstanceReportAttributeResponseBodyReportSubItems> ReportSubItems { get; set; }
        public class DescribeInstanceReportAttributeResponseBodyReportSubItems : TeaModel {
            /// <summary>
            /// <para>The risk level of the inspection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The score of the inspection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public long? Score { get; set; }

            /// <summary>
            /// <para>The name of the inspection skill that generated the inspection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>performance</para>
            /// </summary>
            [NameInMap("SkillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The result summary of the inspection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No anomalies found</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

        }

        /// <summary>
        /// <para>The overall summary of the inspection report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The instance is running normally</para>
        /// </summary>
        [NameInMap("ReportSummary")]
        [Validation(Required=false)]
        public string ReportSummary { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the inspection task that generated the report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-001</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
