// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppWorkspaceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ish-intelligence-store-platform-admin-web</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic message. This parameter is not in use. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetAppWorkspaceDirectoryResponseBodyModule Module { get; set; }
        public class GetAppWorkspaceDirectoryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The current time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026</para>
            /// </summary>
            [NameInMap("CurrentTime")]
            [Validation(Required=false)]
            public string CurrentTime { get; set; }

            /// <summary>
            /// <para>The directory structure.</para>
            /// </summary>
            [NameInMap("DirectoryList")]
            [Validation(Required=false)]
            public List<GetAppWorkspaceDirectoryResponseBodyModuleDirectoryList> DirectoryList { get; set; }
            public class GetAppWorkspaceDirectoryResponseBodyModuleDirectoryList : TeaModel {
                /// <summary>
                /// <para>The child content.</para>
                /// </summary>
                [NameInMap("Children")]
                [Validation(Required=false)]
                public List<object> Children { get; set; }

                /// <summary>
                /// <para>The full path relative to the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PolarDBInnoDBRedoLogWrites</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Evaluable=true</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

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
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The exception message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
