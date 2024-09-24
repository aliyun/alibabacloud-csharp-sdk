// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportSuspEventsRequest : TeaModel {
        /// <summary>
        /// <para>The types of assets.</para>
        /// </summary>
        [NameInMap("AssetsTypeList")]
        [Validation(Required=false)]
        public List<string> AssetsTypeList { get; set; }

        /// <summary>
        /// <para>The ID of the cluster that you want to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the IDs of clusters.</para>
        /// </remarks>
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
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the condition that is used to query alert events on containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c819391d2d520485fa3e81e2dc2ea****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The status of the alert event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>N</b>: unhandled</description></item>
        /// <item><description><b>Y</b>: handled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The data source of the exception. Set the value to sas.</para>
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
        /// <para>8076980</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The unique ID of the alert event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17821</para>
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
        /// <para>serious,suspicious,remind</para>
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// <para>The complete name of the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSHELL</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The status codes of alert events.</para>
        /// </summary>
        [NameInMap("OperateErrorCodeList")]
        [Validation(Required=false)]
        public List<string> OperateErrorCodeList { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
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
        /// <para>The source IP address of the request. The value of this parameter is specified by the system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The handling status of the exception. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: all status</description></item>
        /// <item><description><b>1</b>: pending handling</description></item>
        /// <item><description><b>2</b>: ignored</description></item>
        /// <item><description><b>4</b>: confirmed</description></item>
        /// <item><description><b>8</b>: marked as false positive</description></item>
        /// <item><description><b>16</b>: handling</description></item>
        /// <item><description><b>32</b>: handled</description></item>
        /// <item><description><b>64</b>: expired</description></item>
        /// <item><description><b>128</b>: deleted</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The dimension from which you want to configure the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>uuid</b>: the UUID of the asset</description></item>
        /// <item><description><b>image_repo</b>: the ID of the image repository</description></item>
        /// <item><description><b>Cluster</b>: the ID of the cluster</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uuid</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The end of the time range during which the exception is detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-05 00:00:00</para>
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public string TimeEnd { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which the exception is detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-01 00:00:00</para>
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public string TimeStart { get; set; }

        /// <summary>
        /// <para>The unique key of the alert event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1fbe8d16727f61d1478a674d6fa0****</para>
        /// </summary>
        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        /// <summary>
        /// <para>The unique ID of the associated instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18b7336e-d469-473b-af83-8e5420f9****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
