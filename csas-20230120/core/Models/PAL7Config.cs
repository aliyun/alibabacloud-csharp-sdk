// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class PAL7Config : TeaModel {
        [NameInMap("BypassConfig")]
        [Validation(Required=false)]
        public PAL7ConfigBypassConfig BypassConfig { get; set; }
        public class PAL7ConfigBypassConfig : TeaModel {
            [NameInMap("AppBypassFroms")]
            [Validation(Required=false)]
            public List<string> AppBypassFroms { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("UrlBypassRules")]
            [Validation(Required=false)]
            public List<PAL7ConfigBypassConfigUrlBypassRules> UrlBypassRules { get; set; }
            public class PAL7ConfigBypassConfigUrlBypassRules : TeaModel {
                [NameInMap("Froms")]
                [Validation(Required=false)]
                public List<string> Froms { get; set; }

                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

            }

        }

        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        [NameInMap("DnsConfig")]
        [Validation(Required=false)]
        public PAL7ConfigDnsConfig DnsConfig { get; set; }
        public class PAL7ConfigDnsConfig : TeaModel {
            [NameInMap("DnsServers")]
            [Validation(Required=false)]
            public List<string> DnsServers { get; set; }

        }

        [NameInMap("JsHookConfig")]
        [Validation(Required=false)]
        public PAL7ConfigJsHookConfig JsHookConfig { get; set; }
        public class PAL7ConfigJsHookConfig : TeaModel {
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("ReplaceRules")]
            [Validation(Required=false)]
            public List<PAL7ConfigReplaceRule> ReplaceRules { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>逗号分隔的枚举值：automatic,custom</para>
        /// </summary>
        [NameInMap("ProxyDomainTypes")]
        [Validation(Required=false)]
        public byte[] ProxyDomainTypes { get; set; }

        [NameInMap("RequestHeaderRewriteConfig")]
        [Validation(Required=false)]
        public PAL7ConfigRequestHeaderRewriteConfig RequestHeaderRewriteConfig { get; set; }
        public class PAL7ConfigRequestHeaderRewriteConfig : TeaModel {
            [NameInMap("Ops")]
            [Validation(Required=false)]
            public List<PAL7ConfigRewriteOp> Ops { get; set; }

        }

        [NameInMap("RequestQueryRewriteConfig")]
        [Validation(Required=false)]
        public PAL7ConfigRequestQueryRewriteConfig RequestQueryRewriteConfig { get; set; }
        public class PAL7ConfigRequestQueryRewriteConfig : TeaModel {
            [NameInMap("Ops")]
            [Validation(Required=false)]
            public List<PAL7ConfigRewriteOp> Ops { get; set; }

        }

        [NameInMap("ResponseHeaderRewriteConfig")]
        [Validation(Required=false)]
        public PAL7ConfigResponseHeaderRewriteConfig ResponseHeaderRewriteConfig { get; set; }
        public class PAL7ConfigResponseHeaderRewriteConfig : TeaModel {
            [NameInMap("Ops")]
            [Validation(Required=false)]
            public List<PAL7ConfigRewriteOp> Ops { get; set; }

        }

        [NameInMap("ResponseRewriteConfig")]
        [Validation(Required=false)]
        public PAL7ConfigResponseRewriteConfig ResponseRewriteConfig { get; set; }
        public class PAL7ConfigResponseRewriteConfig : TeaModel {
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("ReplaceRules")]
            [Validation(Required=false)]
            public List<PAL7ConfigReplaceRule> ReplaceRules { get; set; }

        }

    }

}
