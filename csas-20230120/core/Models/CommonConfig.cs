// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CommonConfig : TeaModel {
        [NameInMap("Idp")]
        [Validation(Required=false)]
        public CommonConfigIdp Idp { get; set; }
        public class CommonConfigIdp : TeaModel {
            [NameInMap("ApOidcCallbackUrl")]
            [Validation(Required=false)]
            public string ApOidcCallbackUrl { get; set; }

            [NameInMap("Dingtalk")]
            [Validation(Required=false)]
            public CommonConfigIdpDingtalk Dingtalk { get; set; }
            public class CommonConfigIdpDingtalk : TeaModel {
                [NameInMap("EventCallbackBase")]
                [Validation(Required=false)]
                public string EventCallbackBase { get; set; }

                [NameInMap("EventLabel")]
                [Validation(Required=false)]
                public string EventLabel { get; set; }

                [NameInMap("HomePage")]
                [Validation(Required=false)]
                public string HomePage { get; set; }

                [NameInMap("LoginRedirect")]
                [Validation(Required=false)]
                public string LoginRedirect { get; set; }

            }

            [NameInMap("Feishu")]
            [Validation(Required=false)]
            public CommonConfigIdpFeishu Feishu { get; set; }
            public class CommonConfigIdpFeishu : TeaModel {
                [NameInMap("EventCallbackBase")]
                [Validation(Required=false)]
                public string EventCallbackBase { get; set; }

                [NameInMap("EventLabel")]
                [Validation(Required=false)]
                public string EventLabel { get; set; }

                [NameInMap("HomePage")]
                [Validation(Required=false)]
                public string HomePage { get; set; }

                [NameInMap("LoginRedirect")]
                [Validation(Required=false)]
                public string LoginRedirect { get; set; }

            }

            [NameInMap("Idaas2")]
            [Validation(Required=false)]
            public CommonConfigIdpIdaas2 Idaas2 { get; set; }
            public class CommonConfigIdpIdaas2 : TeaModel {
                [NameInMap("EventCallbackBase")]
                [Validation(Required=false)]
                public string EventCallbackBase { get; set; }

                [NameInMap("EventLabel")]
                [Validation(Required=false)]
                public string EventLabel { get; set; }

            }

            [NameInMap("Saml")]
            [Validation(Required=false)]
            public CommonConfigIdpSaml Saml { get; set; }
            public class CommonConfigIdpSaml : TeaModel {
                [NameInMap("Acs")]
                [Validation(Required=false)]
                public string Acs { get; set; }

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public string Metadata { get; set; }

            }

        }

    }

}
