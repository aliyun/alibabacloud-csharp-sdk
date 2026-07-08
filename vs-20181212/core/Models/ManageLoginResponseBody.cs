// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ManageLoginResponseBody : TeaModel {
        /// <summary>
        /// <para>Connection information.</para>
        /// </summary>
        [NameInMap("LoginInfo")]
        [Validation(Required=false)]
        public ManageLoginResponseBodyLoginInfo LoginInfo { get; set; }
        public class ManageLoginResponseBodyLoginInfo : TeaModel {
            /// <summary>
            /// <para>Port for ADB connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10005</para>
            /// </summary>
            [NameInMap("AdbLoginPort")]
            [Validation(Required=false)]
            public int? AdbLoginPort { get; set; }

            /// <summary>
            /// <para>Host for SSH connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12.10.4.10</para>
            /// </summary>
            [NameInMap("LoginHostname")]
            [Validation(Required=false)]
            public string LoginHostname { get; set; }

            /// <summary>
            /// <para>Port for SSH connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10004</para>
            /// </summary>
            [NameInMap("LoginPort")]
            [Validation(Required=false)]
            public int? LoginPort { get; set; }

        }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
