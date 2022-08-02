// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class RoutingRuleRedirect : TeaModel {
        [NameInMap("EnableReplacePrefix")]
        [Validation(Required=false)]
        public bool? EnableReplacePrefix { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("HttpRedirectCode")]
        [Validation(Required=false)]
        public long? HttpRedirectCode { get; set; }

        [NameInMap("MirrorCheckMd5")]
        [Validation(Required=false)]
        public bool? MirrorCheckMd5 { get; set; }

        [NameInMap("MirrorFollowRedirect")]
        [Validation(Required=false)]
        public bool? MirrorFollowRedirect { get; set; }

        [NameInMap("MirrorHeaders")]
        [Validation(Required=false)]
        public RoutingRuleRedirectMirrorHeaders MirrorHeaders { get; set; }
        public class RoutingRuleRedirectMirrorHeaders : TeaModel {
            [NameInMap("Pass")]
            [Validation(Required=false)]
            public List<string> Pass { get; set; }
            [NameInMap("PassAll")]
            [Validation(Required=false)]
            public bool? PassAll { get; set; }
            [NameInMap("Remove")]
            [Validation(Required=false)]
            public List<string> Remove { get; set; }
            [NameInMap("Set")]
            [Validation(Required=false)]
            public List<RoutingRuleRedirectMirrorHeadersSet> Set { get; set; }
            public class RoutingRuleRedirectMirrorHeadersSet : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("MirrorPassQueryString")]
        [Validation(Required=false)]
        public bool? MirrorPassQueryString { get; set; }

        [NameInMap("MirrorURL")]
        [Validation(Required=false)]
        public string MirrorURL { get; set; }

        [NameInMap("PassQueryString")]
        [Validation(Required=false)]
        public bool? PassQueryString { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RedirectType")]
        [Validation(Required=false)]
        public string RedirectType { get; set; }

        [NameInMap("ReplaceKeyPrefixWith")]
        [Validation(Required=false)]
        public string ReplaceKeyPrefixWith { get; set; }

        [NameInMap("ReplaceKeyWith")]
        [Validation(Required=false)]
        public string ReplaceKeyWith { get; set; }

        [NameInMap("TransparentMirrorResponseCodes")]
        [Validation(Required=false)]
        public string TransparentMirrorResponseCodes { get; set; }

    }

}
