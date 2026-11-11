// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDisposeStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDisposeStrategyResponseBodyData Data { get; set; }
        public class ListDisposeStrategyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of response record groups.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<ListDisposeStrategyResponseBodyDataGroups> Groups { get; set; }
            public class ListDisposeStrategyResponseBodyDataGroups : TeaModel {
                /// <summary>
                /// <para>The number of failed response records in the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                /// <summary>
                /// <para>The first occurrence time of the response records in the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FirstOccurrenceTime")]
                [Validation(Required=false)]
                public long? FirstOccurrenceTime { get; set; }

                /// <summary>
                /// <para>The grouping dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Strategy</para>
                /// </summary>
                [NameInMap("GroupBy")]
                [Validation(Required=false)]
                public string GroupBy { get; set; }

                /// <summary>
                /// <para>The grouping key value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fedcba9876543210fedcba9876543210</para>
                /// </summary>
                [NameInMap("GroupKey")]
                [Validation(Required=false)]
                public string GroupKey { get; set; }

                /// <summary>
                /// <para>The group metadata.</para>
                /// </summary>
                [NameInMap("GroupMeta")]
                [Validation(Required=false)]
                public ListDisposeStrategyResponseBodyDataGroupsGroupMeta GroupMeta { get; set; }
                public class ListDisposeStrategyResponseBodyDataGroupsGroupMeta : TeaModel {
                    /// <summary>
                    /// <para>The group information.</para>
                    /// </summary>
                    [NameInMap("GroupInfo")]
                    [Validation(Required=false)]
                    public object GroupInfo { get; set; }

                }

                /// <summary>
                /// <para>The name of the response record group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Automatic response rule</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The group title.</para>
                /// </summary>
                [NameInMap("GroupTitle")]
                [Validation(Required=false)]
                public string GroupTitle { get; set; }

                /// <summary>
                /// <para>The last occurrence time of handling records in the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LastOccurrenceTime")]
                [Validation(Required=false)]
                public long? LastOccurrenceTime { get; set; }

                /// <summary>
                /// <para>The latest modification time of handling records in the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LatestModifiedTime")]
                [Validation(Required=false)]
                public long? LatestModifiedTime { get; set; }

                /// <summary>
                /// <para>The number of in-progress response records in the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RunningCount")]
                [Validation(Required=false)]
                public long? RunningCount { get; set; }

                /// <summary>
                /// <para>The number of successful response records in the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

                /// <summary>
                /// <para>The total number of response records in the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListDisposeStrategyResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListDisposeStrategyResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The current page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of records per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The detailed data.</para>
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListDisposeStrategyResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListDisposeStrategyResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <para>The name of the associated alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// <para>The alert UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// <para>The ID of the SIEM primary account associated with the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127608589417****</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// <para>The status of the policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: invalid</description></item>
                /// <item><description>1: valid</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EffectiveStatus")]
                [Validation(Required=false)]
                public int? EffectiveStatus { get; set; }

                /// <summary>
                /// <para>The entity details in JSON array format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;ip&quot;:&quot;1.1.1.1&quot;}]</para>
                /// </summary>
                [NameInMap("Entity")]
                [Validation(Required=false)]
                public List<object> Entity { get; set; }

                /// <summary>
                /// <para>The entity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// <para>The type of the entity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ip: IP address</description></item>
                /// <item><description>process: process</description></item>
                /// <item><description>file: file</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The error code of the response task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>python.Internal.Params</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The failure summary of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DisposalEntity failed which description is Aegis Quarantine File , return_info failed which description is Check Aegis Process Result , [ERROR DETAIL] *******.php:file not found</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The end time of the task. Format: YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-10 21:34:07</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The incident name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Multiple type of alerts, including Miner Network, Command line download and run malicious files, Backdoor Process, etc</para>
                /// </summary>
                [NameInMap("IncidentName")]
                [Validation(Required=false)]
                public string IncidentName { get; set; }

                /// <summary>
                /// <para>The globally unique UUID of the incident.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// <para>The unique name of the playbook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WafBlockIP</para>
                /// </summary>
                [NameInMap("PlaybookName")]
                [Validation(Required=false)]
                public string PlaybookName { get; set; }

                /// <summary>
                /// <para>The type of the playbook. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: manual response</description></item>
                /// <item><description>custom: event-triggered playbook</description></item>
                /// <item><description>custom_alert: alert-triggered playbook</description></item>
                /// <item><description>soar-manual: manually run playbook</description></item>
                /// <item><description>soar-mdr: MDR-run playbook</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("PlaybookType")]
                [Validation(Required=false)]
                public string PlaybookType { get; set; }

                /// <summary>
                /// <para>The UUID of the playbook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system_aliyun_clb_process_book</para>
                /// </summary>
                [NameInMap("PlaybookUuid")]
                [Validation(Required=false)]
                public string PlaybookUuid { get; set; }

                /// <summary>
                /// <para>The response scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{ aliUid: 1766185894104675 }]</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public List<object> Scope { get; set; }

                /// <summary>
                /// <para>The ID of the Security Orchestration, Automation, and Response (SOAR) response policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>577bbf90-a770-44a7-8154-586aa2d3****</para>
                /// </summary>
                [NameInMap("SophonTaskId")]
                [Validation(Required=false)]
                public string SophonTaskId { get; set; }

                /// <summary>
                /// <para>The playbook invocation status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>200: successful</description></item>
                /// <item><description>10: deleted</description></item>
                /// <item><description>5: failed</description></item>
                /// <item><description>0: initial status</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that configured the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176555323***</para>
                /// </summary>
                [NameInMap("SubAliuid")]
                [Validation(Required=false)]
                public long? SubAliuid { get; set; }

                /// <summary>
                /// <para>The playbook trigger parameters in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///       &quot;file&quot;: {
                ///             &quot;op_code&quot;: &quot;2&quot;,
                ///             &quot;file_path&quot;: &quot;/root/alert0913/a886.jsp&quot;,
                ///             &quot;entity_type&quot;: &quot;file&quot;,
                ///             &quot;entity_name&quot;: &quot;a886.jsp&quot;,
                ///             &quot;file_name&quot;: &quot;a886.jsp&quot;,
                ///             &quot;file_owner&quot;: &quot;USER:,GROUP:&quot;,
                ///             &quot;hash_value&quot;: &quot;5def10c9a4287d0920d86b42420b20b0&quot;,
                ///             &quot;op_level&quot;: &quot;2&quot;,
                ///             &quot;entity_id&quot;: &quot;/root/alert0913/a886.jsp&quot;,
                ///             &quot;host_uuid&quot;: {
                ///                   &quot;entity_type&quot;: &quot;host&quot;,
                ///                   &quot;entity_name&quot;: &quot;N/A&quot;,
                ///                   &quot;is_comprised&quot;: &quot;1&quot;,
                ///                   &quot;os_type&quot;: &quot;linux&quot;,
                ///                   &quot;entity_id&quot;: &quot;5f58ef67-8803-4314-8d67-c87dc92b****&quot;,
                ///                   &quot;host_uuid&quot;: &quot;5f58ef67-8803-4314-8d67-c87dc92b****&quot;,
                ///                   &quot;host_name&quot;: &quot;N/A&quot;
                ///             },
                ///             &quot;malware_type&quot;: &quot;${aliyun.siem.sas.alert_tag.webshell}&quot;
                ///       },
                ///       &quot;_sys_siem&quot;: {
                ///             &quot;cloudCode&quot;: &quot;aliyun&quot;,
                ///             &quot;alertId&quot;: &quot;89416745494****&quot;
                ///       },
                ///       &quot;scope&quot;: [
                ///             {
                ///                   &quot;aliUid&quot;: 1766185894104****
                ///             }
                ///       ]
                /// }</para>
                /// </summary>
                [NameInMap("TaskParam")]
                [Validation(Required=false)]
                public string TaskParam { get; set; }

                /// <summary>
                /// <para>The playbook URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;playbookUuid&quot;:&quot;system_aliyun_aegis_stop_container_book&quot;,&quot;requestUuid&quot;:&quot;e8924356-448b-4301-aee9-*******&quot;}</para>
                /// </summary>
                [NameInMap("TaskUrl")]
                [Validation(Required=false)]
                public string TaskUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: successful</description></item>
        /// <item><description>false: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
