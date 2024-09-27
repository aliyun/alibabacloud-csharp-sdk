// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs_workbench20220220.Models
{
    public class LoginInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParamter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc-123</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Root")]
        [Validation(Required=false)]
        public LoginInstanceResponseBodyRoot Root { get; set; }
        public class LoginInstanceResponseBodyRoot : TeaModel {
            [NameInMap("DisposableAccount")]
            [Validation(Required=false)]
            public LoginInstanceResponseBodyRootDisposableAccount DisposableAccount { get; set; }
            public class LoginInstanceResponseBodyRootDisposableAccount : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("LoginFormActionUrl")]
                [Validation(Required=false)]
                public string LoginFormActionUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("LoginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

            }

            [NameInMap("InstanceLoginInfoList")]
            [Validation(Required=false)]
            public List<LoginInstanceResponseBodyRootInstanceLoginInfoList> InstanceLoginInfoList { get; set; }
            public class LoginInstanceResponseBodyRootInstanceLoginInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>i-abc</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>134</para>
                /// </summary>
                [NameInMap("InstanceLoginToken")]
                [Validation(Required=false)]
                public string InstanceLoginToken { get; set; }

                [NameInMap("InstanceLoginView")]
                [Validation(Required=false)]
                public LoginInstanceResponseBodyRootInstanceLoginInfoListInstanceLoginView InstanceLoginView { get; set; }
                public class LoginInstanceResponseBodyRootInstanceLoginInfoListInstanceLoginView : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("DefaultViewUrl")]
                    [Validation(Required=false)]
                    public string DefaultViewUrl { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LoginSuccess")]
                [Validation(Required=false)]
                public bool? LoginSuccess { get; set; }

            }

            [NameInMap("SessionControl")]
            [Validation(Required=false)]
            public LoginInstanceResponseBodyRootSessionControl SessionControl { get; set; }
            public class LoginInstanceResponseBodyRootSessionControl : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("BaseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
