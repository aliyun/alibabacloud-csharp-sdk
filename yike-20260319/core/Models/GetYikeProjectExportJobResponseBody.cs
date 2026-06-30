// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class GetYikeProjectExportJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The export task object.</para>
        /// </summary>
        [NameInMap("ProjectExportJob")]
        [Validation(Required=false)]
        public GetYikeProjectExportJobResponseBodyProjectExportJob ProjectExportJob { get; set; }
        public class GetYikeProjectExportJobResponseBodyProjectExportJob : TeaModel {
            /// <summary>
            /// <para>The task failure code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The export result.</para>
            /// </summary>
            [NameInMap("ExportResult")]
            [Validation(Required=false)]
            public GetYikeProjectExportJobResponseBodyProjectExportJobExportResult ExportResult { get; set; }
            public class GetYikeProjectExportJobResponseBodyProjectExportJobExportResult : TeaModel {
                /// <summary>
                /// <para>The download URL of the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http://....MP3?Expires=</para>
                /// </summary>
                [NameInMap("AudioUrl")]
                [Validation(Required=false)]
                public string AudioUrl { get; set; }

                /// <summary>
                /// <para>The download URL of the PR project file (not supported).</para>
                /// 
                /// <b>Example:</b>
                /// <para>....</para>
                /// </summary>
                [NameInMap("ProjectUrl")]
                [Validation(Required=false)]
                public string ProjectUrl { get; set; }

                /// <summary>
                /// <para>The subtitle list.</para>
                /// </summary>
                [NameInMap("SrtList")]
                [Validation(Required=false)]
                public List<GetYikeProjectExportJobResponseBodyProjectExportJobExportResultSrtList> SrtList { get; set; }
                public class GetYikeProjectExportJobResponseBodyProjectExportJobExportResultSrtList : TeaModel {
                    /// <summary>
                    /// <para>The download URL of the SRT file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xxx?Expires=">http://xxx?Expires=</a></para>
                    /// </summary>
                    [NameInMap("SrtUrl")]
                    [Validation(Required=false)]
                    public string SrtUrl { get; set; }

                    /// <summary>
                    /// <para>The type enumeration. Currently, only VoiceOver is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VoiceOver</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

                /// <summary>
                /// <para>The editing timeline (not supported).</para>
                /// 
                /// <b>Example:</b>
                /// <para>....</para>
                /// </summary>
                [NameInMap("Timeline")]
                [Validation(Required=false)]
                public string Timeline { get; set; }

            }

            /// <summary>
            /// <para>The project export type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PureAudio</para>
            /// </summary>
            [NameInMap("ExportType")]
            [Validation(Required=false)]
            public string ExportType { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>cdb3e74639973036bc84</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The task failure message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified parameter is not valid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The online editing project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The custom data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;testKey\&quot;:\&quot;testValue\&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>2876-6263-4B75-8F2C-CD0F7FCF</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
