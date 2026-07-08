// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetMiniAppAuthUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The request result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMiniAppAuthUrlResponseBodyData Data { get; set; }
        public class GetMiniAppAuthUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The authorization URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://nschiper.oneclick.accounts.logi.com/identity/oauth2/token">https://nschiper.oneclick.accounts.logi.com/identity/oauth2/token</a></para>
            /// </summary>
            [NameInMap("AuthUrl")]
            [Validation(Required=false)]
            public string AuthUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
