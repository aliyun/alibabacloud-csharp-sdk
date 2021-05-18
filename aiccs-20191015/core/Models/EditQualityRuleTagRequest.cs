// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class EditQualityRuleTagRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("AnalysisTypes")]
        [Validation(Required=false)]
        public List<EditQualityRuleTagRequestAnalysisTypes> AnalysisTypes { get; set; }
        public class EditQualityRuleTagRequestAnalysisTypes : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
