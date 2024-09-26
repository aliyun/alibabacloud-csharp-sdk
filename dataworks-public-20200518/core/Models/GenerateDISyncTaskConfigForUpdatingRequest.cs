// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GenerateDISyncTaskConfigForUpdatingRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. This parameter is used to prevent repeated operations that are caused by multiple calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the workspace ID.</para>
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
        /// <para>The task ID.</para>
        /// <list type="bullet">
        /// <item><description>If you set the TaskType parameter to DI_REALTIME, set the TaskId parameter to the value of the FileId parameter for the real-time synchronization task.</description></item>
        /// <item><description>If you set the TaskType parameter to DI_SOLUTION, set the TaskId parameter to the value of the FileId parameter for the synchronization solution.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The script for updating the real-time synchronization task in Data Integration. DataWorks allows you to add or remove tables for a real-time synchronization task in Data Integration only in asynchronous mode. The following types of real-time synchronization tasks are supported:</para>
        /// <list type="bullet">
        /// <item><description>Synchronization task that is used to synchronize data from MySQL to MaxCompute</description></item>
        /// <item><description>Synchronization task that is used to synchronize data from MySQL data to Kafka</description></item>
        /// <item><description>Synchronization task that is used to synchronize data from MySQL to Hologres</description></item>
        /// </list>
        /// <para>The SelectedTables parameter is used to specify tables that you want to synchronize from multiple databases. The Tables parameter is used to specify tables that you want to synchronize from a single database.</para>
        /// <list type="bullet">
        /// <item><description>If the script contains the SelectedTables parameter, the system synchronizes data from the tables that you specify in the SelectedTables parameter.</description></item>
        /// <item><description>If the script contains the Tables parameter, the system synchronizes data from the tables that you specify in the Tables parameter.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{      &quot;steps&quot;: [         {             &quot;parameter&quot;: {                 &quot;connection&quot;: [                     {                         &quot;table&quot;: [                             &quot;xyx&quot;                         ]                     }                 ]             },             &quot;name&quot;: &quot;Reader&quot;,             &quot;category&quot;: &quot;reader&quot;         }     ] }</para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// <para>The type of the object that you want to update in Data Integration in asynchronous mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DI_REALTIME: real-time synchronization task</description></item>
        /// <item><description>DI_SOLUTION: synchronization solution DataWorks allows you to create or update real-time synchronization tasks in Data Integration only in asynchronous mode.</description></item>
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
