// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialVerifyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>D6163397-15C5-419C-9ACC-B7C83E0B4C10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CredentialVerifyResponseBodyResultObject ResultObject { get; set; }
        public class CredentialVerifyResponseBodyResultObject : TeaModel {
            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public string MaterialInfo { get; set; }

            [NameInMap("OcrInfo")]
            [Validation(Required=false)]
            public string OcrInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("RiskScore")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskScore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PS,SCREEN_PHOTO</para>
            /// </summary>
            [NameInMap("RiskTag")]
            [Validation(Required=false)]
            public string RiskTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>**</para>
            /// </summary>
            [NameInMap("VerifyDetail")]
            [Validation(Required=false)]
            public string VerifyDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

            [NameInMap("VlResult")]
            [Validation(Required=false)]
            public CredentialVerifyResponseBodyResultObjectVlResult VlResult { get; set; }
            public class CredentialVerifyResponseBodyResultObjectVlResult : TeaModel {
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                [NameInMap("VlContent")]
                [Validation(Required=false)]
                public Dictionary<string, object> VlContent { get; set; }

            }

        }

    }

}
