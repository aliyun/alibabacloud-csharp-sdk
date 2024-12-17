// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateApplicationClientSecretResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the client key.</para>
        /// </summary>
        [NameInMap("ApplicationClientSecret")]
        [Validation(Required=false)]
        public CreateApplicationClientSecretResponseBodyApplicationClientSecret ApplicationClientSecret { get; set; }
        public class CreateApplicationClientSecretResponseBodyApplicationClientSecret : TeaModel {
            /// <summary>
            /// <para>The client ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The client key secret of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSEHDcHcrUKHw1CuxkJEHPveWRXBGqVqRsxxxx</para>
            /// </summary>
            [NameInMap("ClientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            /// <summary>
            /// <para>The client key ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sci_k52x2ru63rlkflina5utgkxxxx</para>
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
