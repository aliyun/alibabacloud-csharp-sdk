// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateCommerceSettingRequest : TeaModel {
        /// <summary>
        /// Specifies whether to display the shopping cart button.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CartEnable")]
        [Validation(Required=false)]
        public bool? CartEnable { get; set; }

        /// <summary>
        /// Specifies whether to display the catalog button.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CatalogVisible")]
        [Validation(Required=false)]
        public bool? CatalogVisible { get; set; }

        /// <summary>
        /// The space ID of the user within the independent software vendor (ISV) account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The phone number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

    }

}
