// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class DispatchConsoleAPIForPartnerResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. The value is as follows: If the request succeeds, the ErrorCode field is not returned. If the request fails, the ErrorCode field is returned. For more information, see the error code list in this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public DispatchConsoleAPIForPartnerResponseBodyModule Module { get; set; }
        public class DispatchConsoleAPIForPartnerResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Request result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;HasCustomRoleAuth\&quot;: False}</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

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

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
