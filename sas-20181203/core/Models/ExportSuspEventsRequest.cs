// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportSuspEventsRequest : TeaModel {
        /// <summary>
        /// <para>The collection of asset types.</para>
        /// </summary>
        [NameInMap("AssetsTypeList")]
        [Validation(Required=false)]
        public List<string> AssetsTypeList { get; set; }

        /// <summary>
        /// <para>The ID of the cluster to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
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
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the container search field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c819391d2d520485fa3e81e2dc2ea****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
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
        /// <item><description><b>N</b>: Unhandled.</description></item>
        /// <item><description><b>Y</b>: Handled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The data source identifier of the anomaly event. Set the value to sas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The ID of the asset group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9454789</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The unique ID of the alert event record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17821</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>serious,suspicious,remind</para>
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// <para>The full name of the anomaly event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSHELL</para>
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
        /// <para>The maximum number of entries per page in a paged query. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The Alarm Metric of the alerting events to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Abnormal process behavior</b></description></item>
        /// <item><description><b>Web shell</b></description></item>
        /// <item><description><b>Unusual logon</b></description></item>
        /// <item><description><b>Anomaly event</b></description></item>
        /// <item><description><b>Sensitive file tampering</b></description></item>
        /// <item><description><b>Malicious process (cloud scan)</b></description></item>
        /// <item><description><b>Suspicious network connection</b></description></item>
        /// <item><description><b>Abnormal account</b></description></item>
        /// <item><description><b>Application intrusion event</b></description></item>
        /// <item><description><b>Cloud service threat detection</b></description></item>
        /// <item><description><b>Precise defense</b></description></item>
        /// <item><description><b>Application whitelist</b></description></item>
        /// <item><description><b>Persistent backdoor</b></description></item>
        /// <item><description><b>Web application threat detection</b></description></item>
        /// <item><description><b>Malicious script</b></description></item>
        /// <item><description><b>Threat intelligence</b></description></item>
        /// <item><description><b>Malicious network connectivity behavior</b></description></item>
        /// <item><description><b>Container cluster exception</b></description></item>
        /// <item><description><b>Web shell (local scan)</b></description></item>
        /// <item><description><b>Vulnerability exploits</b></description></item>
        /// <item><description><b>Malicious process (local scan)</b></description></item>
        /// <item><description><b>Trusted exception</b></description></item>
        /// <item><description><b>Other</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSHELL</para>
        /// </summary>
        [NameInMap("ParentEventTypes")]
        [Validation(Required=false)]
        public string ParentEventTypes { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account of the member accounts in the resource directory.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The source IP address of the request. You do not need to specify this parameter. The system automatically obtains this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The handling status of the anomaly event. Valid values:</para>
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
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The dimension of the target switch configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>uuid</b>: asset UUID</description></item>
        /// <item><description><b>image_repo</b>: image repository ID</description></item>
        /// <item><description><b>Cluster</b>: cluster ID</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uuid</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The end time of the anomaly event. Format: YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-05 00:00:00</para>
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public string TimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the anomaly event occurrence. Format: YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-01 00:00:00</para>
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public string TimeStart { get; set; }

        /// <summary>
        /// <para>The unique key of the security alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1fbe8d16727f61d1478a674d6fa0****</para>
        /// </summary>
        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        /// <summary>
        /// <para>The unique identifier of the associated instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18b7336e-d469-473b-af83-8e5420f9****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
