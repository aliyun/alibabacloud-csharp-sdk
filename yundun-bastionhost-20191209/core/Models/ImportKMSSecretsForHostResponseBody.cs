// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ImportKMSSecretsForHostResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The import result for each secret.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<ImportKMSSecretsForHostResponseBodyResults> Results { get; set; }
        public class ImportKMSSecretsForHostResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The result message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("SecretName")]
            [Validation(Required=false)]
            public string SecretName { get; set; }

        }

        /// <summary>
        /// <para>The number of secrets that were successfully imported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public long? SuccessCount { get; set; }

    }

}
