// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> was not returned, it indicates that no additional results exist.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165B5C86-2033-5954-A89D-4CD83BA06C85</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of resources and tags.</para>
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<ListTagResourcesResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class ListTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// <para>The ID of the CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-8z69wtwqel33lq****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The type of the resource. Valid values:</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>CEN</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bp</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
