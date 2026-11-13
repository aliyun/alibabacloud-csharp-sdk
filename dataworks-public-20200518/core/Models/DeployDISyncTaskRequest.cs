// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeployDISyncTaskRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>If TaskType is set to DI_REALTIME, FileId is the file ID of the real-time synchronization task.</description></item>
        /// <item><description>If TaskType is set to DI_SOLUTION, FileId is the task ID of the primary site synchronization task.</description></item>
        /// </list>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/173942.html">ListFiles</a> operation to obtain the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. Log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace for the current API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The type of the Data Integration synchronization task associated with the destination data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DI_REALTIME: a real-time synchronization task in Data Integration.</description></item>
        /// <item><description>DI_SOLUTION: a primary site synchronization task in Data Integration.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DI_REALTIME</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
