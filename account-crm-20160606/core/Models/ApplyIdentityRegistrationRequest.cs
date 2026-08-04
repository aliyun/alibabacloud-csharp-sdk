// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class ApplyIdentityRegistrationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public int? AccountType { get; set; }

        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DocBackPic")]
        [Validation(Required=false)]
        public string DocBackPic { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DocFrontPic")]
        [Validation(Required=false)]
        public string DocFrontPic { get; set; }

        [NameInMap("DocNum")]
        [Validation(Required=false)]
        public string DocNum { get; set; }

        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FullName")]
        [Validation(Required=false)]
        public string FullName { get; set; }

        [NameInMap("RegisteredAddress")]
        [Validation(Required=false)]
        public string RegisteredAddress { get; set; }

        [NameInMap("RegisteredCountry")]
        [Validation(Required=false)]
        public string RegisteredCountry { get; set; }

        [NameInMap("RegisteredNum")]
        [Validation(Required=false)]
        public string RegisteredNum { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Tel")]
        [Validation(Required=false)]
        public string Tel { get; set; }

    }

}
