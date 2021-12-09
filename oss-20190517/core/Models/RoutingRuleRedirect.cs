// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class RoutingRuleRedirect : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("EnableReplacePrefix")]
        [Validation(Required=false)]
        public bool? EnableReplacePrefix { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("HttpRedirectCode")]
        [Validation(Required=false)]
        public long? HttpRedirectCode { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("MirrorCheckMd5")]
        [Validation(Required=false)]
        public bool? MirrorCheckMd5 { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("MirrorFollowRedirect")]
        [Validation(Required=false)]
        public bool? MirrorFollowRedirect { get; set; }

        /// <summary>
        /// description
        /// </summary>
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

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("MirrorPassQueryString")]
        [Validation(Required=false)]
        public bool? MirrorPassQueryString { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("MirrorURL")]
        [Validation(Required=false)]
        public string MirrorURL { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("PassQueryString")]
        [Validation(Required=false)]
        public string PassQueryString { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("RedirectType")]
        [Validation(Required=false)]
        public string RedirectType { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("ReplaceKeyPrefixWith")]
        [Validation(Required=false)]
        public string ReplaceKeyPrefixWith { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("ReplaceKeyWith")]
        [Validation(Required=false)]
        public string ReplaceKeyWith { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("TransparentMirrorResponseCodes")]
        [Validation(Required=false)]
        public string TransparentMirrorResponseCodes { get; set; }

    }

}
