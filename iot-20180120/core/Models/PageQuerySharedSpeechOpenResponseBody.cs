// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PageQuerySharedSpeechOpenResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The result returned if the request was successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PageQuerySharedSpeechOpenResponseBodyData Data { get; set; }
        public class PageQuerySharedSpeechOpenResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public int? PageId { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The information about shared speeches.
            /// </summary>
            [NameInMap("ResultData")]
            [Validation(Required=false)]
            public PageQuerySharedSpeechOpenResponseBodyDataResultData ResultData { get; set; }
            public class PageQuerySharedSpeechOpenResponseBodyDataResultData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<PageQuerySharedSpeechOpenResponseBodyDataResultDataData> Data { get; set; }
                public class PageQuerySharedSpeechOpenResponseBodyDataResultDataData : TeaModel {
                    /// <summary>
                    /// The audio format. Valid values: **wav**, **mp3**, and **amr**.
                    /// </summary>
                    [NameInMap("AudioFormat")]
                    [Validation(Required=false)]
                    public string AudioFormat { get; set; }

                    /// <summary>
                    /// The unique identifier of the speech in the project.
                    /// </summary>
                    [NameInMap("BizCode")]
                    [Validation(Required=false)]
                    public string BizCode { get; set; }

                    /// <summary>
                    /// The unique identifier of the template.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// The broadcasting speed. Valid values: -500 to 500.
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public int? SpeechRate { get; set; }

                    /// <summary>
                    /// The status of the speeches. Valid values:
                    /// 
                    /// *   **1**: The speeches are pending approval.
                    /// *   **2**: The speeches are approved.
                    /// *   **3**: The speeches are rejected.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// The content of the speech.
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// The sound effect that is used to broadcast speeches.
                    /// </summary>
                    [NameInMap("Voice")]
                    [Validation(Required=false)]
                    public string Voice { get; set; }

                    /// <summary>
                    /// The volume. Valid values: 0 to 100.
                    /// </summary>
                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
