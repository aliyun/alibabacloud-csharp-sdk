// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDisposeStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDisposeStrategyResponseBodyData Data { get; set; }
        public class ListDisposeStrategyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Paging information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListDisposeStrategyResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListDisposeStrategyResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>Current page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>Number of entries returned per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>Total number of entries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>Detailed data.</para>
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListDisposeStrategyResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListDisposeStrategyResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <para>Alert UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// <para>SIEM root account ID associated with the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127608589417****</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// <para>Strategy status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: disabled</para>
                /// </description></item>
                /// <item><description><para>1: enabled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EffectiveStatus")]
                [Validation(Required=false)]
                public int? EffectiveStatus { get; set; }

                /// <summary>
                /// <para>Entity details in JSON array format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;ip&quot;:&quot;1.1.1.1&quot;}]</para>
                /// </summary>
                [NameInMap("Entity")]
                [Validation(Required=false)]
                public List<object> Entity { get; set; }

                /// <summary>
                /// <para>Entity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// <para>Entity type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>ip</para>
                /// </description></item>
                /// <item><description><para>process</para>
                /// </description></item>
                /// <item><description><para>file</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>Summary of task failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DisposalEntity failed which description is Aegis Quarantine File , return_info failed which description is Check Aegis Process Result , [ERROR DETAIL] *******.php:file not found</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>Task completion time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-10 21:34:07</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Last modified time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Strategy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Multiple type of alerts, including Miner Network, Command line download and run malicious files, Backdoor Process, etc</para>
                /// </summary>
                [NameInMap("IncidentName")]
                [Validation(Required=false)]
                public string IncidentName { get; set; }

                /// <summary>
                /// <para>Global unique UUID of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// <para>Unique name of the playbook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WafBlockIP</para>
                /// </summary>
                [NameInMap("PlaybookName")]
                [Validation(Required=false)]
                public string PlaybookName { get; set; }

                /// <summary>
                /// <para>Playbook type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>system: manual disposal</para>
                /// </description></item>
                /// <item><description><para>custom: event-triggered playbook</para>
                /// </description></item>
                /// <item><description><para>custom_alert: alert-triggered playbook</para>
                /// </description></item>
                /// <item><description><para>soar-manual: manually run playbook</para>
                /// </description></item>
                /// <item><description><para>soar-mdr: MDR-run playbook</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("PlaybookType")]
                [Validation(Required=false)]
                public string PlaybookType { get; set; }

                /// <summary>
                /// <para>UUID of the playbook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system_aliyun_clb_process_book</para>
                /// </summary>
                [NameInMap("PlaybookUuid")]
                [Validation(Required=false)]
                public string PlaybookUuid { get; set; }

                /// <summary>
                /// <para>Disposal scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{ aliUid: 1766185894104675 }]</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public List<object> Scope { get; set; }

                /// <summary>
                /// <para>ID of the security orchestration and automated response disposal strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>577bbf90-a770-44a7-8154-586aa2d3****</para>
                /// </summary>
                [NameInMap("SophonTaskId")]
                [Validation(Required=false)]
                public string SophonTaskId { get; set; }

                /// <summary>
                /// <para>Playbook invocation status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>200: succeeded</para>
                /// </description></item>
                /// <item><description><para>10: deleted</para>
                /// </description></item>
                /// <item><description><para>5: failed</para>
                /// </description></item>
                /// <item><description><para>0: initial state</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID associated with the configuration policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176555323***</para>
                /// </summary>
                [NameInMap("SubAliuid")]
                [Validation(Required=false)]
                public long? SubAliuid { get; set; }

                /// <summary>
                /// <para>Parameters used to trigger the playbook, in JSON format.</para>
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
                /// <para>Playbook URL.</para>
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
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
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
