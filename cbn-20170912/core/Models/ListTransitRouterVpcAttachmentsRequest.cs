// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterVpcAttachmentsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the CEN instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-j3jzhw1zpau2km****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query and no subsequent queries are to be sent, ignore this parameter.</description></item>
        /// <item><description>If a subsequent query is to be sent, set the parameter to the value of NextToken that is returned from the last call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The entity that pays the fees of the network instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByCenOwner</b>: the Alibaba Cloud account that owns the CEN instance.</description></item>
        /// <item><description><b>PayByResourceOwner</b>: the Alibaba Cloud account that owns the network instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByCenOwner</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Enterprise Edition transit router.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether the network instance is attached to the CEN instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Attaching</b>: being attached to the CEN instance.</description></item>
        /// <item><description><b>Attached</b>: attached to the CEN instance.</description></item>
        /// <item><description><b>Detaching</b>: being detached from the CEN instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Attached</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The information about the tags.</para>
        /// <para>You can specify at most 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTransitRouterVpcAttachmentsRequestTag> Tag { get; set; }
        public class ListTransitRouterVpcAttachmentsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be 0 to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key must have a unique tag value. You can specify at most 20 tag values in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-nls9fzkfat8934****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The ID of the Enterprise Edition transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-bp1su1ytdxtataupl****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1kbjcre9vtsebo1****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
