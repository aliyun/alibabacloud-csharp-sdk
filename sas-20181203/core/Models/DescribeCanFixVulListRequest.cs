// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCanFixVulListRequest : TeaModel {
        /// <summary>
        /// <para>The alias in the vulnerability advisory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RHSA-2017:0184-Important: mysql security update</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c80f79959fd724a888e1187779b13****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the container cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-test-cnnf</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The container ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48a6d9a92435a13ad573372c3f3c63b7e04d106458141df9f92155709d5a****</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query. The value starts from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the vulnerability is handled. Valid values:</para>
        /// <para><b>y</b>: Handled.
        /// <b>n</b>: Not handled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The unique identifier of the container image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8f0fbdb41d3d1ade4ffdf21558443f4c03342010563bb8c43ccc09594d50****</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>The name of the container image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-wulanchabu.aliyuncs.com/sas_test/huxin-test-001:nuxeo6-****</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The container image instance ID.</para>
        /// <remarks>
        /// <para>Invoke the <a href="https://help.aliyun.com/document_detail/451339.html">ListRepository</a> operation of Container Registry and obtain the container image instance ID from the <b>InstanceId</b> response parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cri-rv4nvbv8iju4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scan:AVD-2022-953356</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The cluster namespace.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~GetOpaClusterNamespaceList~~">GetOpaClusterNamespaceList</a> operation to query this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The priority levels of vulnerabilities to query. Separate multiple levels with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asap</b>: high</description></item>
        /// <item><description><b>later</b>: medium</description></item>
        /// <item><description><b>nntf</b>: low.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asap,later,nntf</para>
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paging query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22222-7xsqq</para>
        /// </summary>
        [NameInMap("Pod")]
        [Validation(Required=false)]
        public string Pod { get; set; }

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
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/145293.html">ListRepository</a> operation of Container Registry and obtain the value of the <b>RepoId</b> response parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>crr-avo7qp02simz2njo</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The container image instance ID.</para>
        /// <remarks>
        /// <para>Invoke the <a href="https://help.aliyun.com/document_detail/451339.html">ListRepository</a> operation of Container Registry and obtain the container image instance ID from the <b>InstanceId</b> response parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cri-rv4nvbv8iju4****</para>
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
        /// <para>digital-account</para>
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
        /// <para>ns-digital-dev</para>
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
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RepoRegionId")]
        [Validation(Required=false)]
        public string RepoRegionId { get; set; }

        /// <summary>
        /// <para>The scan scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image</b>: Image.</description></item>
        /// <item><description><b>container</b>: Container.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// <para>The fix status of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Unfixed.</description></item>
        /// <item><description><b>4</b>: Being fixed.</description></item>
        /// <item><description><b>7</b>: Fixed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        /// <summary>
        /// <para>The tag of the container image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1.0</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The vulnerability type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: system vulnerability</description></item>
        /// <item><description><b>sca</b>: application vulnerability.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUIDs of images. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>d15df12472809c1c3b158606c0f1****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
