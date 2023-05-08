// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotPresetResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the honeypot template.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotPresetResponseBodyData Data { get; set; }
        public class GetHoneypotPresetResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the management node.
            /// </summary>
            [NameInMap("ControlNodeName")]
            [Validation(Required=false)]
            public string ControlNodeName { get; set; }

            /// <summary>
            /// An array that consists of the configurations of the uploaded file.
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetHoneypotPresetResponseBodyDataFileInfoList> FileInfoList { get; set; }
            public class GetHoneypotPresetResponseBodyDataFileInfoList : TeaModel {
                /// <summary>
                /// The ID of the uploaded file.
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// The name of the uploaded file.
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// The download URL.
                /// </summary>
                [NameInMap("OssUrl")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

            }

            /// <summary>
            /// The display name of the honeypot image.
            /// </summary>
            [NameInMap("HoneypotImageDisplayName")]
            [Validation(Required=false)]
            public string HoneypotImageDisplayName { get; set; }

            /// <summary>
            /// The name of the honeypot image.
            /// </summary>
            [NameInMap("HoneypotImageName")]
            [Validation(Required=false)]
            public string HoneypotImageName { get; set; }

            /// <summary>
            /// The ID of the honeypot template.
            /// </summary>
            [NameInMap("HoneypotPresetId")]
            [Validation(Required=false)]
            public string HoneypotPresetId { get; set; }

            /// <summary>
            /// The custom configuration of the honeypot template.
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// The ID of the management node.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The custom name of the honeypot template.
            /// </summary>
            [NameInMap("PresetName")]
            [Validation(Required=false)]
            public string PresetName { get; set; }

            /// <summary>
            /// The type of the honeypot template. Valid values:
            /// 
            /// *   **TEMP**: automatically generated template
            /// *   **CUSTOM**: custom template
            /// *   **DEFAULT**: default template
            /// </summary>
            [NameInMap("PresetType")]
            [Validation(Required=false)]
            public string PresetType { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
