// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventsRequest : TeaModel {
        /// <summary>
        /// The ID of the alert event.
        /// 
        /// > To query the details of an alert event, you must specify the ID of the alert event. You can call the [DescribeSuspEvents](~~DescribeSuspEvents~~) operation to query the IDs of alert events.
        /// </summary>
        [NameInMap("AlarmUniqueInfo")]
        [Validation(Required=false)]
        public string AlarmUniqueInfo { get; set; }

        /// <summary>
        /// The types of the assets.
        /// </summary>
        [NameInMap("AssetsTypeList")]
        [Validation(Required=false)]
        public List<string> AssetsTypeList { get; set; }

        /// <summary>
        /// The ID of the cluster of whose alert events you want to query.
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
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether the alert event is handled. Valid values:
        /// 
        /// *   **N**: unhandled
        /// *   **Y**: handled
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The subtype of the alert event. Separate multiple subtypes with commas (,).
        /// </summary>
        [NameInMap("EventNames")]
        [Validation(Required=false)]
        public string EventNames { get; set; }

        /// <summary>
        /// The data source of the alert event. Set the value to sas.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The ID of the asset group to which the affected asset belongs.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The ID of the alert event.
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

        [NameInMap("MultiAccountActionType")]
        [Validation(Required=false)]
        public int? MultiAccountActionType { get; set; }

        /// <summary>
        /// The name of the asset that is affected by the alert event.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// An array that consists of the handling result codes of alert events.
        /// </summary>
        [NameInMap("OperateErrorCodeList")]
        [Validation(Required=false)]
        public List<string> OperateErrorCodeList { get; set; }

        /// <summary>
        /// The timestamp when the handling operation ends.
        /// </summary>
        [NameInMap("OperateTimeEnd")]
        [Validation(Required=false)]
        public string OperateTimeEnd { get; set; }

        /// <summary>
        /// The timestamp when the handling operation starts.
        /// </summary>
        [NameInMap("OperateTimeStart")]
        [Validation(Required=false)]
        public string OperateTimeStart { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **20**. Maximum value: 100.
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
        /// *   **Operations to manage other resources**
        /// </summary>
        [NameInMap("ParentEventTypes")]
        [Validation(Required=false)]
        public string ParentEventTypes { get; set; }

        /// <summary>
        /// The name of the alert or the information about the asset.
        /// 
        /// >  Fuzzy search is supported. The asset information includes the name, public IP address, and private IP address of an asset.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the member in the resource directory.
        /// 
        /// >  You can call the [DescribeMonitorAccounts](~~DescribeMonitorAccounts~~) operation to query the ID.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// The custom sorting field. Default value: **operateTime**. Valid values:
        /// 
        /// *   **lastTime**: the latest occurrence time.
        /// *   **operateTime**: the handling time.
        /// 
        /// >  This parameter takes effect if you set the **Dealed** parameter to Y.
        /// </summary>
        [NameInMap("SortColumn")]
        [Validation(Required=false)]
        public string SortColumn { get; set; }

        /// <summary>
        /// The custom sorting order. Default value: **desc**. Valid values:
        /// 
        /// *   **asc**: the ascending order
        /// *   **desc**: the descending order
        /// 
        /// >  This parameter takes effect if you set the **Dealed** parameter to Y.
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// The source of the alert.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("SourceAliUids")]
        [Validation(Required=false)]
        public List<long?> SourceAliUids { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The status of the alert event. Valid values:
        /// 
        /// *   **0**: all
        /// *   **1**: pending handling
        /// *   **2**: ignored
        /// *   **4**: confirmed
        /// *   **8**: marked as a false positive
        /// *   **16**: handling
        /// *   **32**: handled
        /// *   **64**: expired
        /// *   **128**: deleted
        /// *   **512**: automatically blocking
        /// *   **513**: automatically blocked
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Specifies whether to enable the strict alerting mode.
        /// 
        /// *   N: no
        /// *   Y: Yes
        /// </summary>
        [NameInMap("StrictMode")]
        [Validation(Required=false)]
        public string StrictMode { get; set; }

        /// <summary>
        /// The tactic ID of ATT\\&CK.
        /// </summary>
        [NameInMap("TacticId")]
        [Validation(Required=false)]
        public string TacticId { get; set; }

        /// <summary>
        /// The item that is used to search for the container. Valid values:
        /// 
        /// *   **containerId**: the ID of the container
        /// *   **uuid**: the UUID of the server
        /// *   **imageUuid**: the UUID of the image
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The end time when the alert event was last detected.
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public string TimeEnd { get; set; }

        /// <summary>
        /// The start time when the alert event was last detected.
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public string TimeStart { get; set; }

        /// <summary>
        /// The unique key of the alert.
        /// </summary>
        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        /// <summary>
        /// The UUID of the server on which the alert is detected. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
