// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class EncryptPhoneNumRequest : TeaModel {
        /// <summary>
        /// 实例Id
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 号码明文
        /// </summary>
        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

    }

}
