// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAffectedMaliciousFileImagesRequest : TeaModel {
        /// <summary>
        /// The ID of the container cluster.
        /// 
        /// >  You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of container clusters.
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
        /// The ID of the container.
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page **1**. Default value: **1**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The name of the container image.
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// The image digest.
        /// </summary>
        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// The image layer.
        /// </summary>
        [NameInMap("ImageLayer")]
        [Validation(Required=false)]
        public string ImageLayer { get; set; }

        /// <summary>
        /// The tag that is added to the image.
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// The language of the content within the request and the response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The severity level of the malicious image sample. Separate multiple severity levels with commas (,). Valid values:
        /// 
        /// *   **serious**
        /// *   **suspicious**
        /// *   **remind**
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// The MD5 hash value of the malicious image sample.
        /// 
        /// >  You can call the [DescribeGroupedMaliciousFiles](~~DescribeGroupedMaliciousFiles~~) operation to query the MD5 hash values of malicious image samples.
        /// </summary>
        [NameInMap("MaliciousMd5")]
        [Validation(Required=false)]
        public string MaliciousMd5 { get; set; }

        /// <summary>
        /// The namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The pod.
        /// </summary>
        [NameInMap("Pod")]
        [Validation(Required=false)]
        public string Pod { get; set; }

        /// <summary>
        /// The ID of the image repository.
        /// 
        /// >  You can call the [ListRepository](https://help.aliyun.com/document_detail/451339.html) operation to query the IDs of image repositories from the value of the **RepoId** response parameter.
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// The ID of the container image.
        /// 
        /// >  You can call the [ListRepository](https://help.aliyun.com/document_detail/451339.html) operation to query the IDs of container images from the value of the **InstanceId** response parameter.
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
        /// The types of the assets that you want to scan.
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// The status of the malicious image sample. Valid values:
        /// 
        /// *   **0**: The malicious image sample is not handled.
        /// *   **1**: The malicious image sample is handled.
        /// *   **2**: The malicious image sample is being verified.
        /// *   **3**: The malicious image sample is added to the whitelist.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
