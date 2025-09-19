// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedVulRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RHSA-2019:0230-Important: polkit security update</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The type of the asset on which the vulnerability is detected. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS</b>: Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>CONTAINER</b>: container</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS,CONTAINER</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability. This parameter is valid only for application vulnerabilities. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sca</b>: vulnerability that is detected based on software component analysis</description></item>
        /// <item><description><b>app</b>: application vulnerability</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("AttachTypes")]
        [Validation(Required=false)]
        public string AttachTypes { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c88fb10da1168494091db6aafc5dd****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The key of the condition that is used to query containers. Valid values:</para>
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
        /// <para>appName</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value specified by <b>ContainerFieldName</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc914b0df156d40148412afe4a581****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The CVE ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeVulListPage~~">DescribeVulListPage</a> operation to query the CVE ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CVE-2017-15420</para>
        /// </summary>
        [NameInMap("CveId")]
        [Validation(Required=false)]
        public string CveId { get; set; }

        /// <summary>
        /// <para>Specifies whether the vulnerability is handled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>y</b>: handled</description></item>
        /// <item><description><b>n</b>: not handled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The ID of the asset group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>235454</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

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
        /// <para>The priorities to fix the vulnerabilities. Separate multiple priorities with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asap</b>: high</description></item>
        /// <item><description><b>later</b>: medium</description></item>
        /// <item><description><b>nntf</b>: low</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asap,later,nntf</para>
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RaspDefend")]
        [Validation(Required=false)]
        public int? RaspDefend { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to query the account ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The tag that is used to search for the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Restart required</b></description></item>
        /// <item><description><b>Remote utilization</b></description></item>
        /// <item><description><b>EXP exists</b></description></item>
        /// <item><description><b>Available</b></description></item>
        /// <item><description><b>Elevation of Privilege</b></description></item>
        /// <item><description><b>Code Execution</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Code Execution</para>
        /// </summary>
        [NameInMap("SearchTags")]
        [Validation(Required=false)]
        public string SearchTags { get; set; }

        /// <summary>
        /// <para>The query type for containers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>containerId</b>: the ID of the container</description></item>
        /// <item><description><b>uuid</b>: the ID of the asset</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>containerId</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability that you want to query. Default value: cve. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability that is detected by network scanning</description></item>
        /// <item><description><b>sca</b>: application vulnerability that is detected by software component analysis</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUID of the server. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>d42f938c-d962-48a0-90f9-05e4ea****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
