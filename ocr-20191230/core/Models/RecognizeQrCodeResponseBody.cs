// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeQrCodeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeQrCodeResponseBodyData Data { get; set; }
        public class RecognizeQrCodeResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeQrCodeResponseBodyDataElements> Elements { get; set; }
            public class RecognizeQrCodeResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/ocr/RecognizeQrCode/RecognizeQrCode6.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/ocr/RecognizeQrCode/RecognizeQrCode6.jpg</a></para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<RecognizeQrCodeResponseBodyDataElementsResults> Results { get; set; }
                public class RecognizeQrCodeResponseBodyDataElementsResults : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qrcode</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("QrCodesData")]
                    [Validation(Required=false)]
                    public List<string> QrCodesData { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>99.91</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>review</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>img5iGtwVIxQzc4Nqy$L84yHd-1v****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A53DC437-F883-4968-86D5-EB21FB044692</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
