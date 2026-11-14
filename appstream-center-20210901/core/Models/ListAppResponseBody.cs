// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This field is returned when the request fails. A successful response may not contain this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of application records that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The application records on the current page.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppResponseBodyData> Data { get; set; }
        public class ListAppResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The URL used to access the application icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/apps/business/icon.png">https://example.com/apps/business/icon.png</a></para>
            /// </summary>
            [NameInMap("AppIconUrl")]
            [Validation(Required=false)]
            public string AppIconUrl { get; set; }

            /// <summary>
            /// <para>The application ID, which is used for subsequent application queries or unbinding images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-bp1example****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The display name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business management platform</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The theme color saved for the application. If no theme color is specified when the application is created, #FFFFFF (white) is saved by default. The saved value is returned during queries. This field may not be configured for legacy applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#FFFFFF</para>
            /// </summary>
            [NameInMap("AppThemeColor")]
            [Validation(Required=false)]
            public string AppThemeColor { get; set; }

            /// <summary>
            /// <para>The source type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>USER_APP</b>: user-created applications</description></item>
            /// <item><description><b>SYS_APP</b>: system-provided applications</description></item>
            /// <item><description><b>VIRTUAL_APP</b>: virtual applications</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USER_APP</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>The business type to which the application belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: basic products</description></item>
            /// <item><description><b>2</b>: personal cloud</description></item>
            /// <item><description><b>3</b>: cloud office</description></item>
            /// <item><description><b>4</b>: Cloud Flow</description></item>
            /// <item><description><b>10</b>: Personal Edition</description></item>
            /// <item><description><b>20</b>: Business Edition</description></item>
            /// <item><description><b>60</b>: Linggou Team Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            /// <summary>
            /// <para>Indicates whether the current application is not referenced by any image. A value of true indicates that no image references the application. A value of false indicates that the application is still referenced by an image, and you must remove the reference before deleting the application.</para>
            /// </summary>
            [NameInMap("Deletable")]
            [Validation(Required=false)]
            public bool? Deletable { get; set; }

            /// <summary>
            /// <para>The path of the executable file saved when the application is created or modified. This field is returned only if the path is configured for the application. An example is the installation path of a Windows business application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Program Files\BusinessApp\BusinessApp.exe</para>
            /// </summary>
            [NameInMap("ExecuteFileAddress")]
            [Validation(Required=false)]
            public string ExecuteFileAddress { get; set; }

            /// <summary>
            /// <para>The time when the application was created. The time is in ISO 8601 format, accurate to milliseconds, and the time zone offset is +00:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-25T07:41:30.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the application was last modified. The time is in ISO 8601 format, accurate to milliseconds, and the time zone offset is +00:00.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-25T07:41:30.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The form of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CLIENT_BASE</b>: client applications</description></item>
            /// <item><description><b>WEB_BASE</b>: browser applications</description></item>
            /// <item><description><b>CLOUD_NATIVE_BASE</b>: cloud-native applications</description></item>
            /// <item><description><b>PORT_SERVICE_BASE</b>: port service applications</description></item>
            /// <item><description><b>AGENT_SERVICE_BASE</b>: agent applications</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WEB_BASE</para>
            /// </summary>
            [NameInMap("OriginAppType")]
            [Validation(Required=false)]
            public string OriginAppType { get; set; }

            /// <summary>
            /// <para>The type of operating system used by the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Unknown</b>: unknown operating system</description></item>
            /// <item><description><b>Windows</b>: Windows operating system</description></item>
            /// <item><description><b>Linux</b>: Linux operating system</description></item>
            /// <item><description><b>Android</b>: Android operating system</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The product to which the resource belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CloudGame</b>: cloud gaming</description></item>
            /// <item><description><b>CloudApp</b>: Wuying Cloud Application</description></item>
            /// <item><description><b>CloudBrowser</b>: secure browser</description></item>
            /// <item><description><b>CloudDesktop</b>: Wuying Cloud Computer</description></item>
            /// <item><description><b>ImageBuilder</b>: image builder resources</description></item>
            /// <item><description><b>ImageValidate</b>: image validation resources</description></item>
            /// <item><description><b>AndroidCloud</b>: Android cloud</description></item>
            /// <item><description><b>GpuRender</b>: GPU rendering</description></item>
            /// <item><description><b>AndroidGpuRender</b>: Android cloud GPU rendering</description></item>
            /// <item><description><b>WuyingServer</b>: Enterprise Edition workstation</description></item>
            /// <item><description><b>GpuProxy</b>: GPU remote rendering proxy</description></item>
            /// <item><description><b>GpuCache</b>: GPU remote rendering cache</description></item>
            /// <item><description><b>AIAgent</b>: AI agent service</description></item>
            /// <item><description><b>HostedDesktop</b>: hosted computer</description></item>
            /// <item><description><b>WuyingWorkstation</b>: Personal Edition container workstation</description></item>
            /// <item><description><b>WuyingWorkstationBusiness</b>: Business Edition container workstation</description></item>
            /// <item><description><b>WuyingWorkstationTeam</b>: Linggou Team Edition container workstation</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CloudApp</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The command-line arguments used when the application starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--lang=zh-CN</para>
            /// </summary>
            [NameInMap("SilenceParam")]
            [Validation(Required=false)]
            public string SilenceParam { get; set; }

            /// <summary>
            /// <para>The status of the application record. The current list queries only valid and undeleted applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The subtype of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PWA</b>: progressive web applications</description></item>
            /// <item><description><b>SAAS</b>: SaaS applications</description></item>
            /// <item><description><b>SANDBOX</b>: sandbox applications</description></item>
            /// <item><description><b>CONTAINER</b>: container applications</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SAAS</para>
            /// </summary>
            [NameInMap("SubAppType")]
            [Validation(Required=false)]
            public string SubAppType { get; set; }

        }

        /// <summary>
        /// <para>The error or result message. This field describes the cause when the request fails. A successful response may not contain this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal error.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the current query. Note that the name of this response field is PageNmuber.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNmuber")]
        [Validation(Required=false)]
        public int? PageNmuber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page in the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can provide this value for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1A962-5503-107B-AC8F-EBA85DF905AC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was processed successfully. A value of true indicates that the current request was processed successfully. To check whether an asynchronous task is completed, you must query the task status separately.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
