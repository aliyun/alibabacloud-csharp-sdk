// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GenerateDISyncTaskConfigForCreatingRequest : TeaModel {
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
        /// <para>The script for the synchronization task. DataWorks allows you to create the following types of synchronization tasks:</para>
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
        /// <para>The following sample code provides a script for data synchronization from MySQL to MaxCompute:</para>
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
        /// <para>The following sample code provides a script for data synchronization from MySQL to Kafka:</para>
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
        /// <para>The following sample code provides a script for data synchronization from MySQL to Hologres:</para>
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
        /// <para>{    &quot;type&quot;: &quot;realtime&quot;,     &quot;version&quot;: &quot;1.0&quot;,        &quot;setting&quot;: {       &quot;resourceGroup&quot;:       &quot;S_res_group_280749521950784_1623033752022&quot;,        &quot;scheduleResgroupId&quot;: 30003913,       &quot;name&quot;: &quot;openapi_realtime_solution_0813_1739&quot;,       &quot;taskType&quot;: &quot;oneclick_to_odps&quot;     },     &quot;steps&quot;: [         {             &quot;stepType&quot;: &quot;mysql&quot;,             &quot;parameter&quot;: {                 &quot;connection&quot;: [                     {                        &quot;datasourceType&quot;: &quot;mysql&quot;,                         &quot;datasource&quot;: &quot;mysql_pub&quot;,                         &quot;table&quot;: [                             &quot;xyx&quot;                         ]                     }                 ]             },             &quot;name&quot;: &quot;Reader&quot;,             &quot;category&quot;: &quot;reader&quot;         },         {             &quot;stepType&quot;: &quot;odps&quot;,             &quot;parameter&quot;: {                 &quot;datasource&quot;: &quot;odps_first&quot;             },             &quot;name&quot;: &quot;Writer&quot;,             &quot;category&quot;: &quot;writer&quot;         }     ] }</para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// <para>The type of task that you want to create in Data Integration in asynchronous mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DI_REALTIME: real-time synchronization task</description></item>
        /// <item><description>DI_SOLUTION: another type of synchronization task</description></item>
        /// </list>
        /// <para>DataWorks allows you to create real-time synchronization tasks and other types of synchronization tasks in Data Integration only in asynchronous mode.</para>
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
