// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInspectionSchedulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInspectionSchedulesResponseBodyData Data { get; set; }
        public class DescribeInspectionSchedulesResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeInspectionSchedulesResponseBodyDataItems> Items { get; set; }
            public class DescribeInspectionSchedulesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-04-21T02:26:18Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0 0 3 * * ?</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public long? Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HOTKEY</para>
                /// </summary>
                [NameInMap("InspectionItems")]
                [Validation(Required=false)]
                public string InspectionItems { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1h</para>
                /// </summary>
                [NameInMap("InspectionWindow")]
                [Validation(Required=false)]
                public string InspectionWindow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>r-2zed6typz5j6djmb2x</para>
                /// </summary>
                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public string InstanceIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-07-29T10:00:00Z</para>
                /// </summary>
                [NameInMap("NextFireTime")]
                [Validation(Required=false)]
                public string NextFireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("NotifyConfig")]
                [Validation(Required=false)]
                public string NotifyConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zh-CN</para>
                /// </summary>
                [NameInMap("ReportLanguage")]
                [Validation(Required=false)]
                public string ReportLanguage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sch-b45811bf4bba46c8b6d233551da9xxxx</para>
                /// </summary>
                [NameInMap("ScheduleId")]
                [Validation(Required=false)]
                public string ScheduleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sch-test</para>
                /// </summary>
                [NameInMap("ScheduleName")]
                [Validation(Required=false)]
                public string ScheduleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-07-29T06:50:04Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
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
