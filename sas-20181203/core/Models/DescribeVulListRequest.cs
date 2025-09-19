// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListRequest : TeaModel {
        /// <summary>
        /// <para>The name of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RHSA-2019:0230-Important: polkit security update</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The additional type of the vulnerabilities. You need to specify this parameter when you query application vulnerabilities. Set the value to <b>sca</b>. If you set <b>Type</b> to <b>app</b>, you must specify this parameter.</para>
        /// <remarks>
        /// <para>If you set this parameter to <b>sca</b>, application vulnerabilities and the vulnerabilities that are detected based on software component analysis are queried. If you do not specify this parameter, only application vulnerabilities are queried.</para>
        /// </remarks>
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
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the vulnerabilities are fixed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>y</b>: yes</description></item>
        /// <item><description><b>n</b>: no</description></item>
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
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query the IDs of asset groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9207613</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The IDs of vulnerabilities. You can specify up to 50 IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>282,281,283</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

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
        /// <para>The alias of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oval:com.redhat.rhsa:def:20172836</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The priority to fix the vulnerability. Separate multiple priorities with commas (,). Valid values:</para>
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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken. You do not need to specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E17B501887A2D3AA5E8360A6EFA3B***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the application protection feature is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: no.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: yes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RaspDefend")]
        [Validation(Required=false)]
        public int? RaspDefend { get; set; }

        /// <summary>
        /// <para>The remarks for the asset affected by the vulnerability. The value can be the private IP address, public IP address, or name of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The status of the vulnerability. Separate multiple statuses with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: unfixed</description></item>
        /// <item><description>2: fix failed</description></item>
        /// <item><description>3: rollback failed</description></item>
        /// <item><description>4: being fixed</description></item>
        /// <item><description>5: being rolled back</description></item>
        /// <item><description>6: being verified</description></item>
        /// <item><description>7: fixed</description></item>
        /// <item><description>8: fixed and to be restarted</description></item>
        /// <item><description>9: rolled back</description></item>
        /// <item><description>10: ignored</description></item>
        /// <item><description>11: rolled back and to be restarted</description></item>
        /// <item><description>12: not found</description></item>
        /// <item><description>20: expired</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        /// <summary>
        /// <para>The type of the asset on which the vulnerability is detected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>k8s</b>: Kubernetes component.</description></item>
        /// <item><description><b>uuid</b>: server.</description></item>
        /// <item><description><b>containerId</b>: container.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>k8s</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability.</description></item>
        /// <item><description><b>app</b>: application vulnerability that is detected by using web scanner</description></item>
        /// <item><description><b>emg</b>: urgent vulnerability.</description></item>
        /// <item><description><b>sca</b>: application vulnerability that is detected by using software component analysis</description></item>
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
        /// <para>Specifies whether to use NextToken to query the data of vulnerabilities. If you set UseNextToken to true, the value of TotalCount is not returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers on which you want to query the vulnerabilities. Separate multiple UUIDs with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain the UUIDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1587bedb-fdb4-48c4-9330-****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) in which the vulnerabilities are detected. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ins-133****,ins-5414****</para>
        /// </summary>
        [NameInMap("VpcInstanceIds")]
        [Validation(Required=false)]
        public string VpcInstanceIds { get; set; }

    }

}
