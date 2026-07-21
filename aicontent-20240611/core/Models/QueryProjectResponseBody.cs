// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class QueryProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data, which contains the details of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryProjectResponseBodyData Data { get; set; }
        public class QueryProjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-01T13:40:53Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The list of applications in the project.</para>
            /// </summary>
            [NameInMap("ProjectApps")]
            [Validation(Required=false)]
            public List<QueryProjectResponseBodyDataProjectApps> ProjectApps { get; set; }
            public class QueryProjectResponseBodyDataProjectApps : TeaModel {
                /// <summary>
                /// <para>The application access credentials.</para>
                /// </summary>
                [NameInMap("ApplicationAccessIds")]
                [Validation(Required=false)]
                public List<QueryProjectResponseBodyDataProjectAppsApplicationAccessIds> ApplicationAccessIds { get; set; }
                public class QueryProjectResponseBodyDataProjectAppsApplicationAccessIds : TeaModel {
                    /// <summary>
                    /// <para>The application ID, also known as the AppKey.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567890</para>
                    /// </summary>
                    [NameInMap("applicationAccessId")]
                    [Validation(Required=false)]
                    public string ApplicationAccessId { get; set; }

                    /// <summary>
                    /// <para>The application secret. This parameter is returned only for requests from the console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MyAppSecret</para>
                    /// </summary>
                    [NameInMap("applicationAccessSecret")]
                    [Validation(Required=false)]
                    public string ApplicationAccessSecret { get; set; }

                }

                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2144</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>159</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

            }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67055</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyProject</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The list of SDKs associated with the project.</para>
            /// </summary>
            [NameInMap("ProjectSDK")]
            [Validation(Required=false)]
            public List<QueryProjectResponseBodyDataProjectSDK> ProjectSDK { get; set; }
            public class QueryProjectResponseBodyDataProjectSDK : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-01T13:40:53Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The demo URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://demo.com/demo">http://demo.com/demo</a></para>
                /// </summary>
                [NameInMap("DemoUrl")]
                [Validation(Required=false)]
                public string DemoUrl { get; set; }

                /// <summary>
                /// <para>The deployment mode. Valid values: <c>client</c> or <c>server</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>服务端</para>
                /// </summary>
                [NameInMap("DeployMode")]
                [Validation(Required=false)]
                public string DeployMode { get; set; }

                /// <summary>
                /// <para>The development language. For example: JAVA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JAVA</para>
                /// </summary>
                [NameInMap("DevelopLanguage")]
                [Validation(Required=false)]
                public string DevelopLanguage { get; set; }

                /// <summary>
                /// <para>The document URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://demo.com/doc">http://demo.com/doc</a></para>
                /// </summary>
                [NameInMap("DocUrl")]
                [Validation(Required=false)]
                public string DocUrl { get; set; }

                /// <summary>
                /// <para>The SDK name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JSSDK</para>
                /// </summary>
                [NameInMap("SdkName")]
                [Validation(Required=false)]
                public string SdkName { get; set; }

                /// <summary>
                /// <para>The SDK URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://demo.com/sdk.zip">http://demo.com/sdk.zip</a></para>
                /// </summary>
                [NameInMap("SdkUrl")]
                [Validation(Required=false)]
                public string SdkUrl { get; set; }

                /// <summary>
                /// <para>The SDK version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.1.0</para>
                /// </summary>
                [NameInMap("SdkVersion")]
                [Validation(Required=false)]
                public string SdkVersion { get; set; }

            }

            /// <summary>
            /// <para>The project type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebApplication</para>
            /// </summary>
            [NameInMap("ProjectType")]
            [Validation(Required=false)]
            public string ProjectType { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
