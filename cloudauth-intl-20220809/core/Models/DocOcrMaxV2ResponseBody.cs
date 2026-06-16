// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DocOcrMaxV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5E63B760-0ECB-5C07-8503-A65C27876968</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DocOcrMaxV2ResponseBodyResult Result { get; set; }
        public class DocOcrMaxV2ResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;ocrIdInfo&quot;: {
            ///     &quot;id_number&quot;: &quot;<em><b><b>719</b></b></em><em>&quot;,
            ///     &quot;address&quot;: &quot;xxxxxx,
            ///     &quot;ethnicity&quot;: &quot;汉&quot;,
            ///     &quot;date_of_birth&quot;: &quot;1990年06月02日&quot;,
            ///     &quot;sex&quot;: &quot;女&quot;,
            ///     &quot;name&quot;: &quot;何</em>*&quot;
            ///   },
            ///   &quot;ocrStandardData&quot;: {
            ///     &quot;given_name_s&quot;: &quot;**&quot;,
            ///     &quot;surname_s&quot;: &quot;HE&quot;,
            ///     &quot;date_of_birth_s&quot;: &quot;1990-06-02&quot;,
            ///     &quot;sex_s&quot;: &quot;F&quot;
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("ExtIdInfo")]
            [Validation(Required=false)]
            public string ExtIdInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>08573be80f944d95ac812e019e3655a8</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
