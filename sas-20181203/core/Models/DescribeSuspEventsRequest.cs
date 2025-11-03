// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert event.</para>
        /// <remarks>
        /// <para>To query the details of an alert event, you must specify the ID of the alert event. You can call the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation to query the IDs of alert events.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8df914418f4211fb****</para>
        /// </summary>
        [NameInMap("AlarmUniqueInfo")]
        [Validation(Required=false)]
        public string AlarmUniqueInfo { get; set; }

        /// <summary>
        /// <para>The types of the assets.</para>
        /// </summary>
        [NameInMap("AssetsTypeList")]
        [Validation(Required=false)]
        public List<string> AssetsTypeList { get; set; }

        /// <summary>
        /// <para>The ID of the cluster of whose alert events you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c4af4fdf38a98496a9b63c2be5dae****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The key of the condition that is used to query alert events on containers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: the ID of the asset</description></item>
        /// <item><description><b>appName</b>: the name of the application</description></item>
        /// <item><description><b>clusterId</b>: the ID of the cluster</description></item>
        /// <item><description><b>regionId</b>: the ID of the region</description></item>
        /// <item><description><b>nodeName</b>: the name of the node</description></item>
        /// <item><description><b>namespace</b>: the namespace</description></item>
        /// <item><description><b>clusterName</b>: the name of the cluster</description></item>
        /// <item><description><b>image</b>: the name of the image</description></item>
        /// <item><description><b>imageRepoName</b>: the name of the image repository</description></item>
        /// <item><description><b>imageRepoNamespace</b>: the namespace to which the image repository belongs</description></item>
        /// <item><description><b>imageRepoTag</b>: the tag that is added to the image</description></item>
        /// <item><description><b>imageDigest</b>: the digest of the image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the condition that is used to query alert events on containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccf9769c22b844ff9b8d57417683b****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert event is handled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>N</b>: unhandled</description></item>
        /// <item><description><b>Y</b>: handled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The subtype of the alert event. Separate multiple subtypes with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSHELL</para>
        /// </summary>
        [NameInMap("EventNames")]
        [Validation(Required=false)]
        public string EventNames { get; set; }

        /// <summary>
        /// <para>The data source of the alert event. Set the value to sas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The ID of the asset group to which the affected asset belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18768</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the alert event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The severity of the alert event. Separate multiple severities with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>serious</b></description></item>
        /// <item><description><b>suspicious</b></description></item>
        /// <item><description><b>remind</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>serious</para>
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// <para>The type of the accounts that you want to query. Default value: <b>0</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the current account.</description></item>
        /// <item><description><b>1</b>: all accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MultiAccountActionType")]
        [Validation(Required=false)]
        public int? MultiAccountActionType { get; set; }

        /// <summary>
        /// <para>The name of the asset that is affected by the alert event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-xxx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>An array that consists of the handling result codes of alert events.</para>
        /// </summary>
        [NameInMap("OperateErrorCodeList")]
        [Validation(Required=false)]
        public List<string> OperateErrorCodeList { get; set; }

        /// <summary>
        /// <para>The timestamp when the handling operation ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-06 13:50:38</para>
        /// </summary>
        [NameInMap("OperateTimeEnd")]
        [Validation(Required=false)]
        public string OperateTimeEnd { get; set; }

        /// <summary>
        /// <para>The timestamp when the handling operation starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-05 13:50:38</para>
        /// </summary>
        [NameInMap("OperateTimeStart")]
        [Validation(Required=false)]
        public string OperateTimeStart { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The alert type of the alert event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Suspicious process</b></description></item>
        /// <item><description><b>Webshell</b></description></item>
        /// <item><description><b>Unusual logon</b></description></item>
        /// <item><description><b>Exception</b></description></item>
        /// <item><description><b>Sensitive file tampering</b></description></item>
        /// <item><description><b>Malicious process (cloud threat detection)</b></description></item>
        /// <item><description><b>Suspicious network connection</b></description></item>
        /// <item><description><b>Suspicious account</b></description></item>
        /// <item><description><b>Application intrusion event</b></description></item>
        /// <item><description><b>Cloud threat detection</b></description></item>
        /// <item><description><b>Precise defense</b></description></item>
        /// <item><description><b>Application whitelist</b></description></item>
        /// <item><description><b>Persistent webshell</b></description></item>
        /// <item><description><b>Web application threat detection</b></description></item>
        /// <item><description><b>Malicious script</b></description></item>
        /// <item><description><b>Threat intelligence</b></description></item>
        /// <item><description><b>Malicious network activity</b></description></item>
        /// <item><description><b>Cluster exception</b></description></item>
        /// <item><description><b>Webshell (on-premises threat detection)</b></description></item>
        /// <item><description><b>Vulnerability exploitation</b></description></item>
        /// <item><description><b>Malicious process (on-premises threat detection)</b></description></item>
        /// <item><description><b>Trusted exception</b></description></item>
        /// <item><description><b>Others</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Webshell</para>
        /// </summary>
        [NameInMap("ParentEventTypes")]
        [Validation(Required=false)]
        public string ParentEventTypes { get; set; }

        /// <summary>
        /// <para>The name of the alert or the information about the asset.</para>
        /// <remarks>
        /// <para> Fuzzy search is supported. The asset information includes the name, public IP address, and private IP address of an asset.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to query the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16670360956*****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The custom sorting field. Default value: <b>operateTime</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lastTime</b>: the latest occurrence time.</description></item>
        /// <item><description><b>operateTime</b>: the handling time.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect if you set the <b>Dealed</b> parameter to Y.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>operateTime</para>
        /// </summary>
        [NameInMap("SortColumn")]
        [Validation(Required=false)]
        public string SortColumn { get; set; }

        /// <summary>
        /// <para>The custom sorting order. Default value: <b>desc</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: the ascending order</description></item>
        /// <item><description><b>desc</b>: the descending order</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect if you set the <b>Dealed</b> parameter to Y.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The source of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aegis_suspicious_file_v2</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The IDs of the Alibaba Cloud accounts within which alerts are generated.</para>
        /// </summary>
        [NameInMap("SourceAliUids")]
        [Validation(Required=false)]
        public List<long?> SourceAliUids { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The status of the alert event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: all</description></item>
        /// <item><description><b>1</b>: pending handling</description></item>
        /// <item><description><b>2</b>: ignored</description></item>
        /// <item><description><b>4</b>: confirmed</description></item>
        /// <item><description><b>8</b>: marked as a false positive</description></item>
        /// <item><description><b>16</b>: handling</description></item>
        /// <item><description><b>32</b>: handled</description></item>
        /// <item><description><b>64</b>: expired</description></item>
        /// <item><description><b>128</b>: deleted</description></item>
        /// <item><description><b>512</b>: automatically blocking</description></item>
        /// <item><description><b>513</b>: automatically blocked</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the strict alerting mode.</para>
        /// <list type="bullet">
        /// <item><description>N: no</description></item>
        /// <item><description>Y: Yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("StrictMode")]
        [Validation(Required=false)]
        public string StrictMode { get; set; }

        /// <summary>
        /// <para>告警支持的操作类型列表。</para>
        /// </summary>
        [NameInMap("SupportOperateCodeList")]
        [Validation(Required=false)]
        public List<string> SupportOperateCodeList { get; set; }

        /// <summary>
        /// <para>The tactic ID of ATT\&amp;CK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TA0001</para>
        /// </summary>
        [NameInMap("TacticId")]
        [Validation(Required=false)]
        public string TacticId { get; set; }

        /// <summary>
        /// <para>The item that is used to search for the container. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>containerId</b>: the ID of the container</description></item>
        /// <item><description><b>uuid</b>: the UUID of the server</description></item>
        /// <item><description><b>imageUuid</b>: the UUID of the image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>containerId</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The end time when the alert event was last detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-06 13:50:38</para>
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public string TimeEnd { get; set; }

        /// <summary>
        /// <para>The start time when the alert event was last detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-05 13:50:38</para>
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public string TimeStart { get; set; }

        /// <summary>
        /// <para>The unique key of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73fc06fb175a7405697e402f52864****</para>
        /// </summary>
        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        /// <summary>
        /// <para>The UUID of the server on which the alert is detected. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>bb5d2484-f10e-450d-8917-3e79667e****,0e7c2fcd-7100-42c7-a21a-db6e4f32****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
