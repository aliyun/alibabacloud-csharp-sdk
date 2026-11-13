// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListEntitiesResponseBody : TeaModel {
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
        public ListEntitiesResponseBodyData Data { get; set; }
        public class ListEntitiesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListEntitiesResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListEntitiesResponseBodyDataPageInfo : TeaModel {
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
                /// <para>The number of entries returned per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of entries.</para>
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
            public List<ListEntitiesResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListEntitiesResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>The file contains a classic PHP Webshell payload (eval($_POST[cmd])) confirmed by threat intelligence and AI investigation as part of a persistent attack chain</para>
                /// </summary>
                [NameInMap("AgentAnalysisReason")]
                [Validation(Required=false)]
                public string AgentAnalysisReason { get; set; }

                /// <summary>
                /// <para>The confidence level of the entity evaluation by the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("AgentConfidence")]
                [Validation(Required=false)]
                public string AgentConfidence { get; set; }

                /// <summary>
                /// <para>The remediation method recommended by the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>delete_file</para>
                /// </summary>
                [NameInMap("AgentDisposalMethod")]
                [Validation(Required=false)]
                public string AgentDisposalMethod { get; set; }

                /// <summary>
                /// <para>The UUID of the remediation playbook recommended by the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12XAD-SFQ-WAF-2ca2</para>
                /// </summary>
                [NameInMap("AgentDisposalPlaybookUuid")]
                [Validation(Required=false)]
                public string AgentDisposalPlaybookUuid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>The file is a malicious backdoor located in the root directory with no business legitimacy; immediate quarantine via the Security Center playbook is safe and necessary</para>
                /// </summary>
                [NameInMap("AgentDisposalReason")]
                [Validation(Required=false)]
                public string AgentDisposalReason { get; set; }

                /// <summary>
                /// <para>The remediation suggestions provided by the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("AgentDisposalSuggestion")]
                [Validation(Required=false)]
                public string AgentDisposalSuggestion { get; set; }

                /// <summary>
                /// <para>The list of remediation suggestions provided by the agent.</para>
                /// </summary>
                [NameInMap("AgentDisposes")]
                [Validation(Required=false)]
                public List<ListEntitiesResponseBodyDataResponseDataAgentDisposes> AgentDisposes { get; set; }
                public class ListEntitiesResponseBodyDataResponseDataAgentDisposes : TeaModel {
                    /// <summary>
                    /// <para>The remediation method recommended by the agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("AgentDisposalMethod")]
                    [Validation(Required=false)]
                    public string AgentDisposalMethod { get; set; }

                    /// <summary>
                    /// <para>The UUID of the remediation playbook recommended by the agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12XAD-SFQ-WAF-2ca2</para>
                    /// </summary>
                    [NameInMap("AgentDisposalPlaybookUuid")]
                    [Validation(Required=false)]
                    public string AgentDisposalPlaybookUuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>The file is a malicious backdoor located in the root directory with no business legitimacy; immediate quarantine via the Security Center playbook is safe and necessary</para>
                    /// </summary>
                    [NameInMap("AgentDisposalReason")]
                    [Validation(Required=false)]
                    public string AgentDisposalReason { get; set; }

                }

                /// <summary>
                /// <para>The number of alerts associated with the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlertNum")]
                [Validation(Required=false)]
                public int? AlertNum { get; set; }

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
                /// <para>The Alibaba Cloud account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789****</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// <para>The code of the source cloud for the entity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>aliyun: Alibaba Cloud.</description></item>
                /// <item><description>qcloud: Tencent Cloud.</description></item>
                /// <item><description>hcloud: Huawei Cloud.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                /// <summary>
                /// <para>The logical ID of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345****</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The display information of the entity in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;file_path&quot;: &quot;c:/www/leixi.jsp&quot;,&quot;file_hash&quot;: &quot;aa0ca926ad948cd820e0a3d9a18c****&quot;,&quot;host_uuid&quot;: &quot;efed2cf7-0b77-45d9-a97b-d2cf246b****&quot;,&quot;malware_type&quot;: &quot;${aliyun.siem.sas.alert_tag.webshell}&quot;,&quot;host_name&quot;: &quot;launch-advisor-2023****&quot;}</para>
                /// </summary>
                [NameInMap("EntityInfo")]
                [Validation(Required=false)]
                public string EntityInfo { get; set; }

                /// <summary>
                /// <para>The entity name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123.123.123.123</para>
                /// </summary>
                [NameInMap("EntityName")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                /// <summary>
                /// <para>The entity type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ip: IP address</description></item>
                /// <item><description>domain: Domain name</description></item>
                /// <item><description>url: URL</description></item>
                /// <item><description>process: Process</description></item>
                /// <item><description>file: File</description></item>
                /// <item><description>host: Host</description></item>
                /// <item><description>cloud_account: Cloud account</description></item>
                /// <item><description>container: Container</description></item>
                /// <item><description>bucket: OSS bucket</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The entity UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8087b3e4aa6862852c100c8738cf****</para>
                /// </summary>
                [NameInMap("EntityUuid")]
                [Validation(Required=false)]
                public string EntityUuid { get; set; }

                /// <summary>
                /// <para>The number of events associated with the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EventNum")]
                [Validation(Required=false)]
                public int? EventNum { get; set; }

                /// <summary>
                /// <para>The time when the entity was collected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the entity was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The entity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789***</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The incident UUID, which can be obtained from the incident list API operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// <para>Indicates whether the entity is an asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: No.</description></item>
                /// <item><description>1: Yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsAsset")]
                [Validation(Required=false)]
                public string IsAsset { get; set; }

                /// <summary>
                /// <para>Indicates whether the entity is malicious. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: No.</description></item>
                /// <item><description>1: Yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsMalware")]
                [Validation(Required=false)]
                public string IsMalware { get; set; }

                /// <summary>
                /// <para>The malware type of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun.siem.sas.alert_tag.webshell</para>
                /// </summary>
                [NameInMap("MalwareType")]
                [Validation(Required=false)]
                public string MalwareType { get; set; }

                /// <summary>
                /// <para>The ID of the account associated with the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>113091674488****</para>
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

                /// <summary>
                /// <para>The entity tags. The format is a JSON array string:</para>
                /// <para><c>&quot;[{&quot;tagKey1&quot;:&quot;tagValue1&quot;},{&quot;tagKey2&quot;:&quot;tagValue2&quot;}]&quot;</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;tagKey1&quot;:&quot;tagValue1&quot;},{&quot;tagKey2&quot;:&quot;tagValue2&quot;}]</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

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
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
