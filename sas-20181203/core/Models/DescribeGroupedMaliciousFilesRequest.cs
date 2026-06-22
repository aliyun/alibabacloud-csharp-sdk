// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedMaliciousFilesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID of the server for which you want to query exception events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c556c8133b5ad4378b7fc533ddbda****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Minimum value: <b>1</b>. Default value: <b>1</b>, which indicates that the first page is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the malicious file that you want to query.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Mining</para>
        /// </summary>
        [NameInMap("FuzzyMaliciousName")]
        [Validation(Required=false)]
        public string FuzzyMaliciousName { get; set; }

        /// <summary>
        /// <para>The image digest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a5e103187b31a94592a47a5858617f7****</para>
        /// </summary>
        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// <para>The image layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27213ad375b53628dd152a5ca****</para>
        /// </summary>
        [NameInMap("ImageLayer")]
        [Validation(Required=false)]
        public string ImageLayer { get; set; }

        /// <summary>
        /// <para>The image tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
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
        /// <para>The severity levels of the malicious samples in container images that you want to query. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>serious</b>: urgent</description></item>
        /// <item><description><b>suspicious</b>: suspicious</description></item>
        /// <item><description><b>remind</b>: reminder.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>serious</para>
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// <para>The MD5 hash of the malicious file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d836968041f7683b5459****</para>
        /// </summary>
        [NameInMap("MaliciousMd5")]
        [Validation(Required=false)]
        public string MaliciousMd5 { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paging query. Default value: <b>20</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/145293.html">ListRepository</a> operation of Container Registry to obtain the value of the <b>RepoId</b> response parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>crr-vridcl4****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The instance ID of the container image.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/145293.html">ListRepository</a> operation of Container Registry to obtain the value of the <b>InstanceId</b> response parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cri-datvailb****</para>
        /// </summary>
        [NameInMap("RepoInstanceId")]
        [Validation(Required=false)]
        public string RepoInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the image repository.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>centos</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The namespace of the image repository.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hanghai-namespace</para>
        /// </summary>
        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        /// <summary>
        /// <para>The region ID of the image repository. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-beijing</b>: China (Beijing)</description></item>
        /// <item><description><b>cn-zhangjiakou</b>: China (Zhangjiakou)</description></item>
        /// <item><description><b>cn-hangzhou</b>: China (Hangzhou)</description></item>
        /// <item><description><b>cn-shanghai</b>: China (Shanghai)</description></item>
        /// <item><description><b>cn-shenzhen</b>: China (Shenzhen)</description></item>
        /// <item><description><b>cn-hongkong</b>: Hong Kong (China)</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore</description></item>
        /// <item><description><b>ap-southeast-5</b>: Indonesia (Jakarta)</description></item>
        /// <item><description><b>us-east-1</b>: US (Virginia)</description></item>
        /// <item><description><b>us-west-1</b>: US (Silicon Valley)</description></item>
        /// <item><description><b>eu-central-1</b>: Germany (Frankfurt)</description></item>
        /// <item><description><b>eu-west-1</b>: UK (London).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RepoRegionId")]
        [Validation(Required=false)]
        public string RepoRegionId { get; set; }

        /// <summary>
        /// <para>The collection of scan ranges.</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

    }

}
