// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateMacSecKeyRequest : TeaModel {
        /// <summary>
        /// <para>The key secret. This parameter accepts only hexadecimal characters. Lowercase letters are automatically converted to uppercase. The cipher suite determines the required length of the key secret: 32 hexadecimal characters for GCM-AES-128 or GCM-AES-XPN-128, and 64 hexadecimal characters for GCM-AES-256 or GCM-AES-XPN-256.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789ABCDEF0123456789ABCDEF</para>
        /// </summary>
        [NameInMap("Cak")]
        [Validation(Required=false)]
        public string Cak { get; set; }

        /// <summary>
        /// <para>The cipher suite. Valid values:</para>
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
        /// <para>The key name. This parameter accepts only hexadecimal characters. Lowercase letters are automatically converted to uppercase. The cipher suite determines the required length of the key name: 32 hexadecimal characters for GCM-AES-128 or GCM-AES-XPN-128, and 64 hexadecimal characters for GCM-AES-256 or GCM-AES-XPN-256.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789ABCDEF0123456789ABCDEF</para>
        /// </summary>
        [NameInMap("Ckn")]
        [Validation(Required=false)]
        public string Ckn { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect physical connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1hp0wr072f6****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect physical connection.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/448570.html">DescribeRegions</a> operation to obtain the region ID.</para>
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
