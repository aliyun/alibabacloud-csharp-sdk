// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulCheckTaskStatusDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578ABF384</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of vulnerability task statuses for the server.</para>
        /// </summary>
        [NameInMap("TaskStatuses")]
        [Validation(Required=false)]
        public List<DescribeVulCheckTaskStatusDetailResponseBodyTaskStatuses> TaskStatuses { get; set; }
        public class DescribeVulCheckTaskStatusDetailResponseBodyTaskStatuses : TeaModel {
            /// <summary>
            /// <para>The main task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16190385</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The list of vulnerability detection task statuses.</para>
            /// </summary>
            [NameInMap("TaskStatusList")]
            [Validation(Required=false)]
            public List<DescribeVulCheckTaskStatusDetailResponseBodyTaskStatusesTaskStatusList> TaskStatusList { get; set; }
            public class DescribeVulCheckTaskStatusDetailResponseBodyTaskStatusesTaskStatusList : TeaModel {
                /// <summary>
                /// <para>The failure code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>push_command_failed</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The completion status of the check. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Unprocessed.</description></item>
                /// <item><description><b>1</b>: Collecting.</description></item>
                /// <item><description><b>2</b>: Collection completed.</description></item>
                /// <item><description><b>3</b>: Matching.</description></item>
                /// <item><description><b>4</b>: Completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The vulnerability type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
                /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
                /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
                /// <item><description><b>sca</b>: sca vulnerability</description></item>
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
        /// <para>The total number of vulnerability subtasks for the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
