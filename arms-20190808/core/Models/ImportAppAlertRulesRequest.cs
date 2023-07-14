// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ImportAppAlertRulesRequest : TeaModel {
        /// <summary>
        /// ## Additional information about the **TemplageAlertConfig** parameter
        /// 
        /// **JSON string example and description**
        /// 
        /// ```
        /// 
        /// [
        ///   {
        /// 
        ///     "contactGroupIds": "381",                         // The ID of the alert contact group. Multiple IDs are separated by commas (,). You can ignore this parameter in the alert template configuration. The value is automatically generated when ARMS creates the alert rule based on the alert template. 
        ///     "alertType": 5,                                // The alert type. Valid values: 4 and 5. A value of 4 indicates browser monitoring. A value of 5 indicates application monitoring. 
        ///     "alarmContext": {                                // The template of the alert notification. 
        ///       "subTitle": "",
        ///       "content": "Alert name: $alert name\nFilter condition: $filter\nAlert time: $alert time\nAlert content: $alert content\nNote: The alert remains being triggered until a reply email is received. The system will remind you 24 hours later."
        ///     },
        ///     "alertLevel": "WARN",                              // The alert severity. Valid values: FATAL, ERROR, and WARN. 
        ///     "metricParam": {
        ///       "appId": "70901",                              // The ID of the associated application. You can specify an arbitrary value in the alert template configuration. The actual value is automatically generated when ARMS creates the alert rule based on the alert template. 
        ///       "pid": "atc889zkcf@d8deedfa9bf****",            // The PID of the associated application. You can specify an arbitrary value in the alert template configuration. The actual value is automatically generated when ARMS creates the alert rule based on the alert template. 
        ///       "type": "TXN",                                   // The type of the alert metric. For more information, see the following section. 
        ///       "dimensions": [                                 // The information about the associated dimension. For more information, see the following section. 
        ///         {
        ///           "type": "STATIC",
        ///           "value": "\/hello_test_api_address\/test1",
        ///           "key": "rpc"
        ///         }
        ///       ]
        ///     },
        ///     "alertWay": [                                      // The notification method. Valid values: SMS, MAIL, and DING_ROBOT. 
        ///       "SMS",
        ///       "MAIL",
        ///       "DING_ROBOT"
        ///     ],
        ///     "alertRule": {
        ///       "rules": [                                          // The conditions of the alert rule.
        ///         {
        ///           "measure": "appstat.txn.rt",                     // The metric based on which alerts are triggered. For more information, see the following section. 
        ///           "alias": "the response time of API calls in milliseconds",                 // The display parameter of the alert metric. You do not need to set this parameter for an alert template. 
        ///           "aggregates": "AVG",                            // The aggregation logic of the alert rule. Valid values: AVG, SUM, MIN, and MAX. 
        ///           "nValue": 1,                                    // The time range to query. 
        ///           "value": 1,                                     // The threshold of the condition. 
        ///           "operator": "CURRENT_GTE"                       // The operation logic of the condition. Valid values: CURRENT_GTE: greater than or equal to. CURRENT_LTE: less than or equal to. PREVIOUS_UP: the minute-to-minute increase percentage. PREVIOUS_DOWN: the minute-to-minute decrease percentage. HOH_UP: the increase percentage compared with the previous hour. HOH_DOWN: the decrease percentage compared with the previous hour. DOD_UP: the increase percentage compared with the last day. DOD_DOWN: the decrease percentage compared with the last day. 
        ///         }
        ///       ],
        ///       "operator": "|"                                    // The logical operator between conditions. Valid values: &: AND. |: OR. 
        ///     },
        ///     "title": "Template alert name",                              // The alert name. An alert rule name in the format of {title}-Application name is generated when ARMS creates the alert rule based on the alert template. 
        ///     "config": "{\"continuous\":false,\"dataRevision\":2,\"ownerId\":\"123412341234\"}",          // If the continuous parameter is set to true, ARMS sends alert notifications without interruption. If the continuous parameter is set to false, an alert silence period of 24 hours is enabled. The dataRevision parameter specifies the data revision policy to be used if no data is obtained or the data is null. Valid values: 0: overwrites the data by using the value 0. 1: overwrites the data by using the value 1. 2: overwrites the data by using the value null, which means that no alert is triggered if no data exists. 
        ///     "notice": {                                                                                  // The noticeStartTime and noticeEndTime parameters specify the time range when alert notifications are sent. The startTime and endTime parameters specify the time range when the alert rule takes effect. The values are UNIX timestamps in milliseconds. Each timestamp indicates a point in time on the current day. For example, the 1565964097071 timestamp indicates 22:01:37 on August 16, 2019. 
        ///       "noticeStartTime": 1480521600000,
        ///       "startTime": 1480521600000,
        ///       "endTime": 1480607940000,
        ///       "noticeEndTime": 1480607940000
        ///     },
        ///     "status": "NON"                                        // The status of the alert rule. You can ignore this parameter in the alert template configuration. The value is automatically generated when ARMS creates the alert rule based on the alert template. 
        ///   }
        /// ]
        ///             
        /// ```
        /// 
        /// **Description of the Measure, Dimension, and metricParam.type parameters**
        /// 
        /// The **metricParam.type** parameter specifies the unique type of each alert rule. Each type of alert rules can use a dimension for the conditions. Multiple conditions can be set for each type of alert rules. Each condition can use multiple metrics of the same type for calculation.****
        /// 
        /// The **Dimensions.type** parameter has the following valid values:
        /// 
        /// *   `STATIC`: checks only the value of this dimension. In this case, you must set the **dimensions.value** parameter.
        /// *   `ALL`: checks the values of all dimensions. The metrics of all API operations are checked. If an operation triggers an alert, the operation name is displayed in the alert notification. In this case, you do not need to set the **dimensions.value** parameter.
        /// *   `DISABLE`: aggregates the values of all dimensions. In this case, you do not need to set the **dimensions.value** parameter.
        /// 
        /// **Alert metrics**
        /// 
        /// *   Alert type (metricParam.type): TXN
        /// 
        ///     *   Dimension (dimensions.key): rpc
        /// 
        ///     *   Metrics (alertRule.rules.measure):
        /// 
        ///         *   appstat.txn.rt: the response time of API calls in milliseconds
        ///         *   appstat.txn.count: the number of API calls
        ///         *   appstat.txn.errcount: the number of API call errors
        /// 
        /// *   Alert type (metricParam.type): TXN_TYPE
        /// 
        ///     *   Dimension (dimensions.key): rpcType
        /// 
        ///     *   Metrics (alertRule.rules.measure):
        /// 
        ///         *   appstat.incall.rt: the response time of API calls for the services that are provided by the application, in milliseconds
        ///         *   appstat.incall.count: the number of API calls for the services that are provided by the application
        ///         *   appstat.incall.error: the number of API call errors for the services that are provided by the application
        ///         *   appstat.outcall.rt: the response time of API calls for the services on which the application depends, in milliseconds
        ///         *   appstat.outcall.count: the number of API calls for the services on which the application depends
        ///         *   appstat.outcall.error: the number of API call errors for the services on which the application depends
        /// 
        /// *   Alert type (metricParam.type): DB
        /// 
        ///     *   Dimension (dimensions.key): endpoint
        /// 
        ///     *   Metrics (alertRule.rules.measure):
        /// 
        ///         *   appstat.database.rt: the response time of API calls for the database
        ///         *   appstat.database.count: the number of API calls for the database
        ///         *   appstat.database.errcount: the number of API call errors for the database
        /// 
        /// *   Alert type (metricParam.type): JVM
        /// 
        ///     *   Dimension (dimensions.key): rootIp
        /// 
        ///     *   Metrics (alertRule.rules.measure):
        /// 
        ///         *   appstat.jvm.heap_used: the total memory space in the JVM heap, in bytes
        ///         *   appstat.jvm.GcPsScavengeCount: the number of garbage collections (GCs) in JVM
        ///         *   appstat.jvm.GcPsMarkSweepCount: the number of tag deletions in JVM
        ///         *   appstat.jvm.GcG1OldGenCount: the number of Garbage-First (G1) GCs in the old generation
        ///         *   appstat.jvm.GcG1YoungGenCount: the number of G1 GCs in the young generation
        ///         *   appstat.jvm.gc.YoungGcCountInstant: the number of GCs in the young generation
        ///         *   appstat.jvm.gc.OldGcCountInstant: the number of full heap GCs (Full GCs) in JVM
        ///         *   appstat.jvm.gc.YoungGcTimeInstant: the time that is consumed for the GCs in the young generation, in milliseconds
        ///         *   appstat.jvm.gc.OldGcTimeInstant: the time that is consumed for the Full GCs in JVM, in milliseconds
        ///         *   appstat.jvm.ThreadCount: the total number of JVM threads
        ///         *   appstat.jvm.non_heap_used: the used space of the non-heap JVM memory, in bytes
        ///         *   appstat.jvm.non_heap_max: the maximum space of the non-heap JVM memory, in bytes
        ///         *   appstat.jvm.non_heap_init: the initial space of the non-heap JVM memory, in bytes
        ///         *   appstat.jvm.non_heap_committed: the submitted space of the non-heap JVM memory, in bytes
        /// 
        /// *   Alert type (metricParam.type): HOST
        /// 
        ///     *   Dimension (dimensions.key): rootIp
        /// 
        ///     *   Metrics (alertRule.rules.measure):
        /// 
        ///         *   appstat.jvm.SystemCpuUser: the used CPU of the host, in percentage
        ///         *   appstat.jvm.SystemMemFree: the idle memory space of the host, in bytes
        ///         *   appstat.jvm.SystemDiskFree: the idle disk space of the host, in bytes
        ///         *   appstat.jvm.SystemNetInErrs: the number of error messages that is received by the host
        ///         *   appstat.jvm.SystemNetOutErrs: the number of error messages that is sent by the host
        ///         *   appstat.jvm.SystemLoad: the system load of the host
        /// 
        /// *   Alert type (metricParam.type): EXCEPTION
        /// 
        ///     *   Dimension (dimensions.key): rpc
        /// 
        ///     *   Metrics (alertRule.rules.measure):
        /// 
        ///         *   appstat.exception.rt: the response time of abnormal API calls for the application, in milliseconds
        ///         *   appstat.exception.count: the number of abnormal API calls for the application
        /// </summary>
        [NameInMap("ContactGroupIds")]
        [Validation(Required=false)]
        public string ContactGroupIds { get; set; }

        [NameInMap("IsAutoStart")]
        [Validation(Required=false)]
        public bool? IsAutoStart { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ImportAppAlertRules**.
        /// </summary>
        [NameInMap("Pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

        /// <summary>
        /// Specifies whether to enable the alert rule after it is created. Default value: `false`.
        /// 
        /// *   `true`: enables the alert rule.
        /// *   `false`: disables the alert rule.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ImportAppAlertRulesRequestTags> Tags { get; set; }
        public class ImportAppAlertRulesRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TemplageAlertConfig")]
        [Validation(Required=false)]
        public string TemplageAlertConfig { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("TemplateAlertId")]
        [Validation(Required=false)]
        public string TemplateAlertId { get; set; }

    }

}
