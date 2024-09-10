// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportSuspEventsRequest : TeaModel {
        /// <summary>
        /// The types of assets.
        /// </summary>
        [NameInMap("AssetsTypeList")]
        [Validation(Required=false)]
        public List<string> AssetsTypeList { get; set; }

        /// <summary>
        /// The ID of the cluster that you want to query.
        /// 
        /// > You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The key of the condition that is used to query alert events on containers. Valid values:
        /// 
        /// *   **instanceId**: the ID of the asset
        /// *   **appName**: the name of the application
        /// *   **clusterId**: the ID of the cluster
        /// *   **regionId**: the ID of the region
        /// *   **nodeName**: the name of the node
        /// *   **namespace**: the namespace
        /// *   **clusterName**: the name of the cluster
        /// *   **image**: the name of the image
        /// *   **imageRepoName**: the name of the image repository
        /// *   **imageRepoNamespace**: the namespace to which the image repository belongs
        /// *   **imageRepoTag**: the tag that is added to the image
        /// *   **imageDigest**: the digest of the image
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// The value of the condition that is used to query alert events on containers.
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// The status of the alert event. Valid values:
        /// 
        /// *   **N**: unhandled
        /// *   **Y**: handled
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The data source of the exception. Set the value to sas.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The ID of the asset group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The unique ID of the alert event.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The severity of the alert event. Separate multiple severities with commas (,). Valid values:
        /// 
        /// *   **serious**
        /// *   **suspicious**
        /// *   **remind**
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// The complete name of the exception.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The status codes of alert events.
        /// </summary>
        [NameInMap("OperateErrorCodeList")]
        [Validation(Required=false)]
        public List<string> OperateErrorCodeList { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The alert type of the alert event. Valid values:
        /// 
        /// *   **Suspicious process**
        /// *   **Webshell**
        /// *   **Unusual logon**
        /// *   **Exception**
        /// *   **Sensitive file tampering**
        /// *   **Malicious process (cloud threat detection)**
        /// *   **Suspicious network connection**
        /// *   **Suspicious account**
        /// *   **Application intrusion event**
        /// *   **Cloud threat detection**
        /// *   **Precise defense**
        /// *   **Application whitelist**
        /// *   **Persistent webshell**
        /// *   **Web application threat detection**
        /// *   **Malicious script**
        /// *   **Threat intelligence**
        /// *   **Malicious network activity**
        /// *   **Cluster exception**
        /// *   **Webshell (on-premises threat detection)**
        /// *   **Vulnerability exploitation**
        /// *   **Malicious process (on-premises threat detection)**
        /// *   **Trusted exception**
        /// *   **Others**
        /// </summary>
        [NameInMap("ParentEventTypes")]
        [Validation(Required=false)]
        public string ParentEventTypes { get; set; }

        /// <summary>
        /// The remarks.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The source IP address of the request. The value of this parameter is specified by the system.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The handling status of the exception. Valid values:
        /// 
        /// *   **0**: all status
        /// *   **1**: pending handling
        /// *   **2**: ignored
        /// *   **4**: confirmed
        /// *   **8**: marked as false positive
        /// *   **16**: handling
        /// *   **32**: handled
        /// *   **64**: expired
        /// *   **128**: deleted
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The dimension from which you want to configure the feature. Valid values:
        /// 
        /// *   **uuid**: the UUID of the asset
        /// *   **image_repo**: the ID of the image repository
        /// *   **Cluster**: the ID of the cluster
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The end of the time range during which the exception is detected.
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public string TimeEnd { get; set; }

        /// <summary>
        /// The beginning of the time range during which the exception is detected.
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public string TimeStart { get; set; }

        /// <summary>
        /// The unique key of the alert event.
        /// </summary>
        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        /// <summary>
        /// The unique ID of the associated instance.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
