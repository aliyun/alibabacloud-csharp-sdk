// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class EncryptConf : TeaModel {
        /// <summary>
        /// enable
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 加密算法，只支持default和m4。当 enable 为 true 时，此项必选。
        /// </summary>
        [NameInMap("encrypt_type")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        [NameInMap("user_cmk_info")]
        [Validation(Required=false)]
        public EncryptUserCmkConf UserCmkInfo { get; set; }

    }

}
