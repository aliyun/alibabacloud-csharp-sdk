// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedVulRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the vulnerability to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RHSA-2019:0230-Important: polkit security update</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The Asset Type where the vulnerability is detected. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS</b>: host asset</description></item>
        /// <item><description><b>CONTAINER</b>: container asset.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS,CONTAINER</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>The vulnerability type. This query condition is valid only for application vulnerabilities. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sca</b>: software constituency parsing vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability.</description></item>
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
        /// <para>The container search field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: instance ID</description></item>
        /// <item><description><b>appName</b>: application name</description></item>
        /// <item><description><b>clusterId</b>: cluster ID</description></item>
        /// <item><description><b>regionId</b>: region</description></item>
        /// <item><description><b>nodeName</b>: node name</description></item>
        /// <item><description><b>namespace</b>: namespace</description></item>
        /// <item><description><b>clusterName</b>: cluster name</description></item>
        /// <item><description><b>image</b>: image name</description></item>
        /// <item><description><b>imageRepoName</b>: image repository name</description></item>
        /// <item><description><b>imageRepoNamespace</b>: image repository namespace</description></item>
        /// <item><description><b>imageRepoTag</b>: image tag</description></item>
        /// <item><description><b>imageDigest</b>: image digest.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>appName</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value that corresponds to <b>ContainerFieldName</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc914b0df156d40148412afe4a581****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The page number of the first page to display in the query results. Default value: <b>1</b>, which indicates that the results start from page 1.</para>
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
        /// <para>Call the <a href="~~DescribeVulListPage~~">DescribeVulListPage</a> operation to obtain this parameter.</para>
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
        /// <item><description><b>n</b>: not handled.</description></item>
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
        /// <para>The language type of the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The priority of the vulnerability fix to query. Separate multiple priorities with commas (,). Valid values:</para>
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
        /// <para>The number of vulnerability entries per page in a paged query. Default value: 10, which indicates that 10 vulnerability entries are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether Runtime Application Self-Protection (RASP) supports real-time protection against the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not supported.</description></item>
        /// <item><description><b>1</b>: Supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RaspDefend")]
        [Validation(Required=false)]
        public int? RaspDefend { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is added as one of the member accounts in a resource folder.</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The label used for filtering. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Restart required</b></description></item>
        /// <item><description><b>Remote utilization</b></description></item>
        /// <item><description><b>EXP exists</b></description></item>
        /// <item><description><b>Available</b></description></item>
        /// <item><description><b>Privilege escalation</b></description></item>
        /// <item><description><b>Code execution</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Code Execution</para>
        /// </summary>
        [NameInMap("SearchTags")]
        [Validation(Required=false)]
        public string SearchTags { get; set; }

        /// <summary>
        /// <para>The container query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>containerId</b>: container ID</description></item>
        /// <item><description><b>uuid</b>: asset ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>containerId</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability to query. Default value: cve. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability (network scan)</description></item>
        /// <item><description><b>sca</b>: application vulnerability (software constituency parsing).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers to query. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>d42f938c-d962-48a0-90f9-05e4ea****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
