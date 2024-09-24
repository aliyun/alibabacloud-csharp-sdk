// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulCheckTaskStatusDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578ABF384</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the status information about the vulnerability scan tasks on the server.</para>
        /// </summary>
        [NameInMap("TaskStatuses")]
        [Validation(Required=false)]
        public List<DescribeVulCheckTaskStatusDetailResponseBodyTaskStatuses> TaskStatuses { get; set; }
        public class DescribeVulCheckTaskStatusDetailResponseBodyTaskStatuses : TeaModel {
            /// <summary>
            /// <para>The ID of the main task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16190385</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>An array that consists of status information about the vulnerability scan subtask.</para>
            /// </summary>
            [NameInMap("TaskStatusList")]
            [Validation(Required=false)]
            public List<DescribeVulCheckTaskStatusDetailResponseBodyTaskStatusesTaskStatusList> TaskStatusList { get; set; }
            public class DescribeVulCheckTaskStatusDetailResponseBodyTaskStatusesTaskStatusList : TeaModel {
                /// <summary>
                /// <para>The error code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>push_command_failed</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The status of the subtask. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: unhandled</description></item>
                /// <item><description><b>1</b>: collecting</description></item>
                /// <item><description><b>2</b>: collected</description></item>
                /// <item><description><b>3</b>: matching</description></item>
                /// <item><description><b>4</b>: complete</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the vulnerability. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
                /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
                /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
                /// <item><description><b>sca</b>: vulnerability that is detected based on software component analysis</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cve</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of vulnerability scan tasks on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
