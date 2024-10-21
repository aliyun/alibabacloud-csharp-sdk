// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query and no next queries are to be sent, ignore this parameter.</description></item>
        /// <item><description>If a subsequent query is to be sent, set the parameter to the value of NextToken that is returned from the last call.</description></item>
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
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the resource is deployed.</para>
        /// <para>You can ignore this parameter if ResourceType is set to Cen or BandwidthPackage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the CEN instances.</para>
        /// <para>You can specify at most 20 IDs in each call.</para>
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
        /// <para>The type of the resource to which you want to add the tag. Valid values:</para>
        /// <para><b>Cen</b>: CEN instance</para>
        /// <para><b>BandwidthPackage</b>: bandwidth plan</para>
        /// <para><b>TransitRouter</b>: transit router</para>
        /// <para><b>TransitRouterVpcAttachment</b>: virtual private cloud (VPC) connection</para>
        /// <para><b>TransitRouterVbrAttachment</b>: virtual border router (VBR) connection</para>
        /// <para><b>TransitRouterPeerAttachment</b>: inter-region connection</para>
        /// <para><b>TransitRouterVpnAttachment</b>: VPN connection</para>
        /// <para><b>TransitRouterRouteTable</b>: route table</para>
        /// <para><b>Flowlog</b>: flow log</para>
        /// <para><b>TransitRouterMulticastDomain</b>: multicast domain</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The information about the tags that are added to the CEN instance.</para>
        /// <para>You can query at most 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag key cannot exceed 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value cannot exceed 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag values.</para>
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
