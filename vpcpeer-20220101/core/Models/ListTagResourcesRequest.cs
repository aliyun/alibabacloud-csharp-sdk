// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcPeer20220101.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Tag Type:</para>
        /// <list type="bullet">
        /// <item><description>All(Default)</description></item>
        /// <item><description>Custom</description></item>
        /// <item><description>System</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>50</b>. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query or no subsequent query is to be sent, ignore this parameter.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the value of <b>NextToken</b> that is returned in the last call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The resource ID.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Set the value to <b>PeerConnection</b>, which specifies a VPC peering connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PeerConnection</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        [Obsolete]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para> You must specify <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para> You must specify <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b>.</para>
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
