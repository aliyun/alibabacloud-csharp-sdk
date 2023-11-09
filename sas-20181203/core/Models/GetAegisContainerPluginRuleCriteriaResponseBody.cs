// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAegisContainerPluginRuleCriteriaResponseBody : TeaModel {
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<GetAegisContainerPluginRuleCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class GetAegisContainerPluginRuleCriteriaResponseBodyCriteriaList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
