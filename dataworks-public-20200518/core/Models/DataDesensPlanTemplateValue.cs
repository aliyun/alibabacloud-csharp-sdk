// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DataDesensPlanTemplateValue : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SupportWaterMark")]
        [Validation(Required=false)]
        public bool? SupportWaterMark { get; set; }

        [NameInMap("ExtParamTemplate")]
        [Validation(Required=false)]
        public List<object> ExtParamTemplate { get; set; }

    }

}
