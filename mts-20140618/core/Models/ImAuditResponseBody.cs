// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ImAuditResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the image moderation QPS exceeds the limit. Valid values: true and false. A value of true indicates that the QPS does not exceed the limit. A value of false indicates that the QPS exceeds the limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ImageQuotaExceed")]
        [Validation(Required=false)]
        public bool? ImageQuotaExceed { get; set; }

        /// <summary>
        /// <para>The image moderation results. If the HTTP status code 200 is returned, the array in the returned results contains one or more elements. For more information about the parameters, see <a href="https://help.aliyun.com/document_detail/268644.html">Data returned by the ImAudit operation</a>.</para>
        /// </summary>
        [NameInMap("ImageResults")]
        [Validation(Required=false)]
        public ImAuditResponseBodyImageResults ImageResults { get; set; }
        public class ImAuditResponseBodyImageResults : TeaModel {
            /// <summary>
            /// <para>The image moderation results.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<ImAuditResponseBodyImageResultsResult> Result { get; set; }
            public class ImAuditResponseBodyImageResultsResult : TeaModel {
                /// <summary>
                /// <para>The error code. The error code is the same as the HTTP status code. This parameter is not returned if the request is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public long? Code { get; set; }

                /// <summary>
                /// <para>The ID of the moderated object.</para>
                /// <remarks>
                /// <para> If you set the dataId parameter in the moderation request, the dataId parameter is returned in the response.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>uuid-1234-1234-1234</para>
                /// </summary>
                [NameInMap("dataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>The additional information about the image. If ad is specified for the Scenes parameter, the following content may be returned for this parameter: hitLibInfo: the information about the custom text library that is hit by the text in the image. The value of this parameter is an array. For more information about the structure, see <a href="https://help.aliyun.com/document_detail/268644.html">hitLibInfo</a>.</para>
                /// </summary>
                [NameInMap("extras")]
                [Validation(Required=false)]
                public Dictionary<string, object> Extras { get; set; }

                /// <summary>
                /// <para>The message that is returned for the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The returned data. If the call is successful, the array in the returned results contains one or more elements. Each element is a struct.</para>
                /// </summary>
                [NameInMap("results")]
                [Validation(Required=false)]
                public List<ImAuditResponseBodyImageResultsResultResults> Results { get; set; }
                public class ImAuditResponseBodyImageResultsResultResults : TeaModel {
                    /// <summary>
                    /// <para>The category of the moderation results. Valid values vary based on the specified moderation scenario.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If the Scenes parameter is set to porn, the valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description>normal: no pornographic content</description></item>
                    /// <item><description>sexy: sexy content</description></item>
                    /// <item><description>porn: pornographic content</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>If the Scenes parameter is set to terrorism, the valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description>normal: no pornographic content</description></item>
                    /// <item><description>bloody: bloody content</description></item>
                    /// <item><description>explosion: explosions and smoke</description></item>
                    /// <item><description>outfit: special costume</description></item>
                    /// <item><description>logo: special logo</description></item>
                    /// <item><description>weapon: weapon</description></item>
                    /// <item><description>politics: political content</description></item>
                    /// <item><description>violence: violence</description></item>
                    /// <item><description>crowd: crowd</description></item>
                    /// <item><description>parade: parade</description></item>
                    /// <item><description>carcrash: car accident</description></item>
                    /// <item><description>flag: flag</description></item>
                    /// <item><description>location: landmark</description></item>
                    /// <item><description>others: other content</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>If the Scenes parameter is set to ad, the valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description>normal: no pornographic content</description></item>
                    /// <item><description>ad: ad violation</description></item>
                    /// <item><description>politics: politically sensitive content in text</description></item>
                    /// <item><description>porn: pornographic content in text</description></item>
                    /// <item><description>abuse: abuse in text</description></item>
                    /// <item><description>terrorism: terrorist content in text</description></item>
                    /// <item><description>contraband: prohibited content in text</description></item>
                    /// <item><description>spam: junk content in text</description></item>
                    /// <item><description>npx: illegal ad</description></item>
                    /// <item><description>qrcode: QR code</description></item>
                    /// <item><description>programCode: mini program code</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>If the Scenes parameter is set to qrcode, the valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description>normal: no pornographic content</description></item>
                    /// <item><description>qrcode: QR code</description></item>
                    /// <item><description>programCode: mini program code</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>If the Scenes parameter is set to live, the valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description>normal: no pornographic content</description></item>
                    /// <item><description>meaningless: no content in the image, such as black or white screen</description></item>
                    /// <item><description>PIP: picture-in-picture</description></item>
                    /// <item><description>smoking: smoking</description></item>
                    /// <item><description>drivelive: live broadcasting in a running vehicle</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>If the Scenes parameter is set to logo, the valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description>normal: no pornographic content</description></item>
                    /// <item><description>TV: controlled logo</description></item>
                    /// <item><description>trademark: trademark</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sexy</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The score of the confidence level. Valid values: 0 to 100. A greater value indicates a higher confidence level. If a value of pass is returned for the suggestion parameter, a higher confidence level indicates a higher probability that the content is normal. If a value of review or block is returned for the suggestion parameter, a higher confidence level indicates a higher probability that the content contains violations.</para>
                    /// <remarks>
                    /// <para> This score is for reference only. We strongly recommend that you do not use this score in your business. We recommend that you use the values that are returned for the suggestion, label, and sublabel parameters to determine whether the content contains violations. The sublabel parameter is returned by some operations.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>91.54</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public double? Rate { get; set; }

                    /// <summary>
                    /// <para>The image moderation scenario. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>porn: pornography</description></item>
                    /// <item><description>terrorism: terrorist content</description></item>
                    /// <item><description>ad: ad violation</description></item>
                    /// <item><description>qrcode: QR code</description></item>
                    /// <item><description>live: undesirable scene</description></item>
                    /// <item><description>logo: special logo</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The recommended subsequent operation. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>pass: The content passes the moderation. No further actions are required.</description></item>
                    /// <item><description>review: The moderation object contains suspected violations and requires human review.</description></item>
                    /// <item><description>block: The moderation object contains violations. We recommend that you delete or block the object.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    /// <summary>
                    /// <para>If the temporary access URL of the image is too long, a truncated temporary access URL is returned for each frame.</para>
                    /// </summary>
                    [NameInMap("frames")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsFrames> Frames { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsFrames : TeaModel {
                        /// <summary>
                        /// <para>The score of the confidence level. Valid values: 0 to 100. A higher confidence level indicates higher reliability of the moderation result. We recommend that you do not use this score in your business.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>89.85</para>
                        /// </summary>
                        [NameInMap("rate")]
                        [Validation(Required=false)]
                        public float? Rate { get; set; }

                        /// <summary>
                        /// <para>The temporary access URL of the truncated frame. The URL is valid for 5 minutes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://example.com/test-01.jpg">http://example.com/test-01.jpg</a></para>
                        /// </summary>
                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the term hit by the ad or violation text detected in the moderated image.</para>
                    /// </summary>
                    [NameInMap("hintWordsInfo")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsHintWordsInfo> HintWordsInfo { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsHintWordsInfo : TeaModel {
                        /// <summary>
                        /// <para>The term hit by the detected text.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Sensitive words</para>
                        /// </summary>
                        [NameInMap("context")]
                        [Validation(Required=false)]
                        public string Context { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the logo detected in the moderated image.</para>
                    /// </summary>
                    [NameInMap("logoData")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsLogoData> LogoData { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsLogoData : TeaModel {
                        /// <summary>
                        /// <para>The height of the logo area. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>106</para>
                        /// </summary>
                        [NameInMap("h")]
                        [Validation(Required=false)]
                        public float? H { get; set; }

                        /// <summary>
                        /// <para>The name of the detected logo.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Hunan TV</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The type of the detected logo. For example, a value of TV indicates a controlled media logo.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TV</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The width of the logo area. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>106</para>
                        /// </summary>
                        [NameInMap("w")]
                        [Validation(Required=false)]
                        public float? W { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper-left corner of the logo area and the y-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>140</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper-left corner of the logo area and the x-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>68</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>ocrData</para>
                    /// </summary>
                    [NameInMap("ocrData")]
                    [Validation(Required=false)]
                    public List<string> OcrData { get; set; }

                    /// <summary>
                    /// <para>The location information of the mini program code detected in the moderated image.</para>
                    /// </summary>
                    [NameInMap("programCodeData")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsProgramCodeData> ProgramCodeData { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsProgramCodeData : TeaModel {
                        /// <summary>
                        /// <para>The height of the mini program code area. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>413.0</para>
                        /// </summary>
                        [NameInMap("h")]
                        [Validation(Required=false)]
                        public float? H { get; set; }

                        /// <summary>
                        /// <para>The width of the mini program code area. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>402.0</para>
                        /// </summary>
                        [NameInMap("w")]
                        [Validation(Required=false)]
                        public float? W { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper-left corner of the mini program code area and the y-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11.0</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper-left corner of the mini program code area and the x-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the text that is included in the QR code detected in the moderated image.</para>
                    /// </summary>
                    [NameInMap("qrcodeData")]
                    [Validation(Required=false)]
                    public List<string> QrcodeData { get; set; }

                    /// <summary>
                    /// <para>The coordinates of the QR code detected in the image.</para>
                    /// </summary>
                    [NameInMap("qrcodeLocations")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsQrcodeLocations> QrcodeLocations { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsQrcodeLocations : TeaModel {
                        /// <summary>
                        /// <para>The height of the QR code area. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>413.0</para>
                        /// </summary>
                        [NameInMap("h")]
                        [Validation(Required=false)]
                        public float? H { get; set; }

                        /// <summary>
                        /// <para>The URL that the detected QR code points to.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://xxx">http://xxx</a></para>
                        /// </summary>
                        [NameInMap("qrcode")]
                        [Validation(Required=false)]
                        public string Qrcode { get; set; }

                        /// <summary>
                        /// <para>The width of the QR code area. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>402.0</para>
                        /// </summary>
                        [NameInMap("w")]
                        [Validation(Required=false)]
                        public float? W { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper-left corner of the QR code area and the y-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper-left corner of the QR code area and the x-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the terrorist content detected in the moderated image.</para>
                    /// </summary>
                    [NameInMap("sfaceData")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyImageResultsResultResultsSfaceData> SfaceData { get; set; }
                    public class ImAuditResponseBodyImageResultsResultResultsSfaceData : TeaModel {
                        /// <summary>
                        /// <para>The information about the face detected in the moderated image.</para>
                        /// </summary>
                        [NameInMap("faces")]
                        [Validation(Required=false)]
                        public List<ImAuditResponseBodyImageResultsResultResultsSfaceDataFaces> Faces { get; set; }
                        public class ImAuditResponseBodyImageResultsResultResultsSfaceDataFaces : TeaModel {
                            /// <summary>
                            /// <para>The ID of the detected face. The value is a string.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>AliFace_0001234</para>
                            /// </summary>
                            [NameInMap("idid")]
                            [Validation(Required=false)]
                            public string Idid { get; set; }

                            /// <summary>
                            /// <para>This value is a string, which indicates the name of a similar person.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Name</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The score of the confidence level. The value is a float point number. Valid values: 0 to 100. A greater value indicates a higher confidence level for facial recognition.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>91.54</para>
                            /// </summary>
                            [NameInMap("re")]
                            [Validation(Required=false)]
                            public float? Re { get; set; }

                        }

                        /// <summary>
                        /// <para>The height of the face area. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>121</para>
                        /// </summary>
                        [NameInMap("h")]
                        [Validation(Required=false)]
                        public float? H { get; set; }

                        /// <summary>
                        /// <para>The width of the face area. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>47</para>
                        /// </summary>
                        [NameInMap("w")]
                        [Validation(Required=false)]
                        public float? W { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper-left corner of the face area and the y-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>49</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <para>The distance between the upper-left corner of the face area and the y-axis, with the upper-left corner of the image being the coordinate origin. Unit: pixel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>39</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the moderation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>img4wlJcb7p4wH4lAP3111111-12****</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The URL of the moderated object.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/example-****.jpg">http://example.com/example-****.jpg</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5210DBB0-E327-4D45-ADBC-0B83C8793421</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the text moderation QPS exceeds the limit. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TextQuotaExceed")]
        [Validation(Required=false)]
        public bool? TextQuotaExceed { get; set; }

        /// <summary>
        /// <para>The text moderation results. If the HTTP status code 200 is returned, the array in the returned results contains one or more elements. For more information about the parameters, see <a href="https://help.aliyun.com/document_detail/268644.html">Data returned by the ImAudit operation</a>.</para>
        /// </summary>
        [NameInMap("TextResults")]
        [Validation(Required=false)]
        public ImAuditResponseBodyTextResults TextResults { get; set; }
        public class ImAuditResponseBodyTextResults : TeaModel {
            /// <summary>
            /// <para>The text moderation results.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<ImAuditResponseBodyTextResultsResult> Result { get; set; }
            public class ImAuditResponseBodyTextResultsResult : TeaModel {
                /// <summary>
                /// <para>The error code. The error code is the same as the HTTP status code. For more information, see <a href="https://help.aliyun.com/document_detail/29254.html">Error codes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public long? Code { get; set; }

                /// <summary>
                /// <para>The text that you specify in the moderation request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is test text.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The sequence number of the text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cfd33235-71a4-468b-8137-a5ffe323****</para>
                /// </summary>
                [NameInMap("dataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>The message that is returned for the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The returned data. If the HTTP status code 200 is returned, the array in the returned results contains one or more elements. Each element is a struct.</para>
                /// </summary>
                [NameInMap("results")]
                [Validation(Required=false)]
                public List<ImAuditResponseBodyTextResultsResultResults> Results { get; set; }
                public class ImAuditResponseBodyTextResultsResultResults : TeaModel {
                    /// <summary>
                    /// <para>The risky content that the moderated text hits. A text entry can hit multiple pieces of risky content.</para>
                    /// </summary>
                    [NameInMap("details")]
                    [Validation(Required=false)]
                    public List<ImAuditResponseBodyTextResultsResultResultsDetails> Details { get; set; }
                    public class ImAuditResponseBodyTextResultsResultResultsDetails : TeaModel {
                        /// <summary>
                        /// <para>The category of the risky content that the moderated text hits. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>spam: spam</description></item>
                        /// <item><description>ad: ad</description></item>
                        /// <item><description>politics: political content</description></item>
                        /// <item><description>terrorism: terrorist content</description></item>
                        /// <item><description>abuse: abuse</description></item>
                        /// <item><description>porn: pornographic content</description></item>
                        /// <item><description>flood: excessive junk content</description></item>
                        /// <item><description>contraband: prohibited content</description></item>
                        /// <item><description>meaningless: meaningless content</description></item>
                        /// <item><description>customized: custom content, such as a custom keyword</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>porn</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The context information of the risky content that the moderated text hits.</para>
                        /// </summary>
                        [NameInMap("contexts")]
                        [Validation(Required=false)]
                        public List<ImAuditResponseBodyTextResultsResultResultsDetailsContexts> Contexts { get; set; }
                        public class ImAuditResponseBodyTextResultsResultResultsDetailsContexts : TeaModel {
                            /// <summary>
                            /// <para>The term that the moderated text hits. If the text hits a term, the term is returned. If the text hits the algorithmic model, this parameter is not returned.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Door-to-door service</para>
                            /// </summary>
                            [NameInMap("context")]
                            [Validation(Required=false)]
                            public string Context { get; set; }

                            /// <summary>
                            /// <para>The code of the custom text library. This parameter is returned if the moderated text hits a term in the custom text library.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>123456</para>
                            /// </summary>
                            [NameInMap("libCode")]
                            [Validation(Required=false)]
                            public string LibCode { get; set; }

                            /// <summary>
                            /// <para>The name of the custom text library. This parameter is returned if the moderated text hits a term in the custom text library.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Name of your custom text library</para>
                            /// </summary>
                            [NameInMap("libName")]
                            [Validation(Required=false)]
                            public string LibName { get; set; }

                            /// <summary>
                            /// <para>The position of the term that the moderated text hits in the original text.</para>
                            /// </summary>
                            [NameInMap("positions")]
                            [Validation(Required=false)]
                            public List<string> Positions { get; set; }

                            /// <summary>
                            /// <para>The behavior rule. This parameter is returned if the moderated text hits the behavior rule. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>user_id</description></item>
                            /// <item><description>ip</description></item>
                            /// <item><description>umid</description></item>
                            /// <item><description>content</description></item>
                            /// <item><description>similar_content</description></item>
                            /// <item><description>imei</description></item>
                            /// <item><description>imsi</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ip</para>
                            /// </summary>
                            [NameInMap("ruleType")]
                            [Validation(Required=false)]
                            public string RuleType { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The category of the moderation result for the moderated text. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>normal: normal content</description></item>
                    /// <item><description>spam: spam</description></item>
                    /// <item><description>ad: ad</description></item>
                    /// <item><description>politics: political content</description></item>
                    /// <item><description>terrorism: terrorist content</description></item>
                    /// <item><description>abuse: abuse</description></item>
                    /// <item><description>porn: pornographic content</description></item>
                    /// <item><description>flood: excessive junk content</description></item>
                    /// <item><description>contraband: prohibited content</description></item>
                    /// <item><description>meaningless: meaningless content</description></item>
                    /// <item><description>customized: custom content, such as a custom keyword</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>porn</para>
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The score of the confidence level. Valid values: 0 to 100. A greater value indicates a higher confidence level. If a value of pass is returned for the suggestion parameter, a higher confidence level indicates a higher probability that the content is normal. If a value of review or block is returned for the suggestion parameter, a higher confidence level indicates a higher probability that the content contains violations.</para>
                    /// <remarks>
                    /// <para> This score is for reference only. We strongly recommend that you do not use this score in your business. We recommend that you use the values that are returned for the suggestion, label, and sublabel parameters to determine whether the content contains violations. The sublabel parameter is returned by some operations.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>99.90</para>
                    /// </summary>
                    [NameInMap("rate")]
                    [Validation(Required=false)]
                    public double? Rate { get; set; }

                    /// <summary>
                    /// <para>The moderation scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>antispam</para>
                    /// </summary>
                    [NameInMap("scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The recommended subsequent operation. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>pass: The content passes the moderation.</description></item>
                    /// <item><description>review: The content needs to be manually reviewed again.</description></item>
                    /// <item><description>block: The content contains violations. We recommend that you delete or block the content.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <para>The ID of the moderation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>txt6HB8NQoEbU@5fosnj2xVEM-1t****</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

    }

}
