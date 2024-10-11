// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditResultDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about review results.</para>
        /// </summary>
        [NameInMap("MediaAuditResultDetail")]
        [Validation(Required=false)]
        public GetMediaAuditResultDetailResponseBodyMediaAuditResultDetail MediaAuditResultDetail { get; set; }
        public class GetMediaAuditResultDetailResponseBodyMediaAuditResultDetail : TeaModel {
            /// <summary>
            /// <para>The review results returned.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetMediaAuditResultDetailResponseBodyMediaAuditResultDetailList> List { get; set; }
            public class GetMediaAuditResultDetailResponseBodyMediaAuditResultDetailList : TeaModel {
                /// <summary>
                /// <para>The category of the review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal content.</description></item>
                /// <item><description><b>ad</b>: other ads.</description></item>
                /// <item><description><b>politics</b>: political content in text.</description></item>
                /// <item><description><b>porn</b>: pornographic content in text.</description></item>
                /// <item><description><b>abuse</b>: verbal abuse in text.</description></item>
                /// <item><description><b>terrorism</b>: terrorist content in text.</description></item>
                /// <item><description><b>contraband</b>: prohibited content in text.</description></item>
                /// <item><description><b>spam</b>: spam content in text.</description></item>
                /// <item><description><b>npx</b>: illegal ad</description></item>
                /// <item><description><b>qrcode</b>: QR code.</description></item>
                /// <item><description><b>programCode</b>: mini program code.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("AdLabel")]
                [Validation(Required=false)]
                public string AdLabel { get; set; }

                /// <summary>
                /// <para>The score of the video snapshot in the ad review result. Valid values: <c>[0,100]</c>. The value is rounded down to 10 decimal places. The score is representative of the confidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AdScore")]
                [Validation(Required=false)]
                public string AdScore { get; set; }

                /// <summary>
                /// <para>The category of the review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal content.</description></item>
                /// <item><description><b>meaningless</b>: meaningless content, such as a black or white screen.</description></item>
                /// <item><description><b>PIP</b>: picture-in-picture.</description></item>
                /// <item><description><b>smoking</b>: smoking.</description></item>
                /// <item><description><b>drivelive</b>: live broadcasting in a running vehicle.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("LiveLabel")]
                [Validation(Required=false)]
                public string LiveLabel { get; set; }

                /// <summary>
                /// <para>The score of the video snapshot in the undesirable content review result. Valid values: <c>[0,100]</c>. The value is rounded down to 10 decimal places. The score is representative of the confidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LiveScore")]
                [Validation(Required=false)]
                public string LiveScore { get; set; }

                /// <summary>
                /// <para>The category of the review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: normal content.</description></item>
                /// <item><description><b>TV</b>: controlled TV station logo.</description></item>
                /// <item><description><b>trademark</b>: trademark.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("LogoLabel")]
                [Validation(Required=false)]
                public string LogoLabel { get; set; }

                /// <summary>
                /// <para>The score of the video snapshot in the logo review result. Valid values: <c>[0,100]</c>. The value is rounded down to 10 decimal places. The score is representative of the confidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LogoScore")]
                [Validation(Required=false)]
                public string LogoScore { get; set; }

                /// <summary>
                /// <para>The category of the review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b></description></item>
                /// <item><description><b>porn</b></description></item>
                /// <item><description><b>sexy</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("PornLabel")]
                [Validation(Required=false)]
                public string PornLabel { get; set; }

                /// <summary>
                /// <para>The score of the video snapshot in the pornographic content review result. Valid values: <c>[0,100]</c>. The value is rounded down to 10 decimal places. The score is representative of the confidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("PornScore")]
                [Validation(Required=false)]
                public string PornScore { get; set; }

                /// <summary>
                /// <para>The category of the review result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b></description></item>
                /// <item><description><b>bloody</b></description></item>
                /// <item><description><b>explosion</b></description></item>
                /// <item><description><b>outfit</b></description></item>
                /// <item><description><b>logo</b></description></item>
                /// <item><description><b>weapon</b></description></item>
                /// <item><description><b>politics</b></description></item>
                /// <item><description><b>violence</b></description></item>
                /// <item><description><b>crowd</b></description></item>
                /// <item><description><b>parade</b></description></item>
                /// <item><description><b>carcrash</b></description></item>
                /// <item><description><b>flag</b></description></item>
                /// <item><description><b>location</b></description></item>
                /// <item><description><b>others</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("TerrorismLabel")]
                [Validation(Required=false)]
                public string TerrorismLabel { get; set; }

                /// <summary>
                /// <para>The score of the video snapshot in the terrorist content review result. Valid values: <c>[0,100]</c>. The value is rounded down to 10 decimal places. The score is representative of the confidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("TerrorismScore")]
                [Validation(Required=false)]
                public string TerrorismScore { get; set; }

                /// <summary>
                /// <para>The timestamp of the snapshot in the video. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3005</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// <para>The URL of the video snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://temp-testbucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg">http://temp-testbucket.oss-cn-shanghai.aliyuncs.com/aivideocensor/****.jpg</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The total number of snapshots returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6438BD76-D523-46FC-956F-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
