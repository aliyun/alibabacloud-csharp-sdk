// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyEnsEipAddressAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-5sw5dxzgi6umq4uexxkt8wpma</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The peak bandwidth of the EIP. Default value: 5. Valid values: <b>5</b> to <b>10000</b>. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The new description of the EIP. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new name of the EIP. The name must be 2 to 128 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-api-modify</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
