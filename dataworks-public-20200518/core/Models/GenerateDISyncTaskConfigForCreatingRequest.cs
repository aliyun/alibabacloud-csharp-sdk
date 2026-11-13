// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GenerateDISyncTaskConfigForCreatingRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token. This parameter prevents duplicate operations caused by repeated calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Configuration page to obtain the workspace ID.</para>
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
        /// <para>The script of the Data Integration synchronization task.
        /// The following types of synchronization tasks can be created: </para>
        /// <list type="bullet">
        /// <item><description>Synchronize data from MySQL to MaxCompute.</description></item>
        /// <item><description>Synchronize data from MySQL to Kafka.</description></item>
        /// <item><description>Synchronize data from MySQL to Hologres.</description></item>
        /// </list>
        /// <para>SelectedTables is used to select synchronization tables in multi-database mode, and Tables is used to select synchronization tables in single-database mode.</para>
        /// <list type="bullet">
        /// <item><description>If the script contains the SelectedTables statement, the system uses the table information in the SelectedTables statement for synchronization.</description></item>
        /// <item><description>If the script contains the Tables statement, the system uses the field information of Tables for synchronization.</description></item>
        /// </list>
        /// <para>The following example shows the script for synchronizing data from MySQL to MaxCompute:</para>
        /// <pre><c>{
        ///   &quot;type&quot;: &quot;realtime&quot;,
        ///   &quot;version&quot;: &quot;1.0&quot;,
        ///   &quot;setting&quot;: {
        ///     &quot;resourceGroup&quot;: &quot;S_res_group_280749521950784_1623033752022&quot;,
        ///     &quot;taskType&quot;: &quot;oneclick_to_odps&quot;
        ///   },
        ///   &quot;steps&quot;: [
        ///     {
        ///       &quot;stepType&quot;: &quot;mysql&quot;,
        ///       &quot;parameter&quot;: {
        ///         &quot;connection&quot;: [
        ///           {
        ///             &quot;datasourceType&quot;: &quot;mysql&quot;,
        ///             &quot;datasource&quot;: &quot;mysql_pub1&quot;,
        ///             &quot;selectedTables&quot;: [
        ///               {
        ///                 &quot;dbName&quot;: &quot;mysql_db&quot;,
        ///                 &quot;schema&quot;: [
        ///                   {
        ///                     &quot;tableInfos&quot;: [
        ///                       {
        ///                         &quot;table&quot;: &quot;molin_di_test_in_pk_v4&quot;
        ///                       }
        ///                     ]
        ///                   }
        ///                 ]
        ///               }
        ///             ]
        ///           }
        ///         ]
        ///       },
        ///       &quot;name&quot;: &quot;Reader&quot;,
        ///       &quot;category&quot;: &quot;reader&quot;
        ///     },
        ///     {
        ///       &quot;stepType&quot;: &quot;odps&quot;,
        ///       &quot;parameter&quot;: {
        ///         &quot;datasource&quot;: &quot;odps_source&quot;
        ///       },
        ///       &quot;name&quot;: &quot;Writer&quot;,
        ///       &quot;category&quot;: &quot;writer&quot;
        ///     }
        ///   ]
        /// }
        /// </c></pre>
        /// <para>The following example shows the script for synchronizing data from MySQL to Kafka:</para>
        /// <pre><c>{
        ///   &quot;type&quot;: &quot;realtime&quot;,
        ///   &quot;version&quot;: &quot;1.0&quot;,
        ///   &quot;setting&quot;: {
        ///     &quot;resourceGroup&quot;: &quot;S_res_group_280749521950784_1623033752022&quot;,
        ///     &quot;taskType&quot;: &quot;oneclick_to_kafka&quot;
        ///   },
        ///   &quot;steps&quot;: [
        ///     {
        ///       &quot;stepType&quot;: &quot;mysql&quot;,
        ///       &quot;parameter&quot;: {
        ///         &quot;connection&quot;: [
        ///           {
        ///             &quot;datasourceType&quot;: &quot;mysql&quot;,
        ///             &quot;datasource&quot;: &quot;pkset_test&quot;,
        ///             &quot;selectedTables&quot;: [
        ///               {
        ///                 &quot;dbName&quot;: &quot;mysql_db&quot;,
        ///                 &quot;schema&quot;: [
        ///                   {
        ///                     &quot;tableInfos&quot;: [
        ///                       {
        ///                         &quot;table&quot;: &quot;molin_di_test_in_pk_v4&quot;
        ///                       }
        ///                     ]
        ///                   }
        ///                 ]
        ///               }
        ///             ]
        ///           }
        ///         ]
        ///       },
        ///       &quot;name&quot;: &quot;Reader&quot;,
        ///       &quot;category&quot;: &quot;reader&quot;
        ///     },
        ///     {
        ///       &quot;stepType&quot;: &quot;kafka&quot;,
        ///       &quot;parameter&quot;: {
        ///         &quot;datasource&quot;: &quot;azn_kafka&quot;
        ///       },
        ///       &quot;name&quot;: &quot;Writer&quot;,
        ///       &quot;category&quot;: &quot;writer&quot;
        ///     }
        ///   ]
        /// }
        /// </c></pre>
        /// <para>The following example shows the script for synchronizing data from MySQL to Hologres:</para>
        /// <pre><c>{
        ///   &quot;type&quot;: &quot;realtime&quot;,
        ///   &quot;version&quot;: &quot;1.0&quot;,
        ///   &quot;setting&quot;: {
        ///     &quot;resourceGroup&quot;: &quot;S_res_group_280749521950784_1623033752022&quot;,
        ///     &quot;taskType&quot;: &quot;oneclick_to_holo&quot;
        ///   },
        ///   &quot;steps&quot;: [
        ///     {
        ///       &quot;stepType&quot;: &quot;mysql&quot;,
        ///       &quot;parameter&quot;: {
        ///         &quot;connection&quot;: [
        ///           {
        ///             &quot;datasourceType&quot;: &quot;mysql&quot;,
        ///             &quot;datasource&quot;: &quot;mysql_pub&quot;,
        ///             &quot;selectedTables&quot;: [
        ///               {
        ///                 &quot;dbName&quot;: &quot;mysql_db&quot;,
        ///                 &quot;schema&quot;: [
        ///                   {
        ///                     &quot;tableInfos&quot;: [
        ///                       {
        ///                         &quot;table&quot;: &quot;molin_di_test_in2_pk_v3&quot;
        ///                       }
        ///                     ]
        ///                   }
        ///                 ]
        ///               }
        ///             ]
        ///           }
        ///         ]
        ///       },
        ///       &quot;name&quot;: &quot;Reader&quot;,
        ///       &quot;category&quot;: &quot;reader&quot;
        ///     },
        ///     {
        ///       &quot;stepType&quot;: &quot;holo&quot;,
        ///       &quot;parameter&quot;: {
        ///         &quot;datasource&quot;: &quot;holo&quot;
        ///       },
        ///       &quot;name&quot;: &quot;Writer&quot;,
        ///       &quot;category&quot;: &quot;writer&quot;
        ///     }
        ///   ]
        /// }
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{  &quot;type&quot;: &quot;realtime&quot;,  &quot;version&quot;: &quot;1.0&quot;,  &quot;setting&quot;: {  &quot;resourceGroup&quot;: &quot;S_res_group_280749521950784_1623033752022&quot;,  &quot;taskType&quot;: &quot;oneclick_to_odps&quot;  },  &quot;steps&quot;: [{ &quot;stepType&quot;: &quot;mysql&quot;, &quot;parameter&quot;: { &quot;connection&quot;: [ { &quot;datasourceType&quot;: &quot;mysql&quot;, &quot;datasource&quot;: &quot;mysql_pub1&quot;, &quot;selectedTables&quot;: [ { &quot;dbName&quot;: &quot;mysql_db&quot;, &quot;schema&quot;: [ { &quot;tableInfos&quot;: [ { &quot;table&quot;: &quot;molin_di_test_in_pk_v4&quot; }]  }  ]  }  ]  }  ]  },  &quot;name&quot;: &quot;Reader&quot;,  &quot;category&quot;: &quot;reader&quot;  },  {  &quot;stepType&quot;: &quot;odps&quot;,  &quot;parameter&quot;: {  &quot;datasource&quot;: &quot;odps_source&quot;  },  &quot;name&quot;: &quot;Writer&quot;,  &quot;category&quot;: &quot;writer&quot;  }  ]  }</para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// <para>The type of the Data Integration synchronization task created by using the asynchronous method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DI_REALTIME: real-time synchronization task</description></item>
        /// <item><description>DI_SOLUTION: other types of synchronization tasks</description></item>
        /// </list>
        /// <para>Only the asynchronous method is supported for generating real-time synchronization tasks and other types of synchronization tasks in Data Integration.</para>
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
