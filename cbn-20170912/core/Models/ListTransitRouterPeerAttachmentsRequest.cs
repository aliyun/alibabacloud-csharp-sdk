// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPeerAttachmentsRequest : TeaModel {
        /// <summary>
        /// <para>The Cloud Enterprise Network (CEN) instance ID. If you specify this parameter, you must also specify RegionId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-j3jzhw1zpau2km****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query or no next query is to be sent, ignore this parameter.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the value of <b>NextToken</b> that is returned from the last API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>The region ID of the Enterprise Edition transit router. If you specify this parameter, you must also specify CenId.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTransitRouterPeerAttachmentsRequestTag> Tag { get; set; }
        public class ListTransitRouterPeerAttachmentsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>The tag key cannot be an empty string. It can be up to 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>The tag value can be an empty string or a string of up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key is paired with a tag value. You can specify up to 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the inter-region connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-5u4qbayfv2io5v****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The instance ID of the Enterprise Edition transit router, which is used to forward traffic and manage routing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-bp1su1ytdxtataupl****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
