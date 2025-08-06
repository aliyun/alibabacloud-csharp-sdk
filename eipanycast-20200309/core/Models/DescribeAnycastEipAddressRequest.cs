// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastEipAddressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anycast EIP.</para>
        /// <remarks>
        /// <para>You must specify <b>Ip</b> or <b>AnycastId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aeip-bp1ix34fralt4ykf3****</para>
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint with which the Anycast EIP is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2zebb08phyczzawe****</para>
        /// </summary>
        [NameInMap("BindInstanceId")]
        [Validation(Required=false)]
        public string BindInstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the Anycast EIP.</para>
        /// <remarks>
        /// <para>You must specify <b>Ip</b> or <b>AnycastId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>139.95.XX.XX</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

    }

}
