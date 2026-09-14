// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertsWithEventResponseBody : TeaModel {
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
        /// <para>The request return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAlertsWithEventResponseBodyData Data { get; set; }
        public class DescribeAlertsWithEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeAlertsWithEventResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeAlertsWithEventResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The current page number of the list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of records returned per page.</para>
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
            public List<DescribeAlertsWithEventResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeAlertsWithEventResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <para>The alert description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The detection model found a suspicious Webshell file on your server, which may be a backdoor file implanted to maintain permissions after the attacker successfully invaded the website.</para>
                /// </summary>
                [NameInMap("AlertDesc")]
                [Validation(Required=false)]
                public string AlertDesc { get; set; }

                /// <summary>
                /// <para>The Medusa code of the alert description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>security_event_config.event_name.webshell</para>
                /// </summary>
                [NameInMap("AlertDescCode")]
                [Validation(Required=false)]
                public string AlertDescCode { get; set; }

                /// <summary>
                /// <para>The English description of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The detection model found a suspicious Webshell file on your server, which may be a backdoor file implanted to maintain permissions after the attacker successfully invaded the website.</para>
                /// </summary>
                [NameInMap("AlertDescEn")]
                [Validation(Required=false)]
                public string AlertDescEn { get; set; }

                /// <summary>
                /// <para>The alert details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;main_user_id&quot;: &quot;165295629792****&quot;;&quot;log_uuid_count&quot;: &quot;99&quot;;&quot;attack_ip&quot;: &quot;21.92.<em>.</em>&quot;}</para>
                /// </summary>
                [NameInMap("AlertDetail")]
                [Validation(Required=false)]
                public string AlertDetail { get; set; }

                /// <summary>
                /// <para>The alert details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("AlertInfoList")]
                [Validation(Required=false)]
                public List<DescribeAlertsWithEventResponseBodyDataResponseDataAlertInfoList> AlertInfoList { get; set; }
                public class DescribeAlertsWithEventResponseBodyDataResponseDataAlertInfoList : TeaModel {
                    /// <summary>
                    /// <para>The key of the alert detail attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>suspicious.wbd.wb.trojanpath</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The name of the alert detail.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Trojan Path</para>
                    /// </summary>
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    /// <summary>
                    /// <para>The value of the alert detail.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/root/test33.php</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public string Values { get; set; }

                }

                /// <summary>
                /// <para>The threat level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>serious: High.</description></item>
                /// <item><description>suspicious: Medium.</description></item>
                /// <item><description>remind: Low.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>remind</para>
                /// </summary>
                [NameInMap("AlertLevel")]
                [Validation(Required=false)]
                public string AlertLevel { get; set; }

                /// <summary>
                /// <para>The alert name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// <para>The Medusa code of the alert name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>security_event_config.event_name.webshell</para>
                /// </summary>
                [NameInMap("AlertNameCode")]
                [Validation(Required=false)]
                public string AlertNameCode { get; set; }

                /// <summary>
                /// <para>The alert name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertNameEn")]
                [Validation(Required=false)]
                public string AlertNameEn { get; set; }

                /// <summary>
                /// <para>The source product of the alert associated with the incident.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas</para>
                /// </summary>
                [NameInMap("AlertSrcProd")]
                [Validation(Required=false)]
                public string AlertSrcProd { get; set; }

                /// <summary>
                /// <para>The submodule of the source product of the alert associated with the incident.</para>
                /// 
                /// <b>Example:</b>
                /// <para>waf</para>
                /// </summary>
                [NameInMap("AlertSrcProdModule")]
                [Validation(Required=false)]
                public string AlertSrcProdModule { get; set; }

                /// <summary>
                /// <para>The alert status. Valid values: 0: Pending. 1: Handled. 2: Being handled. 3: Whitelisted, false positive, or rejected. 999: Unknown.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AlertStatus")]
                [Validation(Required=false)]
                public string AlertStatus { get; set; }

                /// <summary>
                /// <para>The alert title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scan-Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertTitle")]
                [Validation(Required=false)]
                public string AlertTitle { get; set; }

                /// <summary>
                /// <para>The English title of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scan-Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertTitleEn")]
                [Validation(Required=false)]
                public string AlertTitleEn { get; set; }

                /// <summary>
                /// <para>The alert type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scan</para>
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// <para>The Medusa code of the alert type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>security_event_config.event_name.webshellName</para>
                /// </summary>
                [NameInMap("AlertTypeCode")]
                [Validation(Required=false)]
                public string AlertTypeCode { get; set; }

                /// <summary>
                /// <para>The English alert type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scan</para>
                /// </summary>
                [NameInMap("AlertTypeEn")]
                [Validation(Required=false)]
                public string AlertTypeEn { get; set; }

                /// <summary>
                /// <para>The UUID of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// <para>The asset list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///       {
                ///             &quot;is_main_asset&quot;: &quot;1&quot;,
                ///             &quot;asset_name&quot;: &quot;47.245.<em>&quot;,
                ///             &quot;port&quot;: &quot;22&quot;,
                ///             &quot;ip&quot;: &quot;47.245.</em>&quot;,
                ///             &quot;asset_type&quot;: &quot;ip&quot;,
                ///             &quot;location&quot;: &quot;ap-southeast-1&quot;,
                ///             &quot;asset_id&quot;: &quot;47.245.*&quot;,
                ///             &quot;net_connect_dir&quot;: &quot;in&quot;
                ///       }
                /// ]</para>
                /// </summary>
                [NameInMap("AssetList")]
                [Validation(Required=false)]
                public string AssetList { get; set; }

                /// <summary>
                /// <para>The ATT&amp;CK attack technique tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T1595.002 Vulnerability Scanning</para>
                /// </summary>
                [NameInMap("AttCk")]
                [Validation(Required=false)]
                public string AttCk { get; set; }

                /// <summary>
                /// <para>The cloud code. Valid values:</para>
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
                /// <para>The detection rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dr-48zs4tk7qfd4rjd9****</para>
                /// </summary>
                [NameInMap("DetectionRuleId")]
                [Validation(Required=false)]
                public string DetectionRuleId { get; set; }

                /// <summary>
                /// <para>The time when the alert ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The entity details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;entity_user_id&quot;:&quot;198921674491****&quot;,&quot;entity_account_id&quot;:&quot;N/A&quot;,&quot;entity_uuid&quot;:&quot;6245f979d5dd9ef8dd19bdc72228****&quot;,&quot;entity_type&quot;:&quot;host&quot;,&quot;entity_name&quot;:&quot;zhh-test-20240409&quot;,&quot;is_comprised&quot;:&quot;1&quot;,&quot;os_type&quot;:&quot;linux&quot;,&quot;entity_id&quot;:&quot;a88f44dd-b8d4-4ded-831c-77a4835****&quot;,&quot;host_uuid&quot;:&quot;a88f44dd-b8d4-4ded-831c-77a4835****&quot;,&quot;host_name&quot;:&quot;zhh-test-2024****&quot;}]</para>
                /// </summary>
                [NameInMap("EntityList")]
                [Validation(Required=false)]
                public string EntityList { get; set; }

                /// <summary>
                /// <para>The extended information of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;main_user_id&quot;: &quot;165295629792****&quot;;&quot;log_uuid_count&quot;: &quot;99****&quot;}</para>
                /// </summary>
                [NameInMap("ExtendContent")]
                [Validation(Required=false)]
                public string ExtendContent { get; set; }

                /// <summary>
                /// <para>The time when the alert was stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the alert was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The unique ID of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

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
                /// <para>The alert investigation report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;agent_attack_confidence&quot;: 90, &quot;agent_judgement_category&quot;: &quot;false_positive&quot;, &quot;reason&quot;: &quot;The command line contains \&quot;mediacenter\&quot; which is a normal startup behavior of Lark (Feishu) client, and the process path is in the standard user installation directory.&quot;, &quot;start_time&quot;: 1774929064, &quot;end_time&quot;: 1774929071}</para>
                /// </summary>
                [NameInMap("InvestigationReport")]
                [Validation(Required=false)]
                public string InvestigationReport { get; set; }

                /// <summary>
                /// <para>Indicates whether the threat has been defended against. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Detected.</description></item>
                /// <item><description>1: Blocked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsDefend")]
                [Validation(Required=false)]
                public string IsDefend { get; set; }

                /// <summary>
                /// <para>The time when the alert was logged.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                /// <summary>
                /// <para>The UUID of the alert log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cfw_d12e285a-a042-4d7e-be89-f8a795ef****</para>
                /// </summary>
                [NameInMap("LogUuid")]
                [Validation(Required=false)]
                public string LogUuid { get; set; }

                /// <summary>
                /// <para>The ID of the SIEM primary account associated with the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127608589417****</para>
                /// </summary>
                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public long? MainUserId { get; set; }

                /// <summary>
                /// <para>The time when the alert occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("OccurTime")]
                [Validation(Required=false)]
                public string OccurTime { get; set; }

                /// <summary>
                /// <para>The product ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <para>The time when the alert first occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID that generated the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176555323***</para>
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID that generated the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176555323***</para>
                /// </summary>
                [NameInMap("SubUserName")]
                [Validation(Required=false)]
                public string SubUserName { get; set; }

                /// <summary>
                /// <para>The cloud code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>aliyun: Alibaba Cloud.</description></item>
                /// <item><description>qcloud: Tencent Cloud.</description></item>
                /// <item><description>hcloud: Huawei Cloud.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("VendorId")]
                [Validation(Required=false)]
                public string VendorId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request return message.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
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
