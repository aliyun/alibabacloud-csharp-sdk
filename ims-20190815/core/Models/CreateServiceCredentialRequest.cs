// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateServiceCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the service credential, in days.
        /// Valid values: 1 to 36600.
        /// If this parameter is not specified, the service credential is permanently valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("CredentialAgeDays")]
        [Validation(Required=false)]
        public int? CredentialAgeDays { get; set; }

        /// <summary>
        /// <para>The service credential name.
        /// The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), hyphens (-), and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourServiceCredentialName</para>
        /// </summary>
        [NameInMap("ServiceCredentialName")]
        [Validation(Required=false)]
        public string ServiceCredentialName { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud service name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The logon name of the RAM user.
        /// If this parameter is left empty, a service credential is created for the current user by default.</para>
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
