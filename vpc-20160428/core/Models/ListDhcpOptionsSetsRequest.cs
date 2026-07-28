// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListDhcpOptionsSetsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DHCP options set. You can specify up to 20 DHCP options set IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dopt-o6w0df4epg9zo8isy****</para>
        /// </summary>
        [NameInMap("DhcpOptionsSetId")]
        [Validation(Required=false)]
        public List<string> DhcpOptionsSetId { get; set; }

        /// <summary>
        /// <para>The name of the DHCP options set.</para>
        /// <para>The name must be 1 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DhcpOptionsSetName")]
        [Validation(Required=false)]
        public string DhcpOptionsSetName { get; set; }

        /// <summary>
        /// <para>The hostname suffix, such as example.com.</para>
        /// <para>After the DHCP options set is associated with a VPC, the hostname suffix is automatically synchronized to the ECS instances in the associated VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first query or no subsequent query is required, leave this parameter empty.</description></item>
        /// <item><description>If a subsequent query is required, set the value to the <b>NextToken</b> value returned in the previous API call.</description></item>
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
        /// <para>The region ID of the DHCP options sets that you want to query.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the DHCP options set belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListDhcpOptionsSetsRequestTags> Tags { get; set; }
        public class ListDhcpOptionsSetsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
