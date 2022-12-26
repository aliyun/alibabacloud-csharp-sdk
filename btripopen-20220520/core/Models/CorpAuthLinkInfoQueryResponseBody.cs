// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CorpAuthLinkInfoQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public CorpAuthLinkInfoQueryResponseBodyModule Module { get; set; }
        public class CorpAuthLinkInfoQueryResponseBodyModule : TeaModel {
            [NameInMap("link_corps")]
            [Validation(Required=false)]
            public List<CorpAuthLinkInfoQueryResponseBodyModuleLinkCorps> LinkCorps { get; set; }
            public class CorpAuthLinkInfoQueryResponseBodyModuleLinkCorps : TeaModel {
                [NameInMap("corp_name")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                [NameInMap("open_corp_id")]
                [Validation(Required=false)]
                public string OpenCorpId { get; set; }

                [NameInMap("true_corp_id")]
                [Validation(Required=false)]
                public string TrueCorpId { get; set; }

            }

            [NameInMap("org_corp")]
            [Validation(Required=false)]
            public CorpAuthLinkInfoQueryResponseBodyModuleOrgCorp OrgCorp { get; set; }
            public class CorpAuthLinkInfoQueryResponseBodyModuleOrgCorp : TeaModel {
                [NameInMap("corp_name")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                [NameInMap("open_corp_id")]
                [Validation(Required=false)]
                public string OpenCorpId { get; set; }

                [NameInMap("true_corp_id")]
                [Validation(Required=false)]
                public string TrueCorpId { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
