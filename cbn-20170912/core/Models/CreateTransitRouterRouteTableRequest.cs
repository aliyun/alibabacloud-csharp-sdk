// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterRouteTableRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a token from your client to ensure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> of each request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run. The system checks the request for potential issues, including required parameters, request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, a custom route table is created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The features of the route table.</para>
        /// </summary>
        [NameInMap("RouteTableOptions")]
        [Validation(Required=false)]
        public CreateTransitRouterRouteTableRequestRouteTableOptions RouteTableOptions { get; set; }
        public class CreateTransitRouterRouteTableRequestRouteTableOptions : TeaModel {
            /// <summary>
            /// <para>The multi-region equal-cost multi-path (ECMP) routing feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>disable</b> (default): disables the multi-region ECMP routing feature. If you disable the multi-region ECMP routing feature, routes that are learned from different regions but have the same prefix and attributes select the transit router with the smallest region ID as the next hop. The region ID is sorted in alphabetical order. In this case, the latency and bandwidth consumption of the traffic may change. Make sure that you are aware of the impact before you disable the feature.</para>
            /// </description></item>
            /// <item><description><para><b>enable</b>: enables the multi-region ECMP routing feature. If you enable the multi-region ECMP routing feature, routes that are learned from different regions but have the same prefix and attributes are considered ECMP routes. In this case, the latency and bandwidth consumption of the traffic may change. Make sure that you are aware of the impact before you enable the feature.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disable</para>
            /// </summary>
            [NameInMap("MultiRegionECMP")]
            [Validation(Required=false)]
            public string MultiRegionECMP { get; set; }

        }

        /// <summary>
        /// <para>The tag.</para>
        /// <para>You can specify up to 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterRouteTableRequestTag> Tag { get; set; }
        public class CreateTransitRouterRouteTableRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with \<c>aliyun\\</c> or \<c>acs:\\</c>. It cannot contain \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>The tag value can be an empty string or a string of up to 128 characters. It cannot start with \<c>aliyun\\</c> or \<c>acs:\\</c> and cannot contain \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
            /// <para>Each tag key must have a unique tag value. You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Enterprise Edition transit router instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-bp1su1ytdxtataupl****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The description of the custom route table.</para>
        /// <para>The description can be empty or 1 to 256 characters in length. It cannot start with \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableDescription")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableDescription { get; set; }

        /// <summary>
        /// <para>The name of the custom route table.</para>
        /// <para>The name can be empty or 1 to 128 characters in length. It cannot start with \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableName")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableName { get; set; }

    }

}
