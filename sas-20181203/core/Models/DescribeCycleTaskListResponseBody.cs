// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCycleTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of periodic scan tasks.</para>
        /// </summary>
        [NameInMap("CycleScheduleResponseList")]
        [Validation(Required=false)]
        public List<DescribeCycleTaskListResponseBodyCycleScheduleResponseList> CycleScheduleResponseList { get; set; }
        public class DescribeCycleTaskListResponseBodyCycleScheduleResponseList : TeaModel {
            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2cdbdeba8dd70586d5814d4cbf21****</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration for the task interval was enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled.</description></item>
            /// <item><description><b>0</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <para>The time when the task first started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1667491200000</para>
            /// </summary>
            [NameInMap("FirstDateStr")]
            [Validation(Required=false)]
            public long? FirstDateStr { get; set; }

            /// <summary>
            /// <para>The interval between which two consecutive tasks are run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("IntervalPeriod")]
            [Validation(Required=false)]
            public int? IntervalPeriod { get; set; }

            /// <summary>
            /// <para>The ID of the last task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38730bb078f4a1461d4ed283994c****</para>
            /// </summary>
            [NameInMap("LastTaskId")]
            [Validation(Required=false)]
            public string LastTaskId { get; set; }

            /// <summary>
            /// <para>The time when the next task starts. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671184531000</para>
            /// </summary>
            [NameInMap("NextStartTimeStr")]
            [Validation(Required=false)]
            public long? NextStartTimeStr { get; set; }

            /// <summary>
            /// <para>The extended information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;userAgreement&quot;:&quot;yes&quot;,&quot;lang&quot;:&quot;zh&quot;}</para>
            /// </summary>
            [NameInMap("Param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// <para>The unit of the scan interval. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>day</b></description></item>
            /// <item><description><b>hour</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The end time of the task. The time must be a time frame.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TargetEndTime")]
            [Validation(Required=false)]
            public int? TargetEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the task. The start time must be a time frame.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TargetStartTime")]
            [Validation(Required=false)]
            public int? TargetStartTime { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE_SCAN</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The type of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE_SCAN</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCycleTaskListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCycleTaskListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB393****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
