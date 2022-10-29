// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemRequest : TeaModel {
        [NameInMap("assignedTo")]
        [Validation(Required=false)]
        public string AssignedTo { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("descriptionFormat")]
        [Validation(Required=false)]
        public string DescriptionFormat { get; set; }

        [NameInMap("fieldValueList")]
        [Validation(Required=false)]
        public List<CreateWorkitemRequestFieldValueList> FieldValueList { get; set; }
        public class CreateWorkitemRequestFieldValueList : TeaModel {
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("workitemIdentifier")]
            [Validation(Required=false)]
            public string WorkitemIdentifier { get; set; }

        }

        [NameInMap("parent")]
        [Validation(Required=false)]
        public string Parent { get; set; }

        [NameInMap("participant")]
        [Validation(Required=false)]
        public List<string> Participant { get; set; }

        [NameInMap("space")]
        [Validation(Required=false)]
        public string Space { get; set; }

        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

        [NameInMap("sprint")]
        [Validation(Required=false)]
        public List<string> Sprint { get; set; }

        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("tracker")]
        [Validation(Required=false)]
        public List<string> Tracker { get; set; }

        [NameInMap("verifier")]
        [Validation(Required=false)]
        public List<string> Verifier { get; set; }

        [NameInMap("workitemType")]
        [Validation(Required=false)]
        public string WorkitemType { get; set; }

    }

}
