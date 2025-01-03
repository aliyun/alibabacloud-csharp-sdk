// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListServiceCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username_password</para>
        /// </summary>
        [NameInMap("serviceCredentialType")]
        [Validation(Required=false)]
        public string ServiceCredentialType { get; set; }

    }

}
