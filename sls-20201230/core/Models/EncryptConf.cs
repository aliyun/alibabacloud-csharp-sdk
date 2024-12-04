// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class EncryptConf : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("encrypt_type")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        [NameInMap("user_cmk_info")]
        [Validation(Required=false)]
        public EncryptUserCmkConf UserCmkInfo { get; set; }

    }

}
