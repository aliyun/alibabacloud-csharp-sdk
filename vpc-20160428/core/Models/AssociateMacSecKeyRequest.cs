// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateMacSecKeyRequest : TeaModel {
        /// <summary>
        /// <para>The passphrase. Only hexadecimal characters are supported. Lowercase characters are automatically transformed to uppercase. When the encryption algorithm type is GCM-AES-128 or GCM-AES-XPN-128, the length must be 32 hexadecimal characters. When the encryption algorithm type is GCM-AES-256 or GCM-AES-XPN-256, the length must be 64 hexadecimal characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789ABCDEF0123456789ABCDEF</para>
        /// </summary>
        [NameInMap("Cak")]
        [Validation(Required=false)]
        public string Cak { get; set; }

        /// <summary>
        /// <para>The encryption algorithm type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GCM-AES-128</para>
        /// </description></item>
        /// <item><description><para>GCM-AES-XPN-128</para>
        /// </description></item>
        /// <item><description><para>GCM-AES-256</para>
        /// </description></item>
        /// <item><description><para>GCM-AES-XPN-256</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GCM-AES-128</para>
        /// </summary>
        [NameInMap("CipherSuite")]
        [Validation(Required=false)]
        public string CipherSuite { get; set; }

        /// <summary>
        /// <para>The key name. Only hexadecimal characters are supported. Lowercase characters are automatically transformed to uppercase. When the encryption algorithm type is GCM-AES-128 or GCM-AES-XPN-128, the length must be 32 hexadecimal characters. When the encryption algorithm type is GCM-AES-256 or GCM-AES-XPN-256, the length must be 64 hexadecimal characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789ABCDEF0123456789ABCDEF</para>
        /// </summary>
        [NameInMap("Ckn")]
        [Validation(Required=false)]
        public string Ckn { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit. The Express Connect circuit must be a dedicated circuit that has completed payment, supports MACsec, and is in the <b>Enabled</b> state. You can call DescribePhysicalConnections to query the current status and device capabilities.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1hp0wr072f6****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/448570.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
