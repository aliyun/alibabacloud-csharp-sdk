// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleQuery : TeaModel {
        [NameInMap("checkAfterDataComplete")]
        [Validation(Required=false)]
        public bool? CheckAfterDataComplete { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        [NameInMap("firstJoin")]
        [Validation(Required=false)]
        public AlertRuleSlsQueryJoin FirstJoin { get; set; }

        [NameInMap("groupFieldList")]
        [Validation(Required=false)]
        public List<string> GroupFieldList { get; set; }

        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("queries")]
        [Validation(Required=false)]
        public List<AlertRuleQueryQueries> Queries { get; set; }
        public class AlertRuleQueryQueries : TeaModel {
            [NameInMap("apmAlertMetricId")]
            [Validation(Required=false)]
            public string ApmAlertMetricId { get; set; }

            [NameInMap("apmFilters")]
            [Validation(Required=false)]
            public List<AlertRuleQueryQueriesApmFilters> ApmFilters { get; set; }
            public class AlertRuleQueryQueriesApmFilters : TeaModel {
                [NameInMap("dim")]
                [Validation(Required=false)]
                public string Dim { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("apmGroupBy")]
            [Validation(Required=false)]
            public List<string> ApmGroupBy { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>时间偏移结束时间(相对)，如果指定了start、end，则不指定window。</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>查询表达式</para>
            /// </summary>
            [NameInMap("expr")]
            [Validation(Required=false)]
            public string Expr { get; set; }

            /// <summary>
            /// <para>sls查询的时间偏移开始时间(相对)，如果指定了start、end，则不指定window。  例如：start=15， timeUnit=minute，表示15分钟前</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// <para>start和end、window的时间单位： day/hour/minute/second</para>
            /// </summary>
            [NameInMap("timeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>整点时间查询区间。  如果指定了window则不指定start、end</para>
            /// </summary>
            [NameInMap("window")]
            [Validation(Required=false)]
            public long? Window { get; set; }

        }

        [NameInMap("secondJoin")]
        [Validation(Required=false)]
        public AlertRuleSlsQueryJoin SecondJoin { get; set; }

        /// <summary>
        /// <para>查询类型</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
