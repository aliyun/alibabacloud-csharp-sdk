// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class ModifyAnycastEipAddressSpecRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anycast EIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aeip-bp1ix34fralt4ykf3****</para>
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the Anycast EIP. Unit: Mbit/s.</para>
        /// <para>Valid values: <b>200</b> to <b>1000</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

    }

}
