// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryDISyncTaskConfigProcessResultRequest : TeaModel {
        /// <summary>
        /// <para>The asynchronous thread ID. You can call the <a href="https://help.aliyun.com/document_detail/383463.html">GenerateDISyncTaskConfigForCreating</a> or <a href="https://help.aliyun.com/document_detail/383464.html">GenerateDISyncTaskConfigForUpdating</a> operation to obtain the ID.</para>
        /// <list type="bullet">
        /// <item><description>The GenerateDISyncTaskConfigForCreating operation is used to generate the ID of the asynchronous thread that is used to create a real-time synchronization task in Data Integration.</description></item>
        /// <item><description>The GenerateDISyncTaskConfigForUpdating operation is used to generate the ID of the asynchronous thread that is used to update a real-time synchronization task in Data Integration.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AsyncProcessId")]
        [Validation(Required=false)]
        public long? AsyncProcessId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the ID.</para>
        /// <para>You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The type of the object that you want to create or update in Data Integration in asynchronous mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DI_REALTIME: real-time synchronization task</description></item>
        /// <item><description>DI_SOLUTION: synchronization solution DataWorks allows you to create or update real-time synchronization tasks and synchronization solutions in Data Integration only in asynchronous mode.</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DI_OFFLINE</description></item>
        /// <item><description>DI_REALTIME</description></item>
        /// <item><description>DI_SOLUTION</description></item>
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
