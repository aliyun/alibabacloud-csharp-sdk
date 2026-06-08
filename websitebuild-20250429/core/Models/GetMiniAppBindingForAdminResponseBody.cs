// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetMiniAppBindingForAdminResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMiniAppBindingForAdminResponseBodyData Data { get; set; }
        public class GetMiniAppBindingForAdminResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AUTHORIZED</para>
            /// </summary>
            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public string AuthStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WS20250801004817000002</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("PlatformAppid")]
            [Validation(Required=false)]
            public string PlatformAppid { get; set; }

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
