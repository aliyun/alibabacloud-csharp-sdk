// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CheckLinkeLinklogRegexRequest : TeaModel {
        [NameInMap("SampleLog")]
        [Validation(Required=false)]
        public string SampleLog { get; set; }

        [NameInMap("ConditionsRepeatList")]
        [Validation(Required=false)]
        public List<string> ConditionsRepeatList { get; set; }

    }

}
