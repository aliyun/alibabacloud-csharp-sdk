// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PageQuerySpeechBroadcastHourResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The result returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PageQuerySpeechBroadcastHourResponseBodyData Data { get; set; }
        public class PageQuerySpeechBroadcastHourResponseBodyData : TeaModel {
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
            /// A pagination token. It can be used in the next request to retrieve a new page of results.
            /// 
            /// If **PageToken** is empty, no next page exists.
            /// </summary>
            [NameInMap("PageToken")]
            [Validation(Required=false)]
            public string PageToken { get; set; }

            /// <summary>
            /// The shared speech broadcasting data returned.
            /// </summary>
            [NameInMap("ResultData")]
            [Validation(Required=false)]
            public PageQuerySpeechBroadcastHourResponseBodyDataResultData ResultData { get; set; }
            public class PageQuerySpeechBroadcastHourResponseBodyDataResultData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<PageQuerySpeechBroadcastHourResponseBodyDataResultDataData> Data { get; set; }
                public class PageQuerySpeechBroadcastHourResponseBodyDataResultDataData : TeaModel {
                    /// <summary>
                    /// Indicates whether the speech was successfully broadcasted. Valid values:
                    /// 
                    /// *   **0**: The speech was successfully broadcasted.
                    /// *   **1**: The speech was repeatedly broadcasted.
                    /// *   **2**: The speech does not exist.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// The DeviceName of the device.
                    /// </summary>
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    /// <summary>
                    /// The message that indicates the speech broadcasting result.
                    /// </summary>
                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    /// <summary>
                    /// The **ProductKey** of the product to which the device belongs.
                    /// </summary>
                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    /// <summary>
                    /// The code of the sharing task.
                    /// </summary>
                    [NameInMap("ShareTaskCode")]
                    [Validation(Required=false)]
                    public string ShareTaskCode { get; set; }

                    /// <summary>
                    /// The ID of the speech that was broadcasted.
                    /// </summary>
                    [NameInMap("SpeechId")]
                    [Validation(Required=false)]
                    public string SpeechId { get; set; }

                    /// <summary>
                    /// The content of the broadcasted speech. The parameter value is a JSON array.
                    /// </summary>
                    [NameInMap("Speechs")]
                    [Validation(Required=false)]
                    public string Speechs { get; set; }

                    /// <summary>
                    /// The start time of speech broadcasting. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
