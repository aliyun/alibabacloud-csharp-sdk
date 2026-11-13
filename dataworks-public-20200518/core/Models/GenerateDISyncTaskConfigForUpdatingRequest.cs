// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GenerateDISyncTaskConfigForUpdatingRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure idempotence. This parameter prevents duplicate operations caused by multiple calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
        /// <para>This parameter determines the DataWorks workspace in which the API operation is called.</para>
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
        /// <item><description>If TaskType is set to DI_REALTIME, TaskId is the FileId of the real-time synchronization task.</description></item>
        /// <item><description>If TaskType is set to DI_SOLUTION, TaskId is the FileId of the solution synchronization task.</description></item>
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
        /// <para>The script statements for updating the synchronization task.
        /// Currently, the asynchronous method only supports adding or removing tables for data integration synchronization tasks. Only the following types of synchronization tasks can be updated:</para>
        /// <list type="bullet">
        /// <item><description>Synchronizing MySQL data to MaxCompute.</description></item>
        /// <item><description>Synchronizing MySQL data to Kafka.</description></item>
        /// <item><description>Synchronizing MySQL data to Hologres.</description></item>
        /// </list>
        /// <para>In a synchronization task, SelectedTables is used to select tables in multi-database mode, and Tables is used to select tables in single-database mode.</para>
        /// <list type="bullet">
        /// <item><description>If the script contains the SelectedTables statement, the system uses the table information in the SelectedTables statement for synchronization.</description></item>
        /// <item><description>If the script contains the Tables statement, the system uses the field information in the Tables statement for synchronization.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;steps&quot;:[{&quot;parameter&quot;:{&quot;connection&quot;:[{&quot;table&quot;:[&quot;xyx&quot;]}]},&quot;name&quot;:&quot;Reader&quot;,&quot;category&quot;:&quot;reader&quot;}]}</para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// <para>The type of the Data Integration synchronization task to be updated asynchronously. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DI_REALTIME: real-time synchronization task.</description></item>
        /// <item><description>DI_SOLUTION: solution synchronization task.
        /// Only real-time and solution synchronization tasks can be updated asynchronously.</description></item>
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
