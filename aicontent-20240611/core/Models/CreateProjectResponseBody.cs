// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class CreateProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateProjectResponseBodyData Data { get; set; }
        public class CreateProjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The project\&quot;s creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-15T09:17:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The applications in the project.</para>
            /// </summary>
            [NameInMap("ProjectApps")]
            [Validation(Required=false)]
            public List<CreateProjectResponseBodyDataProjectApps> ProjectApps { get; set; }
            public class CreateProjectResponseBodyDataProjectApps : TeaModel {
                /// <summary>
                /// <para>The access credentials for the application.</para>
                /// </summary>
                [NameInMap("ApplicationAccessIds")]
                [Validation(Required=false)]
                public List<CreateProjectResponseBodyDataProjectAppsApplicationAccessIds> ApplicationAccessIds { get; set; }
                public class CreateProjectResponseBodyDataProjectAppsApplicationAccessIds : TeaModel {
                    /// <summary>
                    /// <para>The app key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567890</para>
                    /// </summary>
                    [NameInMap("applicationAccessId")]
                    [Validation(Required=false)]
                    public string ApplicationAccessId { get; set; }

                    /// <summary>
                    /// <para>The app secret. This parameter is returned only for requests sent from the console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MyAppSecret</para>
                    /// </summary>
                    [NameInMap("applicationAccessSecret")]
                    [Validation(Required=false)]
                    public string ApplicationAccessSecret { get; set; }

                }

                /// <summary>
                /// <para>The internal ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4867</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4910</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

            }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>124187</para>
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
            /// <para>The SDKs for the project.</para>
            /// </summary>
            [NameInMap("ProjectSDK")]
            [Validation(Required=false)]
            public List<CreateProjectResponseBodyDataProjectSDK> ProjectSDK { get; set; }
            public class CreateProjectResponseBodyDataProjectSDK : TeaModel {
                /// <summary>
                /// <para>The SDK\&quot;s creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-15T09:17:39Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The demo\&quot;s URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://demo.com/demo">http://demo.com/demo</a></para>
                /// </summary>
                [NameInMap("DemoUrl")]
                [Validation(Required=false)]
                public string DemoUrl { get; set; }

                /// <summary>
                /// <para>The deployment mode. Valid values: client or server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>客户端</para>
                /// </summary>
                [NameInMap("DeployMode")]
                [Validation(Required=false)]
                public string DeployMode { get; set; }

                /// <summary>
                /// <para>The development language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C++</para>
                /// </summary>
                [NameInMap("DevelopLanguage")]
                [Validation(Required=false)]
                public string DevelopLanguage { get; set; }

                /// <summary>
                /// <para>The SDK\&quot;s documentation URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://demo.com/doc">http://demo.com/doc</a></para>
                /// </summary>
                [NameInMap("DocUrl")]
                [Validation(Required=false)]
                public string DocUrl { get; set; }

                /// <summary>
                /// <para>The name of the SDK.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C SDK</para>
                /// </summary>
                [NameInMap("SdkName")]
                [Validation(Required=false)]
                public string SdkName { get; set; }

                /// <summary>
                /// <para>The SDK\&quot;s download URL.</para>
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
                /// <para>4.12.8</para>
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
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
