// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateAgAccountRequest : TeaModel {
        /// <summary>
        /// The attribute of the account. To view the attribute of the account, use the account to log on to the Alibaba Cloud Management Console, move the pointer over the profile picture in the upper-right corner, and then click **Security Settings**.
        /// </summary>
        [NameInMap("AccountAttr")]
        [Validation(Required=false)]
        public string AccountAttr { get; set; }

        /// <summary>
        /// The name of the city.
        /// </summary>
        [NameInMap("CityName")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        [NameInMap("EnterpriseName")]
        [Validation(Required=false)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// The first name.
        /// </summary>
        [NameInMap("FirstName")]
        [Validation(Required=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name.
        /// 
        /// The last name can be up to 64 characters in length.
        /// </summary>
        [NameInMap("LastName")]
        [Validation(Required=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The email address used to log on to the account.
        /// </summary>
        [NameInMap("LoginEmail")]
        [Validation(Required=false)]
        public string LoginEmail { get; set; }

        /// <summary>
        /// The country code.
        /// </summary>
        [NameInMap("NationCode")]
        [Validation(Required=false)]
        public string NationCode { get; set; }

        /// <summary>
        /// The zip code.
        /// </summary>
        [NameInMap("Postcode")]
        [Validation(Required=false)]
        public string Postcode { get; set; }

        /// <summary>
        /// The name of the province. This parameter is optional.
        /// </summary>
        [NameInMap("ProvinceName")]
        [Validation(Required=false)]
        public string ProvinceName { get; set; }

    }

}
