// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyBgpGroupAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The authentication key of the BGP group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>!PWZ2****</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>The BGP group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bgpg-wz9f62v4fbg2g****</para>
        /// </summary>
        [NameInMap("BgpGroupId")]
        [Validation(Required=false)]
        public string BgpGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to clear the secret key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ClearAuthKey")]
        [Validation(Required=false)]
        public bool? ClearAuthKey { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The BGP group description.</para>
        /// <para>The description must be 2 to 256 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a fake AS number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>A router that runs BGP typically belongs to only one AS. If you need to replace an AS with a new one, but you cannot immediately modify BGP configurations due to business requirements, you can specify a fake AS number to establish a connection with the local end. This ensures service continuity in scenarios such as AS migration or AS merging.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsFakeAsn")]
        [Validation(Required=false)]
        public bool? IsFakeAsn { get; set; }

        /// <summary>
        /// <para>The custom autonomous system number (ASN) of the BGP on the Alibaba Cloud side. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>45104</b></description></item>
        /// <item><description><b>64512~65534</b></description></item>
        /// <item><description><b>4200000000~4294967294</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> <b>65025</b> is reserved by Alibaba Cloud. Alibaba Cloud uses <b>45104</b> as the <b>local ASN</b> by default. Custom <b>local ASNs</b> may cause loops in multi-line scenarios. Proceed with caution.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>45104</para>
        /// </summary>
        [NameInMap("LocalAsn")]
        [Validation(Required=false)]
        public long? LocalAsn { get; set; }

        /// <summary>
        /// <para>The BGP group name.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ASN of the gateway device in the data center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1****</para>
        /// </summary>
        [NameInMap("PeerAsn")]
        [Validation(Required=false)]
        public long? PeerAsn { get; set; }

        /// <summary>
        /// <para>The region ID of the BGP group.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
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
        /// <para>The maximum number of routes supported by a BGP peer. Default value: <b>110</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110</para>
        /// </summary>
        [NameInMap("RouteQuota")]
        [Validation(Required=false)]
        public int? RouteQuota { get; set; }

    }

}
