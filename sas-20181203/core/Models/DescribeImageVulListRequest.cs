// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageVulListRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the vulnerability to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>High severity vulnerability that affects org.eclipse.jetty:jetty-server</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc20a1024011c44b6a8710d6f8b****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>docker-law</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The ID of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c08d5fc1a329a4b88950a253d082f****</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The page number of the page to return in the query results. Default value: <b>1</b>, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the vulnerability has been handled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>y</b>: Handled.</description></item>
        /// <item><description><b>n</b>: Not handled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>y</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The unique identifier of the container image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8f0fbdb41d3d1ade4ffdf21558443f4c03342010563bb8c43ccc09594d507012</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>Specifies whether to group results by image asset before pagination. If set to true, one vulnerability record is returned for each asset, and TotalCount indicates the total number of assets. If set to false or not specified, results are paginated by vulnerability record. Asset grouping is not applied when MaxId is specified.</para>
        /// </summary>
        [NameInMap("GroupByAsset")]
        [Validation(Required=false)]
        public bool? GroupByAsset { get; set; }

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
        /// <para>The ID of the asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1-qeqewqw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language type of the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The name of the vulnerability to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>debian:10:CVE-2019-9893</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-002</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The priority level for fixing the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asap</b>: High-priority vulnerability that must be fixed as soon as possible.</description></item>
        /// <item><description><b>later</b>: Medium-priority vulnerability that can be fixed later.</description></item>
        /// <item><description><b>nntf</b>: Low-priority vulnerability that does not need to be fixed for now.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asap</para>
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: <b>10</b>, which indicates 10 vulnerability entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22222-7xsqq</para>
        /// </summary>
        [NameInMap("Pod")]
        [Validation(Required=false)]
        public string Pod { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the container image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qew****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The instance ID of the container image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-qewqrqcsadf****</para>
        /// </summary>
        [NameInMap("RepoInstanceId")]
        [Validation(Required=false)]
        public string RepoInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the container image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>libssh2</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The namespace of the container image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>libssh2</para>
        /// </summary>
        [NameInMap("RepoNamespace")]
        [Validation(Required=false)]
        public string RepoNamespace { get; set; }

        /// <summary>
        /// <para>The region ID of the container image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RepoRegionId")]
        [Validation(Required=false)]
        public string RepoRegionId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource directory.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The vulnerability tag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AI</b>: vulnerabilities related to AI components</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("RuleTag")]
        [Validation(Required=false)]
        public string RuleTag { get; set; }

        /// <summary>
        /// <para>The collection of scan ranges.</para>
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
        /// <para>oval</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The type of vulnerability to query. Set the value to <b>cve</b>, which indicates container image vulnerabilities.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUIDs of asset instances. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0004a32a0305a7f6ab5ff9600d47****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
