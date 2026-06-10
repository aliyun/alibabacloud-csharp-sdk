// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppCodeWorkspaceDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed reason for access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>false: Retry is not allowed.  </description></item>
        /// <item><description>true: Retry is allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>App name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-b</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>Dynamic error message, used to replace the <c>%s</c> placeholder in the <b>ErrMessage</b> error message.  </para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the provided request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>Faulty parameters</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>Application module</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppCodeWorkspaceDetailResponseBodyModule Module { get; set; }
        public class GetAppCodeWorkspaceDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>11111</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("ActiveLogicalNumber")]
            [Validation(Required=false)]
            public int? ActiveLogicalNumber { get; set; }

            [NameInMap("CommitHash")]
            [Validation(Required=false)]
            public string CommitHash { get; set; }

            /// <summary>
            /// <para>true</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsDirty")]
            [Validation(Required=false)]
            public bool? IsDirty { get; set; }

            /// <summary>
            /// <para>1111</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("MaxLogicalNumber")]
            [Validation(Required=false)]
            public int? MaxLogicalNumber { get; set; }

            /// <summary>
            /// <para>Site ID, which can be obtained by invoking the <a href="~~ListSites~~">ListSites</a> API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>865181640657408</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public string SiteId { get; set; }

            /// <summary>
            /// <para>API Guide information.</para>
            /// </summary>
            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public List<GetAppCodeWorkspaceDetailResponseBodyModuleSnapshots> Snapshots { get; set; }
            public class GetAppCodeWorkspaceDetailResponseBodyModuleSnapshots : TeaModel {
                /// <summary>
                /// <para>SDK change log</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>Add Params.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ChangeLog")]
                [Validation(Required=false)]
                public string ChangeLog { get; set; }

                /// <summary>
                /// <para>Creation UTC time in ISO8601 format.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-10T09:40:36.562Z</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>Logical value</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("LogicalNumber")]
                [Validation(Required=false)]
                public int? LogicalNumber { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>Abnormal message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
