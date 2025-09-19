// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVirusScanConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned if the request was successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVirusScanConfigResponseBodyData Data { get; set; }
        public class GetVirusScanConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Extended scan types.</para>
            /// </summary>
            [NameInMap("AdditionType")]
            [Validation(Required=false)]
            public List<string> AdditionType { get; set; }

            /// <summary>
            /// <para>The ID of the task configuration.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~DescribeCycleTaskList~~">DescribeCycleTaskList</a> operation to query the IDs of task configurations.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>97a1fed216908e417407344e1505xxxx</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// <para>Indicates whether the periodic scan feature is enabled. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The feature is enabled</description></item>
            /// <item><description><b>0</b>: The feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <para>The interval at which virus scan tasks are run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("IntervalPeriod")]
            [Validation(Required=false)]
            public int? IntervalPeriod { get; set; }

            /// <summary>
            /// <para>The unit of the interval at which virus scan tasks are run.</para>
            /// <list type="bullet">
            /// <item><description>The value is fixed as <b>day</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The file paths.</para>
            /// </summary>
            [NameInMap("ScanPath")]
            [Validation(Required=false)]
            public List<string> ScanPath { get; set; }

            /// <summary>
            /// <para>The type of the virus scan task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system</b>: automatic scan.</description></item>
            /// <item><description><b>user</b>: custom scan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <para>The key that stores the asset information.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~GetAssetSelectionConfig~~">GetAssetSelectionConfig</a> operation to obtain the key value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>345ddbea-a57f-437e-832f-fb7a1202xxxx</para>
            /// </summary>
            [NameInMap("SelectionKey")]
            [Validation(Required=false)]
            public string SelectionKey { get; set; }

            /// <summary>
            /// <para>The end time of the virus scan task. The time is a time frame.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("TargetEndTime")]
            [Validation(Required=false)]
            public int? TargetEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the virus scan task. The time is a time frame.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TargetStartTime")]
            [Validation(Required=false)]
            public int? TargetStartTime { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>VIRUS_VUL_SCHEDULE_SCAN</b>: a virus scan task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VIRUS_VUL_SCHEDULE_SCAN</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>028CF634-5268-5660-9575-48C9ED6BDEFC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
