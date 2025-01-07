// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of assets on which the task is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("FinishCount")]
        [Validation(Required=false)]
        public int? FinishCount { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D18B5DAD-BA97-5552-AE48-83F59D5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code of the Cloud Security Posture Management (CSPM) task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The task is being initialized. The system is calculating the total number of subtasks.</description></item>
        /// <item><description>1: The task is being executed. You can query the total number of tasks and the number of completed tasks.</description></item>
        /// <item><description>2: The task is successful.</description></item>
        /// <item><description>3: The task times out.</description></item>
        /// <item><description>4: The task is invalid. Check whether assets exist.</description></item>
        /// <item><description>5: No task record is found. Check whether the TaskId parameter is valid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5347c7b6-c85c-4070-846a-3029e08e****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The total number of assets on which the task is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
