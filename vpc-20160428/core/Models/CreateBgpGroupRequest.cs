// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateBgpGroupRequest : TeaModel {
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
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the BGP group.</para>
        /// <para>The description must be 2 to 256 characters in length, and must start with a letter or Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IP version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b> (default): IPv4.</description></item>
        /// <item><description><b>IPv6</b>: IPv6. IPv6 is supported only when the enable IPv6 feature is activated for the VBR for which the BGP group is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a fake ASN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): no.</description></item>
        /// <item><description><b>true</b>: yes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>A router that runs BGP typically belongs to only one AS. When you need to replace the original AS with a new AS (for example, the AS needs to be migrated or merged with another AS) and cannot immediately modify the BGP configuration due to business or other objective factors, you can specify a fake ASN to establish a connection with the local end to ensure service continuity.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFakeAsn")]
        [Validation(Required=false)]
        public bool? IsFakeAsn { get; set; }

        /// <summary>
        /// <para>The custom BGP ASN on the Alibaba Cloud side. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>45104</b></description></item>
        /// <item><description><b>64512</b> to <b>65534</b></description></item>
        /// <item><description><b>4200000000</b> to <b>4294967294</b></description></item>
        /// </list>
        /// <remarks>
        /// <para><b>65025</b> is reserved by Alibaba Cloud. By default, Alibaba Cloud uses <b>45104</b> as the <b>LocalAsn</b>. Using a custom <b>LocalAsn</b> in multi-line access scenarios may cause BGP routing loops. Evaluate the risks before you use this feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>45104</para>
        /// </summary>
        [NameInMap("LocalAsn")]
        [Validation(Required=false)]
        public long? LocalAsn { get; set; }

        /// <summary>
        /// <para>The name of the BGP group.</para>
        /// <para>The name must be 2 to 128 characters in length, and must start with a letter or Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
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
        /// <para>The ASN of the device in the on-premises data center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1****</para>
        /// </summary>
        [NameInMap("PeerAsn")]
        [Validation(Required=false)]
        public long? PeerAsn { get; set; }

        /// <summary>
        /// <para>The region ID of the VBR. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// <para>The maximum number of route entries for the BGP peer. Unit: entries. Default value: <b>110</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110</para>
        /// </summary>
        [NameInMap("RouteQuota")]
        [Validation(Required=false)]
        public int? RouteQuota { get; set; }

        /// <summary>
        /// <para>The ID of the VBR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp1ctxy813985gkuk****</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

    }

}
