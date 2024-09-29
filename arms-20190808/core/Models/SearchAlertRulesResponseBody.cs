// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchAlertRulesResponseBodyPageBean PageBean { get; set; }
        public class SearchAlertRulesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The details of the alert rules.</para>
            /// </summary>
            [NameInMap("AlertRules")]
            [Validation(Required=false)]
            public List<SearchAlertRulesResponseBodyPageBeanAlertRules> AlertRules { get; set; }
            public class SearchAlertRulesResponseBodyPageBeanAlertRules : TeaModel {
                /// <summary>
                /// <para>The format of the alert notification.</para>
                /// </summary>
                [NameInMap("AlarmContext")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesAlarmContext AlarmContext { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlarmContext : TeaModel {
                    /// <summary>
                    /// <para>The sub-title of the alert notification content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestSubTitle</para>
                    /// </summary>
                    [NameInMap("AlarmContentSubTitle")]
                    [Validation(Required=false)]
                    public string AlarmContentSubTitle { get; set; }

                    /// <summary>
                    /// <para>The template of the alert notification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alert name: $Alert name\nFilter condition: $Filter\nAlert time: $Alert time\nAlert content: $Alert content\nNote: The alert persists until a reply email is received. The system will remind you again in 24 hours.</para>
                    /// </summary>
                    [NameInMap("AlarmContentTemplate")]
                    [Validation(Required=false)]
                    public string AlarmContentTemplate { get; set; }

                    /// <summary>
                    /// <para>The content of the alert notification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alert name: $Alert name\nFilter condition: $Filter\nAlert time: $Alert time\nAlert content: $Alert content\nNote: The alert persists until a reply email is received. The system will remind you again in 24 hours.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The sub-title of the alert notification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SubTitle")]
                    [Validation(Required=false)]
                    public string SubTitle { get; set; }

                }

                /// <summary>
                /// <para>The severity of the alerts. Only the value <c>WARN</c> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WARN</para>
                /// </summary>
                [NameInMap("AlertLevel")]
                [Validation(Required=false)]
                public string AlertLevel { get; set; }

                /// <summary>
                /// <para>The conditions of the alert rule. Multiple conditions are separated by the AND or OR logical operators.</para>
                /// </summary>
                [NameInMap("AlertRule")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRule AlertRule { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRule : TeaModel {
                    /// <summary>
                    /// <para>The logical operator between conditions. Valid values: <c>&amp;</c>: AND. <c>|</c>: OR.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>|</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The condition of the alert rule.</para>
                    /// </summary>
                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public List<SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRuleRules> Rules { get; set; }
                    public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRuleRules : TeaModel {
                        /// <summary>
                        /// <para>The aggregation logic of the metric data of the alert rule. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>AVG</c>: calculates the average value for each minute</description></item>
                        /// <item><description><c>SUM</c>: calculates the total value for each minute</description></item>
                        /// <item><description><c>MAX</c>: calculates the maximum value for each minute</description></item>
                        /// <item><description><c>MIN</c>: calculates the minimum value for each minute</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AVG</para>
                        /// </summary>
                        [NameInMap("Aggregates")]
                        [Validation(Required=false)]
                        public string Aggregates { get; set; }

                        /// <summary>
                        /// <para>The displayed description of the alert metric.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>response time_ms</para>
                        /// </summary>
                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        /// <summary>
                        /// <para>The metric based on which alerts are triggered. For more information, see the &quot;<a href="https://help.aliyun.com/document_detail/175825.html#h2-url-4">Alert metrics</a>&quot; section in this topic.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>appstat.jvm.SystemDiskFree</para>
                        /// </summary>
                        [NameInMap("Measure")]
                        [Validation(Required=false)]
                        public string Measure { get; set; }

                        /// <summary>
                        /// <para>The time range when data is requested. Unit: minutes. For example, a value of 5 indicates that the alert rule applies to the data in the last 5 minutes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("NValue")]
                        [Validation(Required=false)]
                        public int? NValue { get; set; }

                        /// <summary>
                        /// <para>The operation logic of the condition. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>CURRENT_GTE: greater than or equal to</description></item>
                        /// <item><description>CURRENT_LTE: less than or equal to</description></item>
                        /// <item><description>PREVIOUS_UP: the increase percentage compared with the last period</description></item>
                        /// <item><description>PREVIOUS_DOWN: the decrease percentage compared with the last period</description></item>
                        /// <item><description>HOH_UP: the increase percentage compared with the last hour</description></item>
                        /// <item><description>HOH_DOWN: the decrease percentage compared with the last hour</description></item>
                        /// <item><description>DOD_UP: the increase percentage compared with the last day</description></item>
                        /// <item><description>DOD_DOWN: the decrease percentage compared with the last day</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CURRENT_GTE</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The threshold of the condition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public float? Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestAlertRule</para>
                /// </summary>
                [NameInMap("AlertTitle")]
                [Validation(Required=false)]
                public string AlertTitle { get; set; }

                /// <summary>
                /// <para>The type of the alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>1</c>: custom alert rules that are used to monitor drill-down data sets</description></item>
                /// <item><description><c>3</c>: custom alert rules that are used to monitor tiled data sets</description></item>
                /// <item><description><c>4</c>: alert rules that are used to monitor the browser, including the default frontend alert rules</description></item>
                /// <item><description><c>5</c>: alert rules that are used to monitor applications, including the default application alert rules</description></item>
                /// <item><description><c>6</c>: the default browser alert rules</description></item>
                /// <item><description><c>7</c>: the default application alert rules</description></item>
                /// <item><description><c>8</c>: Tracing Analysis alert rules</description></item>
                /// <item><description><c>101</c>: Prometheus alert rules</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public int? AlertType { get; set; }

                /// <summary>
                /// <para>The version of the alert rule. Default value: <c>1</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlertVersion")]
                [Validation(Required=false)]
                public int? AlertVersion { get; set; }

                /// <summary>
                /// <para>Sending method of alarm notification.</para>
                /// </summary>
                [NameInMap("AlertWays")]
                [Validation(Required=false)]
                public List<string> AlertWays { get; set; }

                /// <summary>
                /// <para>The configuration items of the alert rule. The value is a JSON string.</para>
                /// <para>The configuration item <b>continuous</b> indicates whether alert notifications are continuously sent. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Alert notifications are sent every minute.</description></item>
                /// <item><description><c>false</c>: The alert silence feature is enabled.</description></item>
                /// </list>
                /// <para>The configuration item <b>dataRevision</b> indicates the data revision policy that is used if no data is obtained or the data is null. Default value: 2. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>0</c>: overwrites the data by using the value 0</description></item>
                /// <item><description><c>1</c>: overwrites the data by using the value 1</description></item>
                /// <item><description><c>2</c>: overwrites the data by using the value null. This value indicates that no alert is triggered if no data exists</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;continuous\&quot;:true,\&quot;dataRevision\&quot;:2}</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The ID of the contact group. Multiple IDs are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>381*,572*</para>
                /// </summary>
                [NameInMap("ContactGroupIdList")]
                [Validation(Required=false)]
                public string ContactGroupIdList { get; set; }

                /// <summary>
                /// <para>The IDs of the alert contact groups. The value is a JSON array.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[123, 234]</para>
                /// </summary>
                [NameInMap("ContactGroupIds")]
                [Validation(Required=false)]
                public string ContactGroupIds { get; set; }

                /// <summary>
                /// <para>The timestamp that shows when the alert rule was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1579508519683</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert is sent through the alert center. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c></description></item>
                /// <item><description><c>false</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HostByAlertManager")]
                [Validation(Required=false)]
                public bool? HostByAlertManager { get; set; }

                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The information about the application that is associated with the alert rule.</para>
                /// </summary>
                [NameInMap("MetricParam")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParam MetricParam { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParam : TeaModel {
                    /// <summary>
                    /// <para>The ID of the application group that is associated with the alert rule. This parameter is applicable to Enterprise Distributed Application Service (EDAS) applications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEFAULT</para>
                    /// </summary>
                    [NameInMap("AppGroupId")]
                    [Validation(Required=false)]
                    public string AppGroupId { get; set; }

                    /// <summary>
                    /// <para>The auto-increment ID of the ARMS application. You can ignore this ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The dimensions in the condition.</para>
                    /// </summary>
                    [NameInMap("Dimensions")]
                    [Validation(Required=false)]
                    public List<SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParamDimensions> Dimensions { get; set; }
                    public class SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParamDimensions : TeaModel {
                        /// <summary>
                        /// <para>The key of the dimension. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>rpc</c>: the name of the API</description></item>
                        /// <item><description><c>rpcType</c>: the type of the API call, such as HTTP or DUBBO</description></item>
                        /// <item><description><c>endpoint</c>: the name of the database</description></item>
                        /// <item><description><c>rootIp</c>: the IP address of the host</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rootIp</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The type of the dimension. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>STATIC</c>: checks only the value of this dimension. In this case, you must set the <b>dimensions.value</b> parameter.</description></item>
                        /// <item><description><c>ALL</c>: checks the values of all dimensions. The metrics of all API calls are checked. If an API call triggers an alert, the name of the API is displayed in the alert notification. In this case, you do not need to set the <b>dimensions.value</b> parameter.</description></item>
                        /// <item><description><c>DISABLE</c>: aggregates the values of all dimensions. In this case, you do not need to set the <b>dimensions.value</b> parameter.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DISABLE</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The value of the dimension.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;127.0.0.1&quot;</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The PID of the application that is associated with the alert rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9870ca99-8105-4da7-a3a4-d72dd1b1****</para>
                    /// </summary>
                    [NameInMap("Pid")]
                    [Validation(Required=false)]
                    public string Pid { get; set; }

                    /// <summary>
                    /// <para>The type of the metric. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>txn</c>: the number of API calls during application monitoring</description></item>
                    /// <item><description><c>txn_type</c>: the types of API calls during application monitoring</description></item>
                    /// <item><description><c>db</c>: database metrics</description></item>
                    /// <item><description><c>jvm</c>: Java virtual machine (JVM) metrics</description></item>
                    /// <item><description><c>host</c>: host metrics</description></item>
                    /// <item><description><c>exception</c>: API call errors</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DB</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The time ranges when the alert rule takes effect and when alert notifications are sent.</para>
                /// </summary>
                [NameInMap("Notice")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesNotice Notice { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesNotice : TeaModel {
                    /// <summary>
                    /// <para>The end of the time range when the alert rule takes effect within 24 hours per day. This value is a UNIX timestamp. The year, month, and day that are indicated by the timestamp are not displayed in this value. Only the hour, minute, and second are displayed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1480607940000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The end of the time range when alert notifications are sent based on the alert rule within 24 hours per day. This value is a UNIX timestamp. The year, month, and day that are indicated by the timestamp are not displayed in this value. Only the hour, minute, and second are displayed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1480607940000</para>
                    /// </summary>
                    [NameInMap("NoticeEndTime")]
                    [Validation(Required=false)]
                    public long? NoticeEndTime { get; set; }

                    /// <summary>
                    /// <para>The beginning of the time range when alert notifications are sent based on the alert rule within 24 hours per day. This value is a UNIX timestamp. The year, month, and day that are indicated by the timestamp are not displayed in this value. Only the hour, minute, and second are displayed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1480521600000</para>
                    /// </summary>
                    [NameInMap("NoticeStartTime")]
                    [Validation(Required=false)]
                    public long? NoticeStartTime { get; set; }

                    /// <summary>
                    /// <para>The beginning of the time range when the alert rule takes effect within 24 hours per day. This value is a UNIX timestamp. The year, month, and day that are indicated by the timestamp are not displayed in this value. Only the hour, minute, and second are displayed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1480521600000</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                /// <summary>
                /// <para>The ID of the region to which the alert rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxyexli2****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The status of the alert rule. <c>RUNNING</c>: The alert rule is enabled. <c>STOPPED</c>: The alert rule is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the Application Real-Time Monitoring Service (ARMS) task that is associated with the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>The status of the task. This parameter is hidden from users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// <para>The name of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AlertTest</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The timestamp that shows when the alert rule was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1480521600000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the user to which the alert rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>113197164949****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34ED024E-9E31-434A-9E4E-D9D15C3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
