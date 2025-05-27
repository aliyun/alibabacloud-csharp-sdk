// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertsWithEntityResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAlertsWithEntityResponseBodyData Data { get; set; }
        public class DescribeAlertsWithEntityResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeAlertsWithEntityResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeAlertsWithEntityResponseBodyDataPageInfo : TeaModel {
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
                /// <para>The number of entries per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of entries returned.</para>
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
            public List<DescribeAlertsWithEntityResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeAlertsWithEntityResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// <para>The description of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The detection model found a suspicious Webshell file on your server, which may be a backdoor file implanted to maintain permissions after the attacker successfully invaded the website.</para>
                /// </summary>
                [NameInMap("AlertDesc")]
                [Validation(Required=false)]
                public string AlertDesc { get; set; }

                /// <summary>
                /// <para>The internal code of the alert description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>security_event_config.event_name.webshell</para>
                /// </summary>
                [NameInMap("AlertDescCode")]
                [Validation(Required=false)]
                public string AlertDescCode { get; set; }

                /// <summary>
                /// <para>The alert description in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The detection model found a suspicious Webshell file on your server, which may be a backdoor file implanted to maintain permissions after the attacker successfully invaded the website.</para>
                /// </summary>
                [NameInMap("AlertDescEn")]
                [Validation(Required=false)]
                public string AlertDescEn { get; set; }

                /// <summary>
                /// <para>The details of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;main_user_id&quot;: &quot;165295629792****&quot;;&quot;log_uuid_count&quot;: &quot;99&quot;;&quot;attack_ip&quot;: &quot;21.92.<em>.</em>&quot;}</para>
                /// </summary>
                [NameInMap("AlertDetail")]
                [Validation(Required=false)]
                public string AlertDetail { get; set; }

                /// <summary>
                /// <para>The displayed details of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("AlertInfoList")]
                [Validation(Required=false)]
                public List<DescribeAlertsWithEntityResponseBodyDataResponseDataAlertInfoList> AlertInfoList { get; set; }
                public class DescribeAlertsWithEntityResponseBodyDataResponseDataAlertInfoList : TeaModel {
                    /// <summary>
                    /// <para>The attribute key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>suspicious.wbd.wb.trojanpath</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The name of the key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Trojan Path</para>
                    /// </summary>
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    /// <summary>
                    /// <para>The value of the key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/root/test33.php</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public string Values { get; set; }

                }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>serious: high</description></item>
                /// <item><description>suspicious: medium</description></item>
                /// <item><description>remind: low</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>remind</para>
                /// </summary>
                [NameInMap("AlertLevel")]
                [Validation(Required=false)]
                public string AlertLevel { get; set; }

                /// <summary>
                /// <para>The name of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// <para>The internal code of the alert name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>security_event_config.event_name.webshell</para>
                /// </summary>
                [NameInMap("AlertNameCode")]
                [Validation(Required=false)]
                public string AlertNameCode { get; set; }

                /// <summary>
                /// <para>The name of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertNameEn")]
                [Validation(Required=false)]
                public string AlertNameEn { get; set; }

                /// <summary>
                /// <para>The source of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas</para>
                /// </summary>
                [NameInMap("AlertSrcProd")]
                [Validation(Required=false)]
                public string AlertSrcProd { get; set; }

                /// <summary>
                /// <para>The sub-module of the alert source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>waf</para>
                /// </summary>
                [NameInMap("AlertSrcProdModule")]
                [Validation(Required=false)]
                public string AlertSrcProdModule { get; set; }

                /// <summary>
                /// <para>The title of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scan-Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertTitle")]
                [Validation(Required=false)]
                public string AlertTitle { get; set; }

                /// <summary>
                /// <para>The alert title in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scan-Try SNMP weak password</para>
                /// </summary>
                [NameInMap("AlertTitleEn")]
                [Validation(Required=false)]
                public string AlertTitleEn { get; set; }

                /// <summary>
                /// <para>The type of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scan</para>
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// <para>The internal code of the alert type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>security_event_config.event_name.webshellName</para>
                /// </summary>
                [NameInMap("AlertTypeCode")]
                [Validation(Required=false)]
                public string AlertTypeCode { get; set; }

                /// <summary>
                /// <para>The alert type in English.</para>
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
                /// <para>The details of the asset.</para>
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
                /// <para>The tag of the ATT\&amp;CK attack.</para>
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
                /// <item><description>aliyun: Alibaba Cloud</description></item>
                /// <item><description>qcloud: Tencent Cloud</description></item>
                /// <item><description>hcloud: Huawei Cloud</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                /// <summary>
                /// <para>The time when the alert was closed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("EntityList")]
                [Validation(Required=false)]
                public string EntityList { get; set; }

                /// <summary>
                /// <para>The time when the alert was received.</para>
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
                /// <para>The UUID of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// <para>Specifies whether an attack is defended. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: detected</description></item>
                /// <item><description>1: blocked</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsDefend")]
                [Validation(Required=false)]
                public string IsDefend { get; set; }

                /// <summary>
                /// <para>The time when the alert was recorded.</para>
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
                /// <para>The ID of the Alibaba Cloud account that is associated with the alert in SIEM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127608589417****</para>
                /// </summary>
                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public long? MainUserId { get; set; }

                /// <summary>
                /// <para>The time when the alert was triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("OccurTime")]
                [Validation(Required=false)]
                public string OccurTime { get; set; }

                /// <summary>
                /// <para>The time at which the alert was first generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account within which the alert is generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176555323***</para>
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>176555323***</para>
                /// </summary>
                [NameInMap("SubUserName")]
                [Validation(Required=false)]
                public string SubUserName { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
