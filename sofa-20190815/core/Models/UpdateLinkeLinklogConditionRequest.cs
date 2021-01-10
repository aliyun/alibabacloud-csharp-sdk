// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeLinklogConditionRequest : TeaModel {
        [NameInMap("Compiled")]
        [Validation(Required=false)]
        public string Compiled { get; set; }

        [NameInMap("ConditionId")]
        [Validation(Required=false)]
        public long? ConditionId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("IndicationId")]
        [Validation(Required=false)]
        public long? IndicationId { get; set; }

        [NameInMap("LogSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

    }

}
