// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntElementVerifyRequest : TeaModel {
        [NameInMap("EntName")]
        [Validation(Required=false)]
        public string EntName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ENT_2META</para>
        /// </summary>
        [NameInMap("InfoVerifyType")]
        [Validation(Required=false)]
        public string InfoVerifyType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>370105*****3892</para>
        /// </summary>
        [NameInMap("LegalPersonCertNo")]
        [Validation(Required=false)]
        public string LegalPersonCertNo { get; set; }

        [NameInMap("LegalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32132***328932</para>
        /// </summary>
        [NameInMap("LicenseNo")]
        [Validation(Required=false)]
        public string LicenseNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32198****193000</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>432***421</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>withdraw</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserAuthorization")]
        [Validation(Required=false)]
        public string UserAuthorization { get; set; }

    }

}
