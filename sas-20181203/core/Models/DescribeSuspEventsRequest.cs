// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventsRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the alert event.</para>
        /// <remarks>
        /// <para>To query the exception information of a single alert event, provide the unique ID of the alert event. You can obtain this ID by calling the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8df914418f4211fb****</para>
        /// </summary>
        [NameInMap("AlarmUniqueInfo")]
        [Validation(Required=false)]
        public string AlarmUniqueInfo { get; set; }

        /// <summary>
        /// <para>The collection of asset types.</para>
        /// </summary>
        [NameInMap("AssetsTypeList")]
        [Validation(Required=false)]
        public List<string> AssetsTypeList { get; set; }

        /// <summary>
        /// <para>The cluster ID for which you want to query alert events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c4af4fdf38a98496a9b63c2be5dae****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The container search field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: instance ID</description></item>
        /// <item><description><b>appName</b>: application name</description></item>
        /// <item><description><b>clusterId</b>: cluster ID</description></item>
        /// <item><description><b>regionId</b>: region</description></item>
        /// <item><description><b>nodeName</b>: node name</description></item>
        /// <item><description><b>namespace</b>: namespace</description></item>
        /// <item><description><b>clusterName</b>: cluster name</description></item>
        /// <item><description><b>image</b>: image name</description></item>
        /// <item><description><b>imageRepoName</b>: image repository name</description></item>
        /// <item><description><b>imageRepoNamespace</b>: image repository namespace</description></item>
        /// <item><description><b>imageRepoTag</b>: image tag</description></item>
        /// <item><description><b>imageDigest</b>: image digest</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the container search field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccf9769c22b844ff9b8d57417683b****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The page number of the page to return in a paged query. Default value: <b>1</b>, which indicates that the results start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert events to query have been handled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>N</b>: Unhandled.</description></item>
        /// <item><description><b>Y</b>: Handled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The discovery source. This is an invalid field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("DetectSource")]
        [Validation(Required=false)]
        public string DetectSource { get; set; }

        /// <summary>
        /// <para>The subtypes of the alert events. Separate multiple subtypes with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSHELL</para>
        /// </summary>
        [NameInMap("EventNames")]
        [Validation(Required=false)]
        public string EventNames { get; set; }

        /// <summary>
        /// <para>The data source identifier of the alert event. The value is fixed as sas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The group ID of the asset affected by the alert event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18768</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The unique ID that identifies the alert event record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The severity levels of the alert events to query. Separate multiple severity levels with commas (,). The severity levels are listed in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>serious</b>: Urgent.</description></item>
        /// <item><description><b>suspicious</b>: Suspicious.</description></item>
        /// <item><description><b>remind</b>: Reminder.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>serious</para>
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// <para>The multi-account query type. Default value: <b>0</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Query data of the current account.</description></item>
        /// <item><description><b>1</b>: Query data of all accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MultiAccountActionType")]
        [Validation(Required=false)]
        public int? MultiAccountActionType { get; set; }

        /// <summary>
        /// <para>The name of the asset affected by the alert event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-xxx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The collection of alert event handling result codes.</para>
        /// </summary>
        [NameInMap("OperateErrorCodeList")]
        [Validation(Required=false)]
        public List<string> OperateErrorCodeList { get; set; }

        /// <summary>
        /// <para>The end timestamp of the handling time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-06 13:50:38</para>
        /// </summary>
        [NameInMap("OperateTimeEnd")]
        [Validation(Required=false)]
        public string OperateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start timestamp of the handling time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-05 13:50:38</para>
        /// </summary>
        [NameInMap("OperateTimeStart")]
        [Validation(Required=false)]
        public string OperateTimeStart { get; set; }

        /// <summary>
        /// <para>The number of alert events to display on each page in a paged query. Default value: <b>20</b>, which indicates that 20 alert events are displayed on each page. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The alerting type of the alert events to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Abnormal process behavior</b></description></item>
        /// <item><description><b>Web shell</b></description></item>
        /// <item><description><b>Unusual logon</b></description></item>
        /// <item><description><b>Abnormal event</b></description></item>
        /// <item><description><b>Sensitive file tampering</b></description></item>
        /// <item><description><b>Malicious process (cloud scan)</b></description></item>
        /// <item><description><b>Suspicious network connectivity</b></description></item>
        /// <item><description><b>Abnormal account</b></description></item>
        /// <item><description><b>Application intrusion event</b></description></item>
        /// <item><description><b>Cloud service threat detection</b></description></item>
        /// <item><description><b>Precise defense</b></description></item>
        /// <item><description><b>Application whitelist</b></description></item>
        /// <item><description><b>Persistent backdoor</b></description></item>
        /// <item><description><b>Web application threat detection</b></description></item>
        /// <item><description><b>Malicious script</b></description></item>
        /// <item><description><b>Threat intelligence</b></description></item>
        /// <item><description><b>Malicious network behavior</b></description></item>
        /// <item><description><b>Container cluster exception</b></description></item>
        /// <item><description><b>Web shell (local scan)</b></description></item>
        /// <item><description><b>Vulnerability exploits</b></description></item>
        /// <item><description><b>Malicious process (local scan)</b></description></item>
        /// <item><description><b>Trusted exception</b></description></item>
        /// <item><description><b>Other</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>other</para>
        /// </summary>
        [NameInMap("ParentEventTypes")]
        [Validation(Required=false)]
        public string ParentEventTypes { get; set; }

        /// <summary>
        /// <para>The alert name or asset information to query.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported. Asset information includes the asset name, public IP address, and private IP address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource directory.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16670360956*****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The custom sort field. Default value: <b>operateTime</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lastTime</b>: Latest occurrence time.</description></item>
        /// <item><description><b>operateTime</b>: Handling time.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field takes effect only when <b>Dealed</b> is set to Y.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>operateTime</para>
        /// </summary>
        [NameInMap("SortColumn")]
        [Validation(Required=false)]
        public string SortColumn { get; set; }

        /// <summary>
        /// <para>The custom sort order. Default value: <b>desc</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: Ascending order.</description></item>
        /// <item><description><b>desc</b>: Descending order.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field takes effect only when <b>Dealed</b> is set to Y.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The alert source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aegis_suspicious_file_v2</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The list of Alibaba Cloud account IDs that generated the alerts.</para>
        /// </summary>
        [NameInMap("SourceAliUids")]
        [Validation(Required=false)]
        public List<long?> SourceAliUids { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The status of the alert events to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: All.</description></item>
        /// <item><description><b>1</b>: Unhandled.</description></item>
        /// <item><description><b>2</b>: Ignored.</description></item>
        /// <item><description><b>4</b>: Confirmed.</description></item>
        /// <item><description><b>8</b>: Marked as false positive.</description></item>
        /// <item><description><b>16</b>: Handling.</description></item>
        /// <item><description><b>32</b>: Handled.</description></item>
        /// <item><description><b>64</b>: Expired.</description></item>
        /// <item><description><b>128</b>: Deleted.</description></item>
        /// <item><description><b>512</b>: Automatic blocking in progress.</description></item>
        /// <item><description><b>513</b>: Automatic blocking completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert is in strict mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>N: No.</description></item>
        /// <item><description>Y: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("StrictMode")]
        [Validation(Required=false)]
        public string StrictMode { get; set; }

        /// <summary>
        /// <para>The list of operation types supported by the alert.</para>
        /// </summary>
        [NameInMap("SupportOperateCodeList")]
        [Validation(Required=false)]
        public List<string> SupportOperateCodeList { get; set; }

        /// <summary>
        /// <para>The ATT&amp;CK tactic ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TA0001</para>
        /// </summary>
        [NameInMap("TacticId")]
        [Validation(Required=false)]
        public string TacticId { get; set; }

        /// <summary>
        /// <para>The target type for container search. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>containerId</b>: container ID</description></item>
        /// <item><description><b>uuid</b>: server UUID</description></item>
        /// <item><description><b>imageUuid</b>: image UUID</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>containerId</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The end time of the latest occurrence. Format: YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-06 13:50:38</para>
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public string TimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the latest occurrence. Format: YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-05 13:50:38</para>
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public string TimeStart { get; set; }

        /// <summary>
        /// <para>The unique key of the security alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73fc06fb175a7405697e402f52864****</para>
        /// </summary>
        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers for which you want to query alerts. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>bb5d2484-f10e-450d-8917-3e79667e****,0e7c2fcd-7100-42c7-a21a-db6e4f32****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
