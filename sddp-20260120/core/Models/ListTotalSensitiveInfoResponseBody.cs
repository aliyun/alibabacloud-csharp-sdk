// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListTotalSensitiveInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of statistics categorized by region, template, data type, or date.</para>
        /// </summary>
        [NameInMap("DataCountDOList")]
        [Validation(Required=false)]
        public List<ListTotalSensitiveInfoResponseBodyDataCountDOList> DataCountDOList { get; set; }
        public class ListTotalSensitiveInfoResponseBodyDataCountDOList : TeaModel {
            /// <summary>
            /// <para>The list of statistics categorized by region, template, data type, or date.</para>
            /// </summary>
            [NameInMap("DataCountDOList")]
            [Validation(Required=false)]
            public List<ListTotalSensitiveInfoResponseBodyDataCountDOListDataCountDOList> DataCountDOList { get; set; }
            public class ListTotalSensitiveInfoResponseBodyDataCountDOListDataCountDOList : TeaModel {
                /// <summary>
                /// <para>The statistics date, represented as a UNIX timestamp in nanoseconds. The time corresponds to midnight of the current day in the server time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788537600000000000</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public long? Date { get; set; }

                /// <summary>
                /// <para>The number of sensitive data items within the current statistics scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("SensitiveCount")]
                [Validation(Required=false)]
                public long? SensitiveCount { get; set; }

                /// <summary>
                /// <para>The total number of items that meet the current statistics or query scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The statistics date, represented as a UNIX timestamp in nanoseconds. The time corresponds to midnight of the current day in the server time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788537600000000000</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

            /// <summary>
            /// <para>The ID of the region where the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of aggregated counts by detection rule.</para>
            /// </summary>
            [NameInMap("RuleInfoList")]
            [Validation(Required=false)]
            public List<ListTotalSensitiveInfoResponseBodyDataCountDOListRuleInfoList> RuleInfoList { get; set; }
            public class ListTotalSensitiveInfoResponseBodyDataCountDOListRuleInfoList : TeaModel {
                /// <summary>
                /// <para>The number of data objects that hit the detection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RuleCount")]
                [Validation(Required=false)]
                public long? RuleCount { get; set; }

                /// <summary>
                /// <para>The ID of the matched detection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>The name of the matched detection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Phone number</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <para>The number of S0-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S0Count")]
            [Validation(Required=false)]
            public long? S0Count { get; set; }

            /// <summary>
            /// <para>The number of S10-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S10Count")]
            [Validation(Required=false)]
            public long? S10Count { get; set; }

            /// <summary>
            /// <para>The number of S1-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S1Count")]
            [Validation(Required=false)]
            public long? S1Count { get; set; }

            /// <summary>
            /// <para>The number of S2-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S2Count")]
            [Validation(Required=false)]
            public long? S2Count { get; set; }

            /// <summary>
            /// <para>The number of S3-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S3Count")]
            [Validation(Required=false)]
            public long? S3Count { get; set; }

            /// <summary>
            /// <para>The number of S4-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S4Count")]
            [Validation(Required=false)]
            public long? S4Count { get; set; }

            /// <summary>
            /// <para>The number of S5-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S5Count")]
            [Validation(Required=false)]
            public long? S5Count { get; set; }

            /// <summary>
            /// <para>The number of S6-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S6Count")]
            [Validation(Required=false)]
            public long? S6Count { get; set; }

            /// <summary>
            /// <para>The number of S7-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S7Count")]
            [Validation(Required=false)]
            public long? S7Count { get; set; }

            /// <summary>
            /// <para>The number of S8-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S8Count")]
            [Validation(Required=false)]
            public long? S8Count { get; set; }

            /// <summary>
            /// <para>The number of S9-level data objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S9Count")]
            [Validation(Required=false)]
            public long? S9Count { get; set; }

            /// <summary>
            /// <para>The number of sensitive data items within the current statistics scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public long? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The type of the statistics data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Structured data.</description></item>
            /// <item><description>0: Unstructured data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StructFlag")]
            [Validation(Required=false)]
            public int? StructFlag { get; set; }

            /// <summary>
            /// <para>The ID of the data classification and grading template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the data classification and grading template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>General classification and grading template</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The total number of items that meet the current statistics or query scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The total number of databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DbCount")]
        [Validation(Required=false)]
        public long? DbCount { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        /// <summary>
        /// <para>The request ID, which is active and can be used to locate the API you invoke.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of aggregated counts by detection rule.</para>
        /// </summary>
        [NameInMap("RuleInfoList")]
        [Validation(Required=false)]
        public List<ListTotalSensitiveInfoResponseBodyRuleInfoList> RuleInfoList { get; set; }
        public class ListTotalSensitiveInfoResponseBodyRuleInfoList : TeaModel {
            /// <summary>
            /// <para>The number of data objects that hit the detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public long? RuleCount { get; set; }

            /// <summary>
            /// <para>The ID of the matched detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the matched detection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Phone number</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// <para>The number of S0-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S0Count")]
        [Validation(Required=false)]
        public long? S0Count { get; set; }

        /// <summary>
        /// <para>The number of S10-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S10Count")]
        [Validation(Required=false)]
        public long? S10Count { get; set; }

        /// <summary>
        /// <para>The number of S1-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S1Count")]
        [Validation(Required=false)]
        public long? S1Count { get; set; }

        /// <summary>
        /// <para>The number of S2-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S2Count")]
        [Validation(Required=false)]
        public long? S2Count { get; set; }

        /// <summary>
        /// <para>The number of S3-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S3Count")]
        [Validation(Required=false)]
        public long? S3Count { get; set; }

        /// <summary>
        /// <para>The number of S4-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S4Count")]
        [Validation(Required=false)]
        public long? S4Count { get; set; }

        /// <summary>
        /// <para>The number of S5-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S5Count")]
        [Validation(Required=false)]
        public long? S5Count { get; set; }

        /// <summary>
        /// <para>The number of S6-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S6Count")]
        [Validation(Required=false)]
        public long? S6Count { get; set; }

        /// <summary>
        /// <para>The number of S7-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S7Count")]
        [Validation(Required=false)]
        public long? S7Count { get; set; }

        /// <summary>
        /// <para>The number of S8-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S8Count")]
        [Validation(Required=false)]
        public long? S8Count { get; set; }

        /// <summary>
        /// <para>The number of S9-level data objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S9Count")]
        [Validation(Required=false)]
        public long? S9Count { get; set; }

        /// <summary>
        /// <para>The number of sensitive data items within the current statistics scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SensitiveCount")]
        [Validation(Required=false)]
        public long? SensitiveCount { get; set; }

        /// <summary>
        /// <para>The number of databases that contain sensitive data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SensitiveDbCount")]
        [Validation(Required=false)]
        public long? SensitiveDbCount { get; set; }

        /// <summary>
        /// <para>The number of instances that contain sensitive data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SensitiveInstanceCount")]
        [Validation(Required=false)]
        public long? SensitiveInstanceCount { get; set; }

        /// <summary>
        /// <para>The size of sensitive unstructured data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("SensitiveUnStructSize")]
        [Validation(Required=false)]
        public long? SensitiveUnStructSize { get; set; }

        /// <summary>
        /// <para>The number of child sensitive data objects. This parameter is used for sensitive column statistics in structured data scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SubSensitiveCount")]
        [Validation(Required=false)]
        public long? SubSensitiveCount { get; set; }

        /// <summary>
        /// <para>The total number of child data objects. This parameter is used for column-level statistics in structured data scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SubTotalCount")]
        [Validation(Required=false)]
        public long? SubTotalCount { get; set; }

        /// <summary>
        /// <para>The total number of items that meet the current statistics or query scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The total size of unstructured data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("UnStructSize")]
        [Validation(Required=false)]
        public long? UnStructSize { get; set; }

    }

}
