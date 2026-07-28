// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateGlobalAccelerationInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The peak bandwidth of the Alibaba Cloud Global Accelerator (GA) instance. Unit: Mbit/s. Valid value: <b>10</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>The bandwidth type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Sharing</b>: shared bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>Exclusive</b>: dedicated bandwidth.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exclusive</para>
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. </para>
        /// <para>The client generates the value of this parameter. Ensure that the value is unique among different requests. The value can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the Alibaba Cloud Global Accelerator (GA) instance. </para>
        /// <para>The description must be 2 to 256 characters in length and must start with a letter or a Chinese character, but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My GA</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud Global Accelerator (GA) instance.  </para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-), but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GA-1</para>
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
        /// <para>The region where the Alibaba Cloud Global Accelerator (GA) instance resides. </para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The area where the accelerated service resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>china-mainland</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>north-america</b>: North America.</para>
        /// </description></item>
        /// <item><description><para><b>asia-pacific</b>: Asia-Pacific.</para>
        /// </description></item>
        /// <item><description><para><b>europe</b>: Europe.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>china-mainland</para>
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

    }

}
