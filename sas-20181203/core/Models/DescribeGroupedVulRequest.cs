// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedVulRequest : TeaModel {
        /// <summary>
        /// The alias of the vulnerability.
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// The type of the asset on which the vulnerability is detected. Separate multiple types with commas (,). Valid values:
        /// 
        /// *   **ECS**: Elastic Compute Service (ECS) instance
        /// *   **CONTAINER**: container
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// The type of the vulnerability. This parameter is valid only for application vulnerabilities. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   **sca**: vulnerability that is detected based on software component analysis
        /// *   **app**: application vulnerability
        /// </summary>
        [NameInMap("AttachTypes")]
        [Validation(Required=false)]
        public string AttachTypes { get; set; }

        /// <summary>
        /// The key of the condition that is used to query containers. Valid values:
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
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether the vulnerability is handled. Valid values:
        /// 
        /// **y**: yes **n**: no
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The ID of the asset group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

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
        /// The priorities to fix the vulnerabilities. Separate multiple priorities with commas (,). Valid values:
        /// 
        /// *   **asap**: high
        /// *   **later**: medium
        /// *   **nntf**: low
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the member in the resource directory.
        /// 
        /// >  You can call the [DescribeMonitorAccounts](~~DescribeMonitorAccounts~~) operation to obtain the IDs.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// The tag that is used to filter vulnerabilities. Valid values:
        /// 
        /// *   Restart required
        /// *   Remote utilization
        /// *   EXP exists
        /// *   Available
        /// *   Elevation of Privilege
        /// *   Code Execution
        /// </summary>
        [NameInMap("SearchTags")]
        [Validation(Required=false)]
        public string SearchTags { get; set; }

        /// <summary>
        /// The query type for containers. Valid values:
        /// 
        /// *   **containerId**: the ID of the container
        /// *   **uuid**: the ID of the asset
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The type of the vulnerability that you want to query. Default value: cve. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerability
        /// *   **sys**: Windows system vulnerability
        /// *   **cms**: Web-CMS vulnerability
        /// *   **app**: application vulnerability
        /// *   **emg**: urgent vulnerability
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The UUID of the server. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
