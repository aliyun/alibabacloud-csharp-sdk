// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class UpdateProjectResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateProjectResponseBodyData Data { get; set; }
        public class UpdateProjectResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-10T02:07:16Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ProjectApps")]
            [Validation(Required=false)]
            public List<UpdateProjectResponseBodyDataProjectApps> ProjectApps { get; set; }
            public class UpdateProjectResponseBodyDataProjectApps : TeaModel {
                [NameInMap("ApplicationAccessIds")]
                [Validation(Required=false)]
                public List<UpdateProjectResponseBodyDataProjectAppsApplicationAccessIds> ApplicationAccessIds { get; set; }
                public class UpdateProjectResponseBodyDataProjectAppsApplicationAccessIds : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1234567890</para>
                    /// </summary>
                    [NameInMap("applicationAccessId")]
                    [Validation(Required=false)]
                    public string ApplicationAccessId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MyAppSecret</para>
                    /// </summary>
                    [NameInMap("applicationAccessSecret")]
                    [Validation(Required=false)]
                    public string ApplicationAccessSecret { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4498</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1889</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>56160</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MyProject</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("ProjectSDK")]
            [Validation(Required=false)]
            public List<UpdateProjectResponseBodyDataProjectSDK> ProjectSDK { get; set; }
            public class UpdateProjectResponseBodyDataProjectSDK : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-11-01T13:40:53Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://demo.com/demo">http://demo.com/demo</a></para>
                /// </summary>
                [NameInMap("DemoUrl")]
                [Validation(Required=false)]
                public string DemoUrl { get; set; }

                [NameInMap("DeployMode")]
                [Validation(Required=false)]
                public string DeployMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PHP</para>
                /// </summary>
                [NameInMap("DevelopLanguage")]
                [Validation(Required=false)]
                public string DevelopLanguage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://demo.com/doc">http://demo.com/doc</a></para>
                /// </summary>
                [NameInMap("DocUrl")]
                [Validation(Required=false)]
                public string DocUrl { get; set; }

                [NameInMap("SdkName")]
                [Validation(Required=false)]
                public string SdkName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://demo.com/sdk.zip">http://demo.com/sdk.zip</a></para>
                /// </summary>
                [NameInMap("SdkUrl")]
                [Validation(Required=false)]
                public string SdkUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4.13.0</para>
                /// </summary>
                [NameInMap("SdkVersion")]
                [Validation(Required=false)]
                public string SdkVersion { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WebApplication</para>
            /// </summary>
            [NameInMap("ProjectType")]
            [Validation(Required=false)]
            public string ProjectType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
