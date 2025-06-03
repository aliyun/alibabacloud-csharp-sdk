// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class DescribeSurveyResourceTagRequest : TeaModel {
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("sourceUserIdList")]
        [Validation(Required=false)]
        public List<long?> SourceUserIdList { get; set; }

    }

}
