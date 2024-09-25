// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:<b>1</b> to <b>50</b>. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of <b>NextToken</b>.</description></item>
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
        /// <para>The region ID of the resource.</para>
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
        /// <para>The resource ID. You can specify up to 20 resource IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp16qjewdsunr41m1****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b></description></item>
        /// <item><description><b>VSWITCH</b></description></item>
        /// <item><description><b>ROUTETABLE</b></description></item>
        /// <item><description><b>EIP</b></description></item>
        /// <item><description><b>VpnGateway</b></description></item>
        /// <item><description><b>NATGATEWAY</b></description></item>
        /// <item><description><b>COMMONBANDWIDTHPACKAGE</b>: EIP bandwidth plan</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag value. You can specify up to 20 tag values. It can be an empty string.</para>
        /// <para>The value can be up to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The value must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. The value cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// <remarks>
        /// <para> You must specify at least one of <b>ResourceId.N</b> and <b>Tag.N</b> (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ListTagResources</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag that is added to the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The key can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The key must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. The key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para> Specify at least one of the <b>ResourceId.N</b> and <b>Tag.N</b> parameters (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that is added to the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The value can be up to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The value must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. The value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para> Specify at least one of the <b>ResourceId.N</b> and <b>Tag.N</b> parameters (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>).</para>
            /// </remarks>
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
