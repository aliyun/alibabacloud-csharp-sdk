// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeTimerGroupResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTimerGroupResponseBodyData Data { get; set; }
        public class DescribeTimerGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("BindCount")]
            [Validation(Required=false)]
            public int? BindCount { get; set; }

            [NameInMap("BindCountMap")]
            [Validation(Required=false)]
            public Dictionary<string, int?> BindCountMap { get; set; }

            [NameInMap("ConfigTimers")]
            [Validation(Required=false)]
            public List<DescribeTimerGroupResponseBodyDataConfigTimers> ConfigTimers { get; set; }
            public class DescribeTimerGroupResponseBodyDataConfigTimers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowClientSetting")]
                [Validation(Required=false)]
                public bool? AllowClientSetting { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0 0 16 ? * 1,2,3,4,5,6,7</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enforce")]
                [Validation(Required=false)]
                public bool? Enforce { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Shutdown</para>
                /// </summary>
                [NameInMap("OperationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                [NameInMap("ProcessWhitelist")]
                [Validation(Required=false)]
                public List<string> ProcessWhitelist { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RESET_TYPE_SYSTEM</para>
                /// </summary>
                [NameInMap("ResetType")]
                [Validation(Required=false)]
                public string ResetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TimerBoot</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cg-75aazkg2tnqb2*****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Timer</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
