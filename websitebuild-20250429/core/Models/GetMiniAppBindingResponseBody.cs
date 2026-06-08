// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetMiniAppBindingResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMiniAppBindingResponseBodyData Data { get; set; }
        public class GetMiniAppBindingResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public string AuthStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WS20260206134402000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("IcpFiled")]
            [Validation(Required=false)]
            public bool? IcpFiled { get; set; }

            [NameInMap("PlatformAppid")]
            [Validation(Required=false)]
            public string PlatformAppid { get; set; }

            [NameInMap("PreviewQrCodeUrl")]
            [Validation(Required=false)]
            public string PreviewQrCodeUrl { get; set; }

            [NameInMap("ProductionQrCodeUrl")]
            [Validation(Required=false)]
            public string ProductionQrCodeUrl { get; set; }

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
