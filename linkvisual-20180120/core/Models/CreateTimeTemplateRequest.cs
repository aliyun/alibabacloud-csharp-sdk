// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class CreateTimeTemplateRequest : TeaModel {
        [NameInMap("AllDay")]
        [Validation(Required=false)]
        public int? AllDay { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TimeSections")]
        [Validation(Required=false)]
        public List<CreateTimeTemplateRequestTimeSections> TimeSections { get; set; }
        public class CreateTimeTemplateRequestTimeSections : TeaModel {
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            [NameInMap("DayOfWeek")]
            [Validation(Required=false)]
            public int? DayOfWeek { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

        }

    }

}
