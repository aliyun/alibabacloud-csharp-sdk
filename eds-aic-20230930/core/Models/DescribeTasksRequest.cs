// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud phone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acp-2zecay9ponatdc4m****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the cloud phone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defaultInstanceName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the command execution. You can set the value to the last returned request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8ED2BA9-0C6A-5643-818F-B5D60A64****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The level of the task. A value of 1 specifies a batch task. A value of 2 specifies an instance-level task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If the parameter is left empty, the data is queried from the first entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFbc8N4E1iOlcSxC+8boa0HHH2LKWbggYUinyrZWvtS1oTrMYCg1HuMLGuftj0****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The extension field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>param</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The ID of the parent task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-iaej5dkbnmivx****</para>
        /// </summary>
        [NameInMap("ParentTaskId")]
        [Validation(Required=false)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// <para>The IDs of the resources.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The IDs of the tasks.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

        /// <summary>
        /// <para>The state of the task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PartFinished: The task is partially successful.</description></item>
        /// <item><description>Finished: The task is completed.</description></item>
        /// <item><description>Failed: The task failed.</description></item>
        /// <item><description>Skipped: The task is skipped.</description></item>
        /// <item><description>Processing: The task is running.</description></item>
        /// <item><description>Waiting: The task is in queue.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Processing</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The status of the tasks.</para>
        /// </summary>
        [NameInMap("TaskStatuses")]
        [Validation(Required=false)]
        public List<string> TaskStatuses { get; set; }

        /// <summary>
        /// <para>The type of the task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BackupFile: backs up files.</description></item>
        /// <item><description>StopInstance: stops cloud phone instances.</description></item>
        /// <item><description>RebootInstance: restarts cloud phone instances.</description></item>
        /// <item><description>StartApp: starts apps.</description></item>
        /// <item><description>SendFile: uploads files.</description></item>
        /// <item><description>RunCommand: sends remote command.</description></item>
        /// <item><description>RestartApp: restarts apps.</description></item>
        /// <item><description>ResetInstance: resets cloud phone instances.</description></item>
        /// <item><description>RecoverFile: recovers files.</description></item>
        /// <item><description>UninstallApp: uninstalls apps.</description></item>
        /// <item><description>StopApp: stops apps.</description></item>
        /// <item><description>Screenshot: takes screenshots.</description></item>
        /// <item><description>InstallApp: installs apps.</description></item>
        /// <item><description>FetchFile: downloads files.</description></item>
        /// <item><description>UpdateGroupImage: replaces images.</description></item>
        /// <item><description>StartInstance: starts instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>StartInstance</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The types of the tasks.</para>
        /// </summary>
        [NameInMap("TaskTypes")]
        [Validation(Required=false)]
        public List<string> TaskTypes { get; set; }

    }

}
