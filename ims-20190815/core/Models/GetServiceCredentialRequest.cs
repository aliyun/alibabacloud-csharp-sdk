// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetServiceCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The service credential ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SC****************</para>
        /// </summary>
        [NameInMap("ServiceCredentialId")]
        [Validation(Required=false)]
        public string ServiceCredentialId { get; set; }

        /// <summary>
        /// <para>The logon name of the Resource Access Management (RAM) user.
        /// If not specified, the service credential of the current caller identity that invokes this operation is retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
