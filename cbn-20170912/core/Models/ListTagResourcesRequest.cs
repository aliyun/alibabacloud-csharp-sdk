// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether a next query token exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If this is the first query or no next query exists, you do not need to specify this parameter.</para>
        /// </description></item>
        /// <item><description><para>If a next query exists, set the value to the NextToken value returned by the previous API call.</para>
        /// </description></item>
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
        /// <para>The number of entries per page for a paged query. Valid values: <b>1</b> to <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the resource instance.</para>
        /// <para>This parameter is not required when the resource type is Cen or BandwidthPackage. This parameter is required for all other resource types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The CEN instance ID.</para>
        /// <para>You can specify up to 20 CEN instance IDs at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-8z69wtwqel33lq****</para>
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
        /// <para><b>Cen</b>: CEN instance.</para>
        /// <para><b>BandwidthPackage</b>: bandwidth package instance.</para>
        /// <para><b>TransitRouter</b>: transit router instance.</para>
        /// <para><b>TransitRouterVpcAttachment</b>: VPC connection instance.</para>
        /// <para><b>TransitRouterVbrAttachment</b>: VBR connection instance.</para>
        /// <para><b>TransitRouterPeerAttachment</b>: inter-region connection instance.</para>
        /// <para><b>TransitRouterVpnAttachment</b>: VPN connection instance.</para>
        /// <para><b>TransitRouterRouteTable</b>: route table instance.</para>
        /// <para><b>Flowlog</b>: flow log instance.</para>
        /// <para><b>TransitRouterMulticastDomain</b>: multicast domain instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag information of the CEN instance.</para>
        /// <para>You can query up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>A tag key can contain up to 64 characters and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>A tag value can contain up to 128 characters and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bp</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
