// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafPhasesResponseBody : TeaModel {
        [NameInMap("Phases")]
        [Validation(Required=false)]
        public List<ListWafPhasesResponseBodyPhases> Phases { get; set; }
        public class ListWafPhasesResponseBodyPhases : TeaModel {
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            [NameInMap("Rulesets")]
            [Validation(Required=false)]
            public List<ListWafPhasesResponseBodyPhasesRulesets> Rulesets { get; set; }
            public class ListWafPhasesResponseBodyPhasesRulesets : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<WafRuleConfig> Rules { get; set; }

                [NameInMap("Shared")]
                [Validation(Required=false)]
                public WafBatchRuleShared Shared { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
