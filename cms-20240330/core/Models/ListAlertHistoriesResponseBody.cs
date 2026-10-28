// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertHistoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of alert histories that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;alertHistoryId&quot;:&quot;ah_123456&quot;,&quot;alertRuleId&quot;:&quot;rule_789&quot;,&quot;status&quot;:&quot;ALARM&quot;,&quot;startTime&quot;:1704067200000}]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAlertHistoriesResponseBodyData> Data { get; set; }
        public class ListAlertHistoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the alert history.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u1oe4i7c197uucfmvscum4u797</para>
            /// </summary>
            [NameInMap("alertHistoryId")]
            [Validation(Required=false)]
            public string AlertHistoryId { get; set; }

            /// <summary>
            /// <para>The unique identifier of the alert rule that generated the alert history.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51d0da46-bb65-4a14-8d65-de73f41e495f</para>
            /// </summary>
            [NameInMap("alertRuleId")]
            [Validation(Required=false)]
            public string AlertRuleId { get; set; }

            /// <summary>
            /// <para>The snapshot of the annotations of the alert rule. The annotations are stored as key-value pairs and copied from the rule when the alert is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;_cms_alert_explore_url&quot;:&quot;<a href="https://sls.console.aliyun.com/...%22%7D">https://sls.console.aliyun.com/...&quot;}</a></para>
            /// </summary>
            [NameInMap("annotations")]
            [Validation(Required=false)]
            public Dictionary<string, string> Annotations { get; set; }

            /// <summary>
            /// <para>The business source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>managed_service_for_prometheus</para>
            /// </summary>
            [NameInMap("bizSource")]
            [Validation(Required=false)]
            public string BizSource { get; set; }

            /// <summary>
            /// <para>The cumulative number of alerts (alert events) during the alert duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The end time (recovery time) of the alert. This field has a value only when the alert history enters the OK state. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740535517000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The creation time of the alert history record. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751608363000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time of the alert history record. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751608363000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The detailed information of the alert object. The information is stored as key-value pairs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;datasourceInfo&quot;:{&quot;type&quot;:&quot;SLS_MULTI_DS&quot;}}</para>
            /// </summary>
            [NameInMap("instanceDetail")]
            [Validation(Required=false)]
            public Dictionary<string, string> InstanceDetail { get; set; }

            /// <summary>
            /// <para>The unique key (instanceKey) used to identify the alert object instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>entity/apm/apm.service/6dc9e46fda6d012537b48c3250ff806b</para>
            /// </summary>
            [NameInMap("instanceKey")]
            [Validation(Required=false)]
            public string InstanceKey { get; set; }

            /// <summary>
            /// <para>The snapshot of the labels of the alert rule. The labels are stored as key-value pairs and copied from the rule when the alert is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;_cms_rule_id&quot;:&quot;42c0f464-a3b0-4c4b-b426-6242289244f8&quot;,&quot;tenant_id&quot;:&quot;mygt&quot;}</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// <para>The level of the most recent alert during the alert duration, such as CRITICAL, WARN, or INFO.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("latestLevel")]
            [Validation(Required=false)]
            public string LatestLevel { get; set; }

            /// <summary>
            /// <para>The highest alert level reached during the alert duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("maxLevel")]
            [Validation(Required=false)]
            public string MaxLevel { get; set; }

            /// <summary>
            /// <para>The content of the latest alert message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The number of zombie child processes of the process {{$tags.comm}} running on the instance {{$tags.instanceId}} is greater than 128</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the observed object is in the global scope. The value is copied from the rule when the alert history is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("observeResourceGlobalScope")]
            [Validation(Required=false)]
            public bool? ObserveResourceGlobalScope { get; set; }

            /// <summary>
            /// <para>The serialized string of the observed object list. The value is copied from the rule when the alert history is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;resourceId&quot;:&quot;i-bp1234567890abcdef&quot;,&quot;resourceType&quot;:&quot;ACS::ECS::Instance&quot;}]</para>
            /// </summary>
            [NameInMap("observeResourceList")]
            [Validation(Required=false)]
            public string ObserveResourceList { get; set; }

            /// <summary>
            /// <para>The type of the observed object, such as PROMETHEUS, APM, RUM, or cms_basic. The value is copied from the rule when the alert history is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROMETHEUS</para>
            /// </summary>
            [NameInMap("observeResourceType")]
            [Validation(Required=false)]
            public string ObserveResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the region to which the alert history belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The display name of the corresponding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myTestRule</para>
            /// </summary>
            [NameInMap("ruleDisplayName")]
            [Validation(Required=false)]
            public string RuleDisplayName { get; set; }

            /// <summary>
            /// <para>The notification sending configuration information corresponding to the alert history.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;notification&quot;:{&quot;contacts&quot;:[&quot;ops-team&quot;],&quot;silenceTime&quot;:3600}}</para>
            /// </summary>
            [NameInMap("send")]
            [Validation(Required=false)]
            public AlertRuleSend Send { get; set; }

            /// <summary>
            /// <para>The start time of the alert history. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751508233000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The current alert status of the rule. Valid values: OK (recovered) and ALARM (alerting).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALARM</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The identifier of the workspace to which the alert history belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-cms-<userId>-cn-hangzhou</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2-ba4d-4b9f-aa24-dcb067a30f1c</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of alert history records that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
