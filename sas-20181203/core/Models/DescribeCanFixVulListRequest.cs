// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCanFixVulListRequest : TeaModel {
        /// <summary>
        /// The alias of the vulnerability that is specified in Common Vulnerabilities and Exposures (CVE).
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// >  You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of clusters.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The container ID.
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether the vulnerability is handled. Valid values:
        /// 
        /// **y**: The vulnerability is handled. **n**: The vulnerability is not handled.
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The unique identifier of the image.
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// The name of the image.
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// The ID of the container image.
        /// 
        /// >  You can call the [ListRepository](https://help.aliyun.com/document_detail/451339.html) operation of Container Registry and obtain the ID of the container image from **InstanceId** in the response.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the vulnerability.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The namespace of the cluster.
        /// 
        /// >  You can call the [GetOpaClusterNamespaceList](~~GetOpaClusterNamespaceList~~) operation to query the namespaces of clusters.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The priority to fix the vulnerability. Separate multiple priorities with commas (,). Valid values:
        /// 
        /// *   **asap**: high
        /// *   **later**: medium
        /// *   **nntf**: low
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the container group.
        /// </summary>
        [NameInMap("Pod")]
        [Validation(Required=false)]
        public string Pod { get; set; }

        /// <summary>
        /// The region ID of the image repository. Valid values:
        /// 
        /// *   **cn-beijing**: China (Beijing)
        /// *   **cn-zhangjiakou**: China (Zhangjiakou)
        /// *   **cn-hangzhou**: China (Hangzhou)
        /// *   **cn-shanghai**: China (Shanghai)
        /// *   **cn-shenzhen**: China (Shenzhen)
        /// *   **cn-hongkong**: China (Hong Kong)
        /// *   **ap-southeast-1**: Singapore
        /// *   **ap-southeast-5**: Indonesia (Jakarta)
        /// *   **us-east-1**: US (Virginia)
        /// *   **us-west-1**: US (Silicon Valley)
        /// *   **eu-central-1**: Germany (Frankfurt)
        /// *   **eu-west-1**: UK (London)
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the image repository.
        /// 
        /// >  You can call the [ListRepository](https://help.aliyun.com/document_detail/145293.html) operation of Container Registry and obtain the ID of the image repository from **RepoId** in the response.
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// The ID of the container image.
        /// 
        /// >  You can call the [ListRepository](https://help.aliyun.com/document_detail/451339.html) operation of Container Registry and obtain the ID of the container image from **InstanceId** in the response.
        /// </summary>
        [NameInMap("RepoInstanceId")]
        [Validation(Required=false)]
        public string RepoInstanceId { get; set; }

        /// <summary>
        /// The name of the image repository.
        /// 
        /// >  Fuzzy match is supported.
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// The namespace to which the image repository belongs.
        /// 
        /// >  Fuzzy match is supported.
        /// </summary>
        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        /// <summary>
        /// The region ID of the image repository. Valid values:
        /// 
        /// *   **cn-beijing**: China (Beijing)
        /// *   **cn-zhangjiakou**: China (Zhangjiakou)
        /// *   **cn-hangzhou**: China (Hangzhou)
        /// *   **cn-shanghai**: China (Shanghai)
        /// *   **cn-shenzhen**: China (Shenzhen)
        /// *   **cn-hongkong**: China (Hong Kong)
        /// *   **ap-southeast-1**: Singapore
        /// *   **ap-southeast-5**: Indonesia (Jakarta)
        /// *   **us-east-1**: US (Virginia)
        /// *   **us-west-1**: US (Silicon Valley)
        /// *   **eu-central-1**: Germany (Frankfurt)
        /// *   **eu-west-1**: UK (London)
        /// </summary>
        [NameInMap("RepoRegionId")]
        [Validation(Required=false)]
        public string RepoRegionId { get; set; }

        /// <summary>
        /// The type of the asset that you want to scan. Valid values:
        /// 
        /// *   **image**
        /// *   **container**
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// The status of the vulnerability. Valid values:
        /// 
        /// *   **1**: The vulnerability is unfixed.
        /// *   **4**: The vulnerability is being fixed.
        /// *   **7**:The vulnerability is fixed.
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        /// <summary>
        /// The tag to add to the image.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The type of the vulnerability. Valid values:
        /// 
        /// *   **cve**: system vulnerability
        /// *   **sca**: application vulnerability
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The UUID of the image. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
