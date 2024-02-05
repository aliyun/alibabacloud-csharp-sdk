// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs_workbench20220220.Models
{
    public class LoginInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
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
                [NameInMap("LoginFormActionUrl")]
                [Validation(Required=false)]
                public string LoginFormActionUrl { get; set; }

                [NameInMap("LoginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

            }

            [NameInMap("InstanceLoginInfoList")]
            [Validation(Required=false)]
            public List<LoginInstanceResponseBodyRootInstanceLoginInfoList> InstanceLoginInfoList { get; set; }
            public class LoginInstanceResponseBodyRootInstanceLoginInfoList : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceLoginToken")]
                [Validation(Required=false)]
                public string InstanceLoginToken { get; set; }

                [NameInMap("InstanceLoginView")]
                [Validation(Required=false)]
                public LoginInstanceResponseBodyRootInstanceLoginInfoListInstanceLoginView InstanceLoginView { get; set; }
                public class LoginInstanceResponseBodyRootInstanceLoginInfoListInstanceLoginView : TeaModel {
                    [NameInMap("DefaultViewUrl")]
                    [Validation(Required=false)]
                    public string DefaultViewUrl { get; set; }

                }

                [NameInMap("LoginSuccess")]
                [Validation(Required=false)]
                public bool? LoginSuccess { get; set; }

            }

            [NameInMap("SessionControl")]
            [Validation(Required=false)]
            public LoginInstanceResponseBodyRootSessionControl SessionControl { get; set; }
            public class LoginInstanceResponseBodyRootSessionControl : TeaModel {
                [NameInMap("BaseUrl")]
                [Validation(Required=false)]
                public string BaseUrl { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
