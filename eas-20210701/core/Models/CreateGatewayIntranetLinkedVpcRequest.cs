// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateGatewayIntranetLinkedVpcRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19*****10</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authoritative DNS parsing. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAuthoritativeDns")]
        [Validation(Required=false)]
        public bool? EnableAuthoritativeDns { get; set; }

        /// <summary>
        /// <para>The ID of the virtual switch. For more information, see <a href="https://help.aliyun.com/document_detail/448581.html">DescribeVpcs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-8vbqn2at0kljjxxxx****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/448581.html">DescribeVpcs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf66uio7md****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
