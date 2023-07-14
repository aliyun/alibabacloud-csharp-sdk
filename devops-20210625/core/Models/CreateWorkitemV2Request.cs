// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemV2Request : TeaModel {
        [NameInMap("assignedTo")]
        [Validation(Required=false)]
        public string AssignedTo { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("fieldValueList")]
        [Validation(Required=false)]
        public List<CreateWorkitemV2RequestFieldValueList> FieldValueList { get; set; }
        public class CreateWorkitemV2RequestFieldValueList : TeaModel {
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("parentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        [NameInMap("participants")]
        [Validation(Required=false)]
        public List<string> Participants { get; set; }

        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        [NameInMap("sprintIdentifier")]
        [Validation(Required=false)]
        public string SprintIdentifier { get; set; }

        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("trackers")]
        [Validation(Required=false)]
        public List<string> Trackers { get; set; }

        [NameInMap("verifier")]
        [Validation(Required=false)]
        public string Verifier { get; set; }

        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<string> Versions { get; set; }

        [NameInMap("workitemTypeIdentifier")]
        [Validation(Required=false)]
        public string WorkitemTypeIdentifier { get; set; }

    }

}
