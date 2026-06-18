// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class EncryptPhoneNumRequest : TeaModel {
        /// <summary>
        /// <para>AICCS instance ID. You can obtain it from the Artificial Intelligence Cloud Call Service console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The plaintext phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130****0000</para>
        /// </summary>
        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

    }

}
