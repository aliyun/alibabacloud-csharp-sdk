// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListTotalSensitiveInfoResponseBody : TeaModel {
        [NameInMap("DataCountDOList")]
        [Validation(Required=false)]
        public List<ListTotalSensitiveInfoResponseBodyDataCountDOList> DataCountDOList { get; set; }
        public class ListTotalSensitiveInfoResponseBodyDataCountDOList : TeaModel {
            [NameInMap("DataCountDOList")]
            [Validation(Required=false)]
            public List<ListTotalSensitiveInfoResponseBodyDataCountDOListDataCountDOList> DataCountDOList { get; set; }
            public class ListTotalSensitiveInfoResponseBodyDataCountDOListDataCountDOList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1788537600000000000</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public long? Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("SensitiveCount")]
                [Validation(Required=false)]
                public long? SensitiveCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1788537600000000000</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RuleInfoList")]
            [Validation(Required=false)]
            public List<ListTotalSensitiveInfoResponseBodyDataCountDOListRuleInfoList> RuleInfoList { get; set; }
            public class ListTotalSensitiveInfoResponseBodyDataCountDOListRuleInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RuleCount")]
                [Validation(Required=false)]
                public long? RuleCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>手机号</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S0Count")]
            [Validation(Required=false)]
            public long? S0Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S10Count")]
            [Validation(Required=false)]
            public long? S10Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S1Count")]
            [Validation(Required=false)]
            public long? S1Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S2Count")]
            [Validation(Required=false)]
            public long? S2Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S3Count")]
            [Validation(Required=false)]
            public long? S3Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S4Count")]
            [Validation(Required=false)]
            public long? S4Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S5Count")]
            [Validation(Required=false)]
            public long? S5Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S6Count")]
            [Validation(Required=false)]
            public long? S6Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S7Count")]
            [Validation(Required=false)]
            public long? S7Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S8Count")]
            [Validation(Required=false)]
            public long? S8Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("S9Count")]
            [Validation(Required=false)]
            public long? S9Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public long? SensitiveCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StructFlag")]
            [Validation(Required=false)]
            public int? StructFlag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>通用分类分级模板</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DbCount")]
        [Validation(Required=false)]
        public long? DbCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public long? InstanceCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleInfoList")]
        [Validation(Required=false)]
        public List<ListTotalSensitiveInfoResponseBodyRuleInfoList> RuleInfoList { get; set; }
        public class ListTotalSensitiveInfoResponseBodyRuleInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public long? RuleCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>手机号</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S0Count")]
        [Validation(Required=false)]
        public long? S0Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S10Count")]
        [Validation(Required=false)]
        public long? S10Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S1Count")]
        [Validation(Required=false)]
        public long? S1Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S2Count")]
        [Validation(Required=false)]
        public long? S2Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S3Count")]
        [Validation(Required=false)]
        public long? S3Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S4Count")]
        [Validation(Required=false)]
        public long? S4Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S5Count")]
        [Validation(Required=false)]
        public long? S5Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S6Count")]
        [Validation(Required=false)]
        public long? S6Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S7Count")]
        [Validation(Required=false)]
        public long? S7Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S8Count")]
        [Validation(Required=false)]
        public long? S8Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("S9Count")]
        [Validation(Required=false)]
        public long? S9Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SensitiveCount")]
        [Validation(Required=false)]
        public long? SensitiveCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SensitiveDbCount")]
        [Validation(Required=false)]
        public long? SensitiveDbCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SensitiveInstanceCount")]
        [Validation(Required=false)]
        public long? SensitiveInstanceCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("SensitiveUnStructSize")]
        [Validation(Required=false)]
        public long? SensitiveUnStructSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SubSensitiveCount")]
        [Validation(Required=false)]
        public long? SubSensitiveCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SubTotalCount")]
        [Validation(Required=false)]
        public long? SubTotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("UnStructSize")]
        [Validation(Required=false)]
        public long? UnStructSize { get; set; }

    }

}
