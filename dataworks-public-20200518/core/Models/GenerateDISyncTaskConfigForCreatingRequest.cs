// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GenerateDISyncTaskConfigForCreatingRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. This parameter is used to prevent repeated operations that are caused by multiple calls.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace Management page to obtain the workspace ID.
        /// 
        /// This parameter specifies the DataWorks workspace to which the operation is applied.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The script for the real-time synchronization node or synchronization solution in Data Integration.
        /// 
        /// The following types of real-time synchronization nodes and synchronization solutions are supported:
        /// 
        /// *   Real-time synchronization node or synchronization solution that is used to synchronize data from MySQL to MaxCompute
        /// *   Real-time synchronization node or synchronization solution that is used to synchronize data from MySQL data to Kafka
        /// *   Real-time synchronization node or synchronization solution that is used to synchronize data from MySQL to Hologres
        /// 
        /// The SelectedTables parameter is used to specify tables that you want to synchronize from multiple databases. The Tables parameter is used to specify tables that you want to synchronize from a single database.
        /// 
        /// *   If the script contains the SelectedTables parameter, the system synchronizes the tables that you specify in the SelectedTables parameter.
        /// *   If the script contains the Tables parameter, the system synchronizes the tables that you specify in the Tables parameter.
        /// 
        /// The following sample code provides a script for data synchronization from MySQL to MaxCompute:
        /// 
        /// {
        /// 
        /// "type": "realtime",
        /// 
        /// "version": "1.0",
        /// 
        /// "setting": {
        /// 
        /// "resourceGroup": "S_res_group\_280749521950784\_1623033752022",
        /// 
        /// "taskType": "oneclick_to_odps"
        /// 
        /// },
        /// 
        /// "steps": { "stepType": "mysql", "parameter": { "connection": \[ { "datasourceType": "mysql", "datasource": "mysql_pub1", "selectedTables": \[ { "dbName": "mysql_db", "schema": \[ { "tableInfos": \[ { "table": "molin_di_test_in_pk_v4" }
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// },
        /// 
        /// "name": "Reader",
        /// 
        /// "category": "reader"
        /// 
        /// },
        /// 
        /// {
        /// 
        /// "stepType": "odps",
        /// 
        /// "parameter": {
        /// 
        /// "datasource": "odps_first"
        /// 
        /// },
        /// 
        /// "name": "Writer",
        /// 
        /// "category": "writer"
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// }
        /// 
        /// The following sample code provides a script for data synchronization from MySQL to Kafka:
        /// 
        /// {
        /// 
        /// "type": "realtime",
        /// 
        /// "version": "1.0",
        /// 
        /// "setting": {
        /// 
        /// "resourceGroup": "S_res_group\_280749521950784\_1623033752022",
        /// 
        /// "taskType": "oneclick_to_kafka"
        /// 
        /// },
        /// 
        /// "steps": { "stepType": "mysql", "parameter": { "connection": \[ { "datasourceType": "mysql", "datasource": "pkset_test", "selectedTables": \[ { "dbName": "mysql_db", "schema": \[ { "tableInfos": \[ { "table": "molin_di_test_in_pk_v4" }
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// },
        /// 
        /// "name": "Reader",
        /// 
        /// "category": "reader"
        /// 
        /// },
        /// 
        /// {
        /// 
        /// "stepType": "kafka",
        /// 
        /// "parameter": {
        /// 
        /// "datasource": "azn_kafka"
        /// 
        /// },
        /// 
        /// "name": "Writer",
        /// 
        /// "category": "writer"
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// }
        /// 
        /// The following sample code provides a script for data synchronization from MySQL to Hologres:
        /// 
        /// {
        /// 
        /// "type": "realtime",
        /// 
        /// "version": "1.0",
        /// 
        /// "setting": {
        /// 
        /// "resourceGroup": "S_res_group\_280749521950784\_1623033752022",
        /// 
        /// "taskType": "oneclick_to_holo"
        /// 
        /// },
        /// 
        /// "steps": { "stepType": "mysql", "parameter": { "connection": \[ { "datasourceType": "mysql", "datasource": "mysql_pub", "selectedTables": \[ { "dbName": "mysql_db", "schema": \[ { "tableInfos": \[ { "table": "molin_di_test_in2\_pk_v3" }
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// },
        /// 
        /// "name": "Reader",
        /// 
        /// "category": "reader"
        /// 
        /// },
        /// 
        /// {
        /// 
        /// "stepType": "holo",
        /// 
        /// "parameter": {
        /// 
        /// "datasource": "holo"
        /// 
        /// },
        /// 
        /// "name": "Writer",
        /// 
        /// "category": "writer"
        /// 
        /// }
        /// 
        /// ]
        /// 
        /// }
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// The type of the object that you want to create in Data Integration in asynchronous mode. Valid values:
        /// 
        /// *   DI_REALTIME: real-time synchronization node
        /// *   DI_SOLUTION: synchronization solution
        /// 
        /// DataWorks allows you to create real-time synchronization nodes and synchronization solutions in Data Integration only in asynchronous mode.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
