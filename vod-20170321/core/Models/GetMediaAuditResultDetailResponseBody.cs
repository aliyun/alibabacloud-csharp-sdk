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
                /// The category of the review result. Valid values:
                /// 
                /// *   **normal**: normal content.
                /// *   **ad**: other ads.
                /// *   **politics**: political content in text.
                /// *   **porn**: pornographic content in text.
                /// *   **abuse**: verbal abuse in text.
                /// *   **terrorism**: terrorist content in text.
                /// *   **contraband**: prohibited content in text.
                /// *   **spam**: spam content in text.
                /// *   **npx**: illegal ad
                /// *   **qrcode**: QR code.
                /// *   **programCode**: mini program code.
                /// </summary>
                [NameInMap("AdLabel")]
                [Validation(Required=false)]
                public string AdLabel { get; set; }

                /// <summary>
                /// The score of the video snapshot in the ad review result. Valid values: `[0,100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("AdScore")]
                [Validation(Required=false)]
                public string AdScore { get; set; }

                /// <summary>
                /// The category of the review result. Valid values:
                /// 
                /// *   **normal**: normal content.
                /// *   **meaningless**: meaningless content, such as a black or white screen.
                /// *   **PIP**: picture-in-picture.
                /// *   **smoking**: smoking.
                /// *   **drivelive**: live broadcasting in a running vehicle.
                /// </summary>
                [NameInMap("LiveLabel")]
                [Validation(Required=false)]
                public string LiveLabel { get; set; }

                /// <summary>
                /// The score of the video snapshot in the undesirable content review result. Valid values: `[0,100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("LiveScore")]
                [Validation(Required=false)]
                public string LiveScore { get; set; }

                /// <summary>
                /// The category of the review result. Valid values:
                /// 
                /// *   **normal**: normal content.
                /// *   **TV**: controlled TV station logo.
                /// *   **trademark**: trademark.
                /// </summary>
                [NameInMap("LogoLabel")]
                [Validation(Required=false)]
                public string LogoLabel { get; set; }

                /// <summary>
                /// The score of the video snapshot in the logo review result. Valid values: `[0,100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("LogoScore")]
                [Validation(Required=false)]
                public string LogoScore { get; set; }

                /// <summary>
                /// The category of the review result. Valid values:
                /// 
                /// *   **normal**
                /// *   **porn**
                /// *   **sexy**
                /// </summary>
                [NameInMap("PornLabel")]
                [Validation(Required=false)]
                public string PornLabel { get; set; }

                /// <summary>
                /// The score of the video snapshot in the pornographic content review result. Valid values: `[0,100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("PornScore")]
                [Validation(Required=false)]
                public string PornScore { get; set; }

                /// <summary>
                /// The category of the review result. Valid values:
                /// 
                /// *   **normal**
                /// *   **bloody**
                /// *   **explosion**
                /// *   **outfit**
                /// *   **logo**
                /// *   **weapon**
                /// *   **politics**
                /// *   **violence**
                /// *   **crowd**
                /// *   **parade**
                /// *   **carcrash**
                /// *   **flag**
                /// *   **location**
                /// *   **others**
                /// </summary>
                [NameInMap("TerrorismLabel")]
                [Validation(Required=false)]
                public string TerrorismLabel { get; set; }

                /// <summary>
                /// The score of the video snapshot in the terrorist content review result. Valid values: `[0,100]`. The value is rounded down to 10 decimal places. The score is representative of the confidence.
                /// </summary>
                [NameInMap("TerrorismScore")]
                [Validation(Required=false)]
                public string TerrorismScore { get; set; }

                /// <summary>
                /// The timestamp of the snapshot in the video. Unit: milliseconds.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// The URL of the video snapshot.
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
