// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ImAuditResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the image moderation QPS exceeds the limit. Valid values: true and false. A value of true indicates that the QPS does not exceed the limit. A value of false indicates that the QPS exceeds the limit.
        /// </summary>
        [NameInMap("ImageQuotaExceed")]
        [Validation(Required=false)]
        public bool? ImageQuotaExceed { get; set; }

        /// <summary>
        /// The image moderation results. If the HTTP status code 200 is returned, the array in the returned results contains one or more elements. For more information about the parameters, see [Data returned by the ImAudit operation](https://help.aliyun.com/document_detail/268644.html).
        /// </summary>
        [NameInMap("ImageResults")]
        [Validation(Required=false)]
        public ImAuditResponseBodyImageResults ImageResults { get; set; }
        public class ImAuditResponseBodyImageResults : TeaModel {
            /// <summary>
            /// The image moderation results.
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<ImAuditResponseBodyImageResultsResult> Result { get; set; }
            public class ImAuditResponseBodyImageResultsResult : TeaModel {
                /// <summary>
                /// The error code. The error code is the same as the HTTP status code. This parameter is not returned if the request is successful.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public long? Code { get; set; }

                /// <summary>
                /// The ID of the moderated object.
                /// 
                /// >  If you set the dataId parameter in the moderation request, the dataId parameter is returned in the response.
                /// </summary>
                [NameInMap("dataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// The additional information about the image. If ad is specified for the Scenes parameter, the following content may be returned for this parameter: hitLibInfo: the information about the custom text library that is hit by the text in the image. The value of this parameter is an array. For more information about the structure, see [hitLibInfo](https://help.aliyun.com/document_detail/268644.html).
                /// </summary>
                [NameInMap("extras")]
                [Validation(Required=false)]
                public Dictionary<string, object> Extras { get; set; }

                /// <summary>
                /// The message that is returned for the request.
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// The returned data. If the call is successful, the array in the returned results contains one or more elements. Each element is a struct.
                /// </summary>
                [NameInMap("results")]
                [Validation(Required=false)]
                public List<ImAuditResponseBodyImageResultsResultResults> Results { get; set; }
                public class ImAuditResponseBodyImageResultsResultResults : TeaModel {
                    /// <summary>
                    /// The category of the moderation results. Valid values vary based on the specified moderation scenario.
                    /// 
                    /// *   If the Scenes parameter is set to porn, the valid values are:
                    /// 
                    ///     *   normal: no pornographic content
                    ///     *   sexy: sexy content
                    ///     *   porn: pornographic content
                    /// 
                    /// *   If the Scenes parameter is set to terrorism, the valid values are:
                    /// 
                    ///     *   normal: no pornographic content
                    ///     *   bloody: bloody content
                    ///     *   explosion: explosions and smoke
                    ///     *   outfit: special costume
                    ///     *   logo: special logo
                    ///     *   weapon: weapon
                    ///     *   politics: political content
                    ///     *   violence: violence
                    ///     *   crowd: crowd
                    ///     *   parade: parade
                    ///     *   carcrash: car accident
                    ///     *   flag: flag
                    ///     *   location: landmark
                    ///     *   others: other content
                    /// 
                    /// *   If the Scenes parameter is set to ad, the valid values are:
                    /// 
                    ///     *   normal: no pornographic content
                    ///     *   ad: ad violation
                    ///     *   politics: politically sensitive content in text
                    ///     *   porn: pornographic content in text
                    ///     *   abuse: abuse in text
                    ///     *   terrorism: terrorist content in text
                    ///     *   contraband: prohibited content in text
                    ///     *   spam: junk content in text
                    ///     *   npx: illegal ad
                    ///     *   qrcode: QR code
                    ///     *   programCode: mini program code
                    /// 
                    /// *   If the Scenes parameter is set to qrcode, the valid values are:
                    /// 
                    ///     *   normal: no pornographic content
                    ///     *   qrcode: QR code
                    ///     *   programCode: mini program code
                    /// 
                    /// *   If the Scenes parameter is set to live, the valid values are:
                    /// 
                    ///     *   normal: no pornographic content
                    ///     *   meaningless: no content in the image, such as black or white screen
                    ///     *   PIP: picture-in-picture
                    ///     *   smoking: smoking
                    ///     *   drivelive: live broadcasting in a running vehicle
                    /// 
                    /// *   If the Scenes parameter is set to logo, the valid values are:
                    /// 
                    ///     *   normal: no pornographic content
                    ///     *   TV: controlled logo
                    ///     *   trademark: trademark
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The score of the confidence level. Valid values: 0 to 100. A greater value indicates a higher confidence level. If a value of pass is returned for the suggestion parameter, a higher confidence level indicates a higher probability that the content is normal. If a value of review or block is returned for the suggestion parameter, a higher confidence level indicates a higher probability that the content contains violations.
                    /// 
                    /// >  This score is for reference only. We strongly recommend that you do not use this score in your business. We recommend that you use the values that are returned for the suggestion, label, and sublabel parameters to determine whether the content contains violations. The sublabel parameter is returned by some operations.
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public double? Rate { get; set; }

                    /// <summary>
                    /// The image moderation scenario. Valid values:
                    /// 
                    /// *   porn: pornography
                    /// *   terrorism: terrorist content
                    /// *   ad: ad violation
                    /// *   qrcode: QR code
                    /// *   live: undesirable scene
                    /// *   logo: special logo
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// The recommended subsequent operation. Valid values:
                    /// 
                    /// *   pass: The content passes the moderation. No further actions are required.
                    /// *   review: The moderation object contains suspected violations and requires human review.
                    /// *   block: The moderation object contains violations. We recommend that you delete or block the object.
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// If the temporary access URL of the image is too long, a truncated temporary access URL is returned for each frame.
                    /// </summary>
                    [NameInMap("frames")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsFrames> Frames { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsFrames : TeaModel {
                        /// <summary>
                        /// The score of the confidence level. Valid values: 0 to 100. A higher confidence level indicates higher reliability of the moderation result. We recommend that you do not use this score in your business.
                        /// </summary>
                        [NameInMap("rate")]
                        [Validation(Required=false)]
                        public float? Rate { get; set; }

                        /// <summary>
                        /// The temporary access URL of the truncated frame. The URL is valid for 5 minutes.
                        /// </summary>
                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// The information about the term hit by the ad or violation text detected in the moderated image.
                    /// </summary>
                    [NameInMap("hintWordsInfo")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsHintWordsInfo> HintWordsInfo { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsHintWordsInfo : TeaModel {
                        /// <summary>
                        /// The term hit by the detected text.
                        /// </summary>
                        [NameInMap("context")]
                        [Validation(Required=false)]
                        public string Context { get; set; }

                    }

                    /// <summary>
                    /// The information about the logo detected in the moderated image.
                    /// </summary>
                    [NameInMap("logoData")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsLogoData> LogoData { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsLogoData : TeaModel {
                        /// <summary>
                        /// The height of the logo area. Unit: pixel.
                        /// </summary>
                        [NameInMap("h")]
                        [Validation(Required=false)]
                        public float? H { get; set; }

                        /// <summary>
                        /// The name of the detected logo.
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The type of the detected logo. For example, a value of TV indicates a controlled media logo.
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The width of the logo area. Unit: pixel.
                        /// </summary>
                        [NameInMap("w")]
                        [Validation(Required=false)]
                        public float? W { get; set; }

                        /// <summary>
                        /// The distance between the upper-left corner of the logo area and the y-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// The distance between the upper-left corner of the logo area and the x-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// ocrData
                    /// </summary>
                    [NameInMap("ocrData")]
                    [Validation(Required=false)]
                    public List<string> OcrData { get; set; }

                    /// <summary>
                    /// The location information of the mini program code detected in the moderated image.
                    /// </summary>
                    [NameInMap("programCodeData")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsProgramCodeData> ProgramCodeData { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsProgramCodeData : TeaModel {
                        /// <summary>
                        /// The height of the mini program code area. Unit: pixel.
                        /// </summary>
                        [NameInMap("h")]
                        [Validation(Required=false)]
                        public float? H { get; set; }

                        /// <summary>
                        /// The width of the mini program code area. Unit: pixel.
                        /// </summary>
                        [NameInMap("w")]
                        [Validation(Required=false)]
                        public float? W { get; set; }

                        /// <summary>
                        /// The distance between the upper-left corner of the mini program code area and the y-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// The distance between the upper-left corner of the mini program code area and the x-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// The information about the text that is included in the QR code detected in the moderated image.
                    /// </summary>
                    [NameInMap("qrcodeData")]
                    [Validation(Required=false)]
                    public List<string> QrcodeData { get; set; }

                    /// <summary>
                    /// The coordinates of the QR code detected in the image.
                    /// </summary>
                    [NameInMap("qrcodeLocations")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsQrcodeLocations> QrcodeLocations { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsQrcodeLocations : TeaModel {
                        /// <summary>
                        /// The height of the QR code area. Unit: pixel.
                        /// </summary>
                        [NameInMap("h")]
                        [Validation(Required=false)]
                        public float? H { get; set; }

                        /// <summary>
                        /// The URL that the detected QR code points to.
                        /// </summary>
                        [NameInMap("qrcode")]
                        [Validation(Required=false)]
                        public string Qrcode { get; set; }

                        /// <summary>
                        /// The width of the QR code area. Unit: pixel.
                        /// </summary>
                        [NameInMap("w")]
                        [Validation(Required=false)]
                        public float? W { get; set; }

                        /// <summary>
                        /// The distance between the upper-left corner of the QR code area and the y-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// The distance between the upper-left corner of the QR code area and the x-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// The information about the terrorist content detected in the moderated image.
                    /// </summary>
                    [NameInMap("sfaceData")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsSfaceData> SfaceData { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsSfaceData : TeaModel {
                        /// <summary>
                        /// The information about the face detected in the moderated image.
                        /// </summary>
                        [NameInMap("faces")]
                        [Validation(Required=false)]
                        public List<ImAuditResponseBodyImageResultsResultResultsSfaceDataFaces> Faces { get; set; }
                        public class ImAuditResponseBodyImageResultsResultResultsSfaceDataFaces : TeaModel {
                            /// <summary>
                            /// The ID of the detected face. The value is a string.
                            /// </summary>
                            [NameInMap("idid")]
                            [Validation(Required=false)]
                            public string Idid { get; set; }

                            /// <summary>
                            /// This value is a string, which indicates the name of a similar person.
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// The score of the confidence level. The value is a float point number. Valid values: 0 to 100. A greater value indicates a higher confidence level for facial recognition.
                            /// </summary>
                            [NameInMap("re")]
                            [Validation(Required=false)]
                            public float? Re { get; set; }

                        }

                        /// <summary>
                        /// The height of the face area. Unit: pixel.
                        /// </summary>
                        [NameInMap("h")]
                        [Validation(Required=false)]
                        public float? H { get; set; }

                        /// <summary>
                        /// The width of the face area. Unit: pixel.
                        /// </summary>
                        [NameInMap("w")]
                        [Validation(Required=false)]
                        public float? W { get; set; }

                        /// <summary>
                        /// The distance between the upper-left corner of the face area and the y-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// The distance between the upper-left corner of the face area and the y-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the moderation task.
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The URL of the moderated object.
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the text moderation QPS exceeds the limit. Valid values: true and false.
        /// </summary>
        [NameInMap("TextQuotaExceed")]
        [Validation(Required=false)]
        public bool? TextQuotaExceed { get; set; }

        /// <summary>
        /// The text moderation results. If the HTTP status code 200 is returned, the array in the returned results contains one or more elements. For more information about the parameters, see [Data returned by the ImAudit operation](https://help.aliyun.com/document_detail/268644.html).
        /// </summary>
        [NameInMap("TextResults")]
        [Validation(Required=false)]
        public ImAuditResponseBodyTextResults TextResults { get; set; }
        public class ImAuditResponseBodyTextResults : TeaModel {
            /// <summary>
            /// The text moderation results.
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<ImAuditResponseBodyTextResultsResult> Result { get; set; }
            public class ImAuditResponseBodyTextResultsResult : TeaModel {
                /// <summary>
                /// The error code. The error code is the same as the HTTP status code. For more information, see [Error codes](https://help.aliyun.com/document_detail/29254.html).
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public long? Code { get; set; }

                /// <summary>
                /// The text that you specify in the moderation request.
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The sequence number of the text.
                /// </summary>
                [NameInMap("dataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// The message that is returned for the request.
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// The returned data. If the HTTP status code 200 is returned, the array in the returned results contains one or more elements. Each element is a struct.
                /// </summary>
                [NameInMap("results")]
                [Validation(Required=false)]
                public List<ImAuditResponseBodyTextResultsResultResults> Results { get; set; }
                public class ImAuditResponseBodyTextResultsResultResults : TeaModel {
                    /// <summary>
                    /// The risky content that the moderated text hits. A text entry can hit multiple pieces of risky content.
                    /// </summary>
                    [NameInMap("details")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyTextResultsResultResultsDetails> Details { get; set; }
                    public class ImAuditResponseBodyTextResultsResultResultsDetails : TeaModel {
                        /// <summary>
                        /// The category of the risky content that the moderated text hits. Valid values:
                        /// 
                        /// *   spam: spam
                        /// *   ad: ad
                        /// *   politics: political content
                        /// *   terrorism: terrorist content
                        /// *   abuse: abuse
                        /// *   porn: pornographic content
                        /// *   flood: excessive junk content
                        /// *   contraband: prohibited content
                        /// *   meaningless: meaningless content
                        /// *   customized: custom content, such as a custom keyword
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// The context information of the risky content that the moderated text hits.
                        /// </summary>
                        [NameInMap("contexts")]
                        [Validation(Required=false)]
                        public List<ImAuditResponseBodyTextResultsResultResultsDetailsContexts> Contexts { get; set; }
                        public class ImAuditResponseBodyTextResultsResultResultsDetailsContexts : TeaModel {
                            /// <summary>
                            /// The term that the moderated text hits. If the text hits a term, the term is returned. If the text hits the algorithmic model, this parameter is not returned.
                            /// </summary>
                            [NameInMap("context")]
                            [Validation(Required=false)]
                            public string Context { get; set; }

                            /// <summary>
                            /// The code of the custom text library. This parameter is returned if the moderated text hits a term in the custom text library.
                            /// </summary>
                            [NameInMap("libCode")]
                            [Validation(Required=false)]
                            public string LibCode { get; set; }

                            /// <summary>
                            /// The name of the custom text library. This parameter is returned if the moderated text hits a term in the custom text library.
                            /// </summary>
                            [NameInMap("libName")]
                            [Validation(Required=false)]
                            public string LibName { get; set; }

                            /// <summary>
                            /// The position of the term that the moderated text hits in the original text.
                            /// </summary>
                            [NameInMap("positions")]
                            [Validation(Required=false)]
                            public List<string> Positions { get; set; }

                            /// <summary>
                            /// The behavior rule. This parameter is returned if the moderated text hits the behavior rule. Valid values:
                            /// 
                            /// *   user_id
                            /// *   ip
                            /// *   umid
                            /// *   content
                            /// *   similar_content
                            /// *   imei
                            /// *   imsi
                            /// </summary>
                            [NameInMap("ruleType")]
                            [Validation(Required=false)]
                            public string RuleType { get; set; }

                        }

                    }

                    /// <summary>
                    /// The category of the moderation result for the moderated text. Valid values:
                    /// 
                    /// *   normal: normal content
                    /// *   spam: spam
                    /// *   ad: ad
                    /// *   politics: political content
                    /// *   terrorism: terrorist content
                    /// *   abuse: abuse
                    /// *   porn: pornographic content
                    /// *   flood: excessive junk content
                    /// *   contraband: prohibited content
                    /// *   meaningless: meaningless content
                    /// *   customized: custom content, such as a custom keyword
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The score of the confidence level. Valid values: 0 to 100. A greater value indicates a higher confidence level. If a value of pass is returned for the suggestion parameter, a higher confidence level indicates a higher probability that the content is normal. If a value of review or block is returned for the suggestion parameter, a higher confidence level indicates a higher probability that the content contains violations.
                    /// 
                    /// >  This score is for reference only. We strongly recommend that you do not use this score in your business. We recommend that you use the values that are returned for the suggestion, label, and sublabel parameters to determine whether the content contains violations. The sublabel parameter is returned by some operations.
                    /// </summary>
                    [NameInMap("rate")]
                    [Validation(Required=false)]
                    public double? Rate { get; set; }

                    /// <summary>
                    /// The moderation scenario.
                    /// </summary>
                    [NameInMap("scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// The recommended subsequent operation. Valid values:
                    /// 
                    /// *   pass: The content passes the moderation.
                    /// *   review: The content needs to be manually reviewed again.
                    /// *   block: The content contains violations. We recommend that you delete or block the content.
                    /// </summary>
                    [NameInMap("suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// The ID of the moderation task.
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

    }

}
