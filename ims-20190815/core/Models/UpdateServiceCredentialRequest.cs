// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateServiceCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the service credential.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SC****************</para>
        /// </summary>
        [NameInMap("ServiceCredentialId")]
        [Validation(Required=false)]
        public string ServiceCredentialId { get; set; }

        /// <summary>
        /// <para>The name of the service credential. The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), hyphens (-), and underscores (_). You must specify at least one of Status and ServiceCredentialName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourServiceCredentialName</para>
        /// </summary>
        [NameInMap("ServiceCredentialName")]
        [Validation(Required=false)]
        public string ServiceCredentialName { get; set; }

        /// <summary>
        /// <para>The status of the service credential. Valid values: Active, Inactive. You must specify at least one of Status and ServiceCredentialName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The logon name of the Resource Access Management (RAM) user. If not specified, the service credential of the current invoke identity is updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
