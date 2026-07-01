// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetProjectExportJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The project export task.</para>
        /// </summary>
        [NameInMap("ProjectExportJob")]
        [Validation(Required=false)]
        public GetProjectExportJobResponseBodyProjectExportJob ProjectExportJob { get; set; }
        public class GetProjectExportJobResponseBodyProjectExportJob : TeaModel {
            /// <summary>
            /// <para>The error code of the project export task.</para>
            /// <remarks>
            /// <para>Notice: Check this field when the task fails.</para>
            /// </remarks>
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
            public GetProjectExportJobResponseBodyProjectExportJobExportResult ExportResult { get; set; }
            public class GetProjectExportJobResponseBodyProjectExportJobExportResult : TeaModel {
                [NameInMap("AudioUrl")]
                [Validation(Required=false)]
                public string AudioUrl { get; set; }

                /// <summary>
                /// <para>The file URL of the exported project, which is typically an authenticated OSS URL. This field is returned when the export type is AdobePremierePro.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example_prefix/exported_project_1e8c39a502c3436c84f88290cd713bf3.zip?Expires=1750331685&">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example_prefix/exported_project_1e8c39a502c3436c84f88290cd713bf3.zip?Expires=1750331685&amp;</a>....</para>
                /// </summary>
                [NameInMap("ProjectUrl")]
                [Validation(Required=false)]
                public string ProjectUrl { get; set; }

                [NameInMap("SrtList")]
                [Validation(Required=false)]
                public List<GetProjectExportJobResponseBodyProjectExportJobExportResultSrtList> SrtList { get; set; }
                public class GetProjectExportJobResponseBodyProjectExportJobExportResultSrtList : TeaModel {
                    [NameInMap("SrtUrl")]
                    [Validation(Required=false)]
                    public string SrtUrl { get; set; }

                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

                /// <summary>
                /// <para>The online editing timeline. This field is returned when the export type is BaseTimeline. For more information about the structure, see <a href="https://help.aliyun.com/document_detail/198823.html">Timeline configuration</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;VideoTracks&quot;:[{&quot;VideoTrackClips&quot;:[{&quot;Type&quot;:&quot;Video&quot;,&quot;MediaId&quot;:&quot;<b><b>4d7cf14dc7b83b0e801c</b></b>&quot;,&quot;MediaURL&quot;:&quot;<a href="https://test-bucket.oss-cn-shanghai.aliyuncs.com/test.mp4%22,%22TimelineIn%22:0.0,%22TimelineOut%22:5.0,%22In%22:0.0,%22Out%22:5.0,%22Speed%22:1.0,%22Duration%22:5.0,%22VirginDuration%22:13.334,%22Height%22:1.0,%22Width%22:1.0,%22X%22:0.0,%22Y%22:0.0%7D%5D%7D%5D%7D">https://test-bucket.oss-cn-shanghai.aliyuncs.com/test.mp4&quot;,&quot;TimelineIn&quot;:0.0,&quot;TimelineOut&quot;:5.0,&quot;In&quot;:0.0,&quot;Out&quot;:5.0,&quot;Speed&quot;:1.0,&quot;Duration&quot;:5.0,&quot;VirginDuration&quot;:13.334,&quot;Height&quot;:1.0,&quot;Width&quot;:1.0,&quot;X&quot;:0.0,&quot;Y&quot;:0.0}]}]}</a></para>
                /// </summary>
                [NameInMap("Timeline")]
                [Validation(Required=false)]
                public string Timeline { get; set; }

            }

            /// <summary>
            /// <para>The type of the project export. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BaseTimeline</b>: timeline.</description></item>
            /// <item><description><b>AdobePremierePro</b>: Adobe Premiere Pro project.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BaseTimeline</para>
            /// </summary>
            [NameInMap("ExportType")]
            [Validation(Required=false)]
            public string ExportType { get; set; }

            /// <summary>
            /// <para>The ID of the project export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>cdb3e74639973036bc84</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The error message of the project export task.</para>
            /// <remarks>
            /// <para>Notice: Check this field when the task fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>The specified parameter is not valid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The status of the project export task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Init</b>: initial state.</description></item>
            /// <item><description><b>Processing</b>: processing.</description></item>
            /// <item><description><b>Success</b>: succeeded.</description></item>
            /// <item><description><b>Failed</b>: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The custom settings in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22,%22Key%22:%22Valuexxx%22%7D">http://xx.xx.xxx&quot;,&quot;Key&quot;:&quot;Valuexxx&quot;}</a></para>
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
