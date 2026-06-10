// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetMiniAppBindingResponseBody : TeaModel {
        /// <summary>
        /// <para>Request result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMiniAppBindingResponseBodyData Data { get; set; }
        public class GetMiniAppBindingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Authorization status</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public string AuthStatus { get; set; }

            /// <summary>
            /// <para>Business ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>WS20260206134402000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>ICP filing status</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IcpFiled")]
            [Validation(Required=false)]
            public bool? IcpFiled { get; set; }

            /// <summary>
            /// <para>Miniapp ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>wx7f122a7d23fdxxxx</para>
            /// </summary>
            [NameInMap("PlatformAppid")]
            [Validation(Required=false)]
            public string PlatformAppid { get; set; }

            /// <summary>
            /// <para>Preview QR code</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxx">http://xxxx</a></para>
            /// </summary>
            [NameInMap("PreviewQrCodeUrl")]
            [Validation(Required=false)]
            public string PreviewQrCodeUrl { get; set; }

            /// <summary>
            /// <para>Production QR code</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxx">http://xxxx</a></para>
            /// </summary>
            [NameInMap("ProductionQrCodeUrl")]
            [Validation(Required=false)]
            public string ProductionQrCodeUrl { get; set; }

            /// <summary>
            /// <para>Extension information</para>
            /// </summary>
            [NameInMap("SettingValues")]
            [Validation(Required=false)]
            public Dictionary<string, string> SettingValues { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
