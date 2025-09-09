// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetUserTmpIdentityForPartnerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BindDomain</para>
        /// </summary>
        [NameInMap("AuthPurpose")]
        [Validation(Required=false)]
        public string AuthPurpose { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForSasCspm</para>
        /// </summary>
        [NameInMap("ServiceLinkedRole")]
        [Validation(Required=false)]
        public string ServiceLinkedRole { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1231331311</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
