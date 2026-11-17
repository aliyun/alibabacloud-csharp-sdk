// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DisassociateMacSecKeyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the key. Only hexadecimal characters are supported, and lowercase letters are automatically converted to uppercase letters. The length must be 32 hexadecimal characters when the encryption algorithm is GCM-AES-128 or GCM-AES-XPN-128, and 64 hexadecimal characters when the encryption algorithm is GCM-AES-256 or GCM-AES-XPN-256. The value must be the name of a key that has been associated with the target Express Connect circuit by calling the AssociateMacSecKey operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789ABCDEF0123456789ABCDEF</para>
        /// </summary>
        [NameInMap("Ckn")]
        [Validation(Required=false)]
        public string Ckn { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit. The Express Connect circuit must be in the <b>Enabled</b> state and its <b>BusinessStatus</b> must be <b>Normal</b>. You can call the DescribePhysicalConnections operation to query the status.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1hp0wr072f6****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit. You can call the <a href="https://help.aliyun.com/document_detail/448570.html">DescribeRegions</a> operation to query region IDs.</para>
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
