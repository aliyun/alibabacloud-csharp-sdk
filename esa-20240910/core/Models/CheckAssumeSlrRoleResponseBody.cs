// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CheckAssumeSlrRoleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>aliuid:xxx assumeOssRole not exist,serviceName:realtimelogpush.dcdnservices.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsExist")]
        [Validation(Required=false)]
        public string IsExist { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>34DCBC8A-<b><b>-</b></b>-****-6DAA11D7DDBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
