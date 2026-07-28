// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPublicIpAddressPoolsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without querying available IP address pool information. The system checks whether the required parameters are specified, whether the request format is valid, and whether business restrictions are met. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check succeeds, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The line type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BGP</b> (default): BGP (multi-ISP) line.</para>
        /// </description></item>
        /// <item><description><para><b>BGP_PRO</b>: BGP (multi-ISP) Pro line.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about BGP (multi-ISP) lines and BGP (multi-ISP) Pro lines, see <a href="https://help.aliyun.com/document_detail/32321.html">EIP line types</a>.</para>
        /// <para>If you are a whitelist user of single-ISP bandwidth, you can also select the following types:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b>: China Telecom</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom L2</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom L2</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile L2</description></item>
        /// </list>
        /// <para>If you are a China (Hangzhou) Finance Cloud user, this field is required. Set the value to <b>BGP_FinanceCloud</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in this request. Valid values: <b>10</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the IP address pool instance.</para>
        /// <para>The name must be 0 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AddressPoolName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request or if no subsequent request is to be sent.</description></item>
        /// <item><description>If a subsequent request is to be sent, set the value to the NextToken value returned in the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The list of IP address pool instance IDs.</para>
        /// <para>You can specify up to 100 IP address pool instance IDs.</para>
        /// </summary>
        [NameInMap("PublicIpAddressPoolIds")]
        [Validation(Required=false)]
        public List<string> PublicIpAddressPoolIds { get; set; }

        /// <summary>
        /// <para>The region ID of the IP address pool that you want to query.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the IP address pool belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4pcdvf****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Anti-DDoS (Enhanced). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: disabled.</description></item>
        /// <item><description><b>true</b>: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SecurityProtectionEnabled")]
        [Validation(Required=false)]
        public bool? SecurityProtectionEnabled { get; set; }

        /// <summary>
        /// <para>The instance status of the IPAM pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Created</b>: active.</description></item>
        /// <item><description><b>Deleting</b>: being deleted.</description></item>
        /// <item><description><b>Modifying</b>: being modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPublicIpAddressPoolsRequestTags> Tags { get; set; }
        public class ListPublicIpAddressPoolsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
