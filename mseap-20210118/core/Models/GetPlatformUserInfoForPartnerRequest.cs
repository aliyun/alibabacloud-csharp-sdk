// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class GetPlatformUserInfoForPartnerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>app-0wceagu85ceaaais</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MP</para>
        /// </summary>
        [NameInMap("PlatformType")]
        [Validation(Required=false)]
        public string PlatformType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123153124411</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
