// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class DescribeMigrationJobCountRequest : TeaModel {
        [NameInMap("batchTaskGroupId")]
        [Validation(Required=false)]
        public long? BatchTaskGroupId { get; set; }

        [NameInMap("cutoverPlanId")]
        [Validation(Required=false)]
        public string CutoverPlanId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("outSideId")]
        [Validation(Required=false)]
        public string OutSideId { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("surveyResourceId")]
        [Validation(Required=false)]
        public long? SurveyResourceId { get; set; }

        [NameInMap("tagList")]
        [Validation(Required=false)]
        public List<DescribeMigrationJobCountRequestTagList> TagList { get; set; }
        public class DescribeMigrationJobCountRequestTagList : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("typeList")]
        [Validation(Required=false)]
        public List<string> TypeList { get; set; }

        [NameInMap("usedType")]
        [Validation(Required=false)]
        public string UsedType { get; set; }

    }

}
