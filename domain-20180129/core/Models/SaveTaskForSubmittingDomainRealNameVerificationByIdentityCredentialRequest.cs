// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The domain names to be verified in bulk.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public List<string> DomainName { get; set; }

        /// <summary>
        /// <para>The Base64-encoded content of the identity credential file.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IdentityCredential")]
        [Validation(Required=false)]
        public string IdentityCredential { get; set; }

        /// <summary>
        /// <para>The ID number of the identity credential.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IdentityCredentialNo")]
        [Validation(Required=false)]
        public string IdentityCredentialNo { get; set; }

        /// <summary>
        /// <para>The type of the identity credential. Valid values: IDC, Passport, and OfficerAcademy.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IdentityCredentialType")]
        [Validation(Required=false)]
        public string IdentityCredentialType { get; set; }

        /// <summary>
        /// <para>The response language. Valid values: zh-CN and en-US. The default is en-US.</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The client IP address.</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
