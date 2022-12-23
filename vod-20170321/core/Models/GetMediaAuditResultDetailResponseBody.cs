// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultDetailResponseBody : TeaModel {
        /// <summary>
        /// Details about review results.
        /// </summary>
        [NameInMap("MediaAuditResultDetail")]
        [Validation(Required=false)]
        public GetMediaAuditResultDetailResponseBodyMediaAuditResultDetail MediaAuditResultDetail { get; set; }
        public class GetMediaAuditResultDetailResponseBodyMediaAuditResultDetail : TeaModel {
            /// <summary>
            /// The review results returned.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultDetailResponseBodyMediaAuditResultDetailList> List { get; set; }
            public class GetMediaAuditResultDetailResponseBodyMediaAuditResultDetailList : TeaModel {
                /// <summary>
                /// The category of the ad review result. Valid values:
                /// 
                /// *   **normal**: normal content
                /// *   **ad**: ad or text violation
                /// </summary>
                [NameInMap("AdLabel")]
                [Validation(Required=false)]
                public string AdLabel { get; set; }

                /// <summary>
                /// The score of the review result category. It is representative of the confidence. Valid values: `[0.00-100.00].` The value is rounded down to 10 decimal places.
                /// </summary>
                [NameInMap("AdScore")]
                [Validation(Required=false)]
                public string AdScore { get; set; }

                /// <summary>
                /// The category of the undesirable scene review result. Valid values:
                /// 
                /// *   **normal**: The video does not contain undesirable scenes.
                /// *   **live**: The video contains undesirable scenes.
                /// </summary>
                [NameInMap("LiveLabel")]
                [Validation(Required=false)]
                public string LiveLabel { get; set; }

                /// <summary>
                /// The score of the review result category. It is representative of the confidence. Valid values: `[0.00-100.00].` The value is rounded down to 10 decimal places.
                /// </summary>
                [NameInMap("LiveScore")]
                [Validation(Required=false)]
                public string LiveScore { get; set; }

                /// <summary>
                /// The category of the logo review result. Valid values:
                /// 
                /// *   **normal**
                /// *   **tlogo**
                /// </summary>
                [NameInMap("LogoLabel")]
                [Validation(Required=false)]
                public string LogoLabel { get; set; }

                /// <summary>
                /// The score of the review result category. It is representative of the confidence. Valid values: `[0.00-100.00].` The value is rounded down to 10 decimal places.
                /// </summary>
                [NameInMap("LogoScore")]
                [Validation(Required=false)]
                public string LogoScore { get; set; }

                /// <summary>
                /// The category of the pornographic content review result. Valid values:
                /// 
                /// *   **normal**
                /// *   **porn**
                /// *   **sexy**
                /// </summary>
                [NameInMap("PornLabel")]
                [Validation(Required=false)]
                public string PornLabel { get; set; }

                /// <summary>
                /// The score of the review result category. It is representative of the confidence. Valid values: `[0.00-100.00].` The value is rounded down to 10 decimal places.
                /// </summary>
                [NameInMap("PornScore")]
                [Validation(Required=false)]
                public string PornScore { get; set; }

                /// <summary>
                /// The category of the terrorist content review result.
                /// 
                /// *   **normal**: normal
                /// *   **terrorism**: terrorist content
                /// *   **outfit**: special costume
                /// *   **logo**: special logo
                /// *   **weapon**: weapon
                /// *   **politics**: politically sensitive content
                /// *   **others**: other terrorist content and politically sensitive content
                /// </summary>
                [NameInMap("TerrorismLabel")]
                [Validation(Required=false)]
                public string TerrorismLabel { get; set; }

                /// <summary>
                /// The score of the review result category. It is representative of the confidence. Valid values: `[0.00-100.00].` The value is rounded down to 10 decimal places.
                /// </summary>
                [NameInMap("TerrorismScore")]
                [Validation(Required=false)]
                public string TerrorismScore { get; set; }

                /// <summary>
                /// The position in the video. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// The URL of the image.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// The total number of snapshots returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
