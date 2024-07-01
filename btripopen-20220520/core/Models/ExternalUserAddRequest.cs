// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ExternalUserAddRequest : TeaModel {
        [NameInMap("birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        [NameInMap("cert_request_list")]
        [Validation(Required=false)]
        public List<ExternalUserAddRequestCertRequestList> CertRequestList { get; set; }
        public class ExternalUserAddRequestCertRequestList : TeaModel {
            [NameInMap("cert_expired_time")]
            [Validation(Required=false)]
            public string CertExpiredTime { get; set; }

            [NameInMap("cert_nation")]
            [Validation(Required=false)]
            public string CertNation { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cert_no")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cert_type")]
            [Validation(Required=false)]
            public int? CertType { get; set; }

            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

        }

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
