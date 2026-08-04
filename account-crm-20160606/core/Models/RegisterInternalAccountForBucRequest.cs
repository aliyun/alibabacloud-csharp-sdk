// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class RegisterInternalAccountForBucRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("IsEmailConfirmed")]
        [Validation(Required=false)]
        public bool? IsEmailConfirmed { get; set; }

        [NameInMap("IsMobileConfirmed")]
        [Validation(Required=false)]
        public bool? IsMobileConfirmed { get; set; }

        [NameInMap("IsMobileLogin")]
        [Validation(Required=false)]
        public bool? IsMobileLogin { get; set; }

        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("NationalityCode")]
        [Validation(Required=false)]
        public string NationalityCode { get; set; }

        [NameInMap("PlainPassword")]
        [Validation(Required=false)]
        public string PlainPassword { get; set; }

        [NameInMap("PreferredLanguage")]
        [Validation(Required=false)]
        public string PreferredLanguage { get; set; }

        [NameInMap("accountTypeCode")]
        [Validation(Required=false)]
        public string AccountTypeCode { get; set; }

    }

}
