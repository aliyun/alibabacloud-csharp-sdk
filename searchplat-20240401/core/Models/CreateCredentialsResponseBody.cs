// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class CreateCredentialsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E37A447-C010-5A49-9F31-DE12E97710A3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateCredentialsResponseBodyResult Result { get; set; }
        public class CreateCredentialsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12323</para>
            /// </summary>
            [NameInMap("appGroupId")]
            [Validation(Required=false)]
            public long? AppGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the credential is enabled.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The generated credential token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OS-********</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The credential type.</para>
            /// <list type="bullet">
            /// <item><description>api-token</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>api-token</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
