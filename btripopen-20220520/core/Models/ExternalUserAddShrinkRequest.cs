// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ExternalUserAddShrinkRequest : TeaModel {
        [NameInMap("birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        [NameInMap("cert_request_list")]
        [Validation(Required=false)]
        public string CertRequestListShrink { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("external_user_id")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("real_name")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        [NameInMap("real_name_en")]
        [Validation(Required=false)]
        public string RealNameEn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("user_type")]
        [Validation(Required=false)]
        public int? UserType { get; set; }

    }

}
