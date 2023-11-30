// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetShareLinkTokenRequest : TeaModel {
        /// <summary>
        /// The validity period of the token. Valid values: (0,7200]. Default value: 7200. Unit: seconds.
        /// </summary>
        [NameInMap("expire_sec")]
        [Validation(Required=false)]
        public int? ExpireSec { get; set; }

        /// <summary>
        /// The share ID.
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// The access code.
        /// </summary>
        [NameInMap("share_pwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

    }

}
