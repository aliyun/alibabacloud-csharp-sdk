// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class DisableInternalAuthenticationSourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the internal authentication source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ia_password</para>
        /// </summary>
        [NameInMap("AuthenticationSourceId")]
        [Validation(Required=false)]
        public string AuthenticationSourceId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_111xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
