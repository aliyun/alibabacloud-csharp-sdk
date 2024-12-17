// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the task.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTasksResponseBodyItems> Items { get; set; }
        public class DescribeTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The beginning time of the task. The time follows the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-13T06:16:54Z</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// <para>The name of the subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>init_redis</para>
            /// </summary>
            [NameInMap("CurrentStepName")]
            [Validation(Required=false)]
            public string CurrentStepName { get; set; }

            /// <summary>
            /// <para>The end time of the task. The time follows the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-13T06:17:18Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The progress of the task. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// <para>The estimated remaining duration of the task. Unit: seconds.</para>
            /// <remarks>
            /// <para> If the task is not running, this parameter is not returned or the returned value is <b>0</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Remain")]
            [Validation(Required=false)]
            public int? Remain { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The task is pending.</description></item>
            /// <item><description><b>1</b>: The task is running.</description></item>
            /// <item><description><b>2</b>: The task is complete.</description></item>
            /// <item><description><b>4</b>: The task is closed.</description></item>
            /// <item><description><b>7</b>: The task is paused.</description></item>
            /// <item><description><b>8</b>: The task is interrupted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The progress of the subtask.</para>
            /// <remarks>
            /// <para> If the subtask does not exist, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3/3</para>
            /// </summary>
            [NameInMap("StepProgressInfo")]
            [Validation(Required=false)]
            public string StepProgressInfo { get; set; }

            /// <summary>
            /// <para>The information about the subtask in the JSON format. This includes the expected remaining duration (<b>remain</b>), the name of the subtask (<b>name</b>), and the task progress (<b>progress</b>).</para>
            /// <remarks>
            /// <para> If the subtask does not exist, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;remain\&quot;:0,\&quot;name\&quot;:\&quot;init_instance\&quot;,\&quot;progress\&quot;:100},{\&quot;remain\&quot;:107,\&quot;name\&quot;:\&quot;init_redis\&quot;,\&quot;progress\&quot;:12.3},{\&quot;remain\&quot;:1881,\&quot;name\&quot;:\&quot;init_config\&quot;,\&quot;progress\&quot;:0}]</para>
            /// </summary>
            [NameInMap("StepsInfo")]
            [Validation(Required=false)]
            public string StepsInfo { get; set; }

            /// <summary>
            /// <para>The identifier of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ModifyDBInstanceParameter</para>
            /// </summary>
            [NameInMap("TaskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32302****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>608FAEC9-485E-4C65-82DE-2E5B955E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
