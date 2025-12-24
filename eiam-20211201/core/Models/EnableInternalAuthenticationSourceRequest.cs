// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class EnableInternalAuthenticationSourceRequest : TeaModel {
        /// <summary>
        /// <para>内部认证源ID，比如 ia_password, ia_otp_sms 等</para>
        /// 
        /// <b>Example:</b>
        /// <para>ia_password</para>
        /// </summary>
        [NameInMap("AuthenticationSourceId")]
        [Validation(Required=false)]
        public string AuthenticationSourceId { get; set; }

        /// <summary>
        /// <para>IDaaS EIAM的实例id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_111ccc11xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
