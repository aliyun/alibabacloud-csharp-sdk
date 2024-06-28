// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetTicketTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTicketTemplateResponseBodyData Data { get; set; }
        public class GetTicketTemplateResponseBodyData : TeaModel {
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            [NameInMap("Editor")]
            [Validation(Required=false)]
            public string Editor { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ProcessDefinition")]
            [Validation(Required=false)]
            public string ProcessDefinition { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TicketFields")]
            [Validation(Required=false)]
            public List<GetTicketTemplateResponseBodyDataTicketFields> TicketFields { get; set; }
            public class GetTicketTemplateResponseBodyDataTicketFields : TeaModel {
                [NameInMap("Array")]
                [Validation(Required=false)]
                public bool? Array { get; set; }

                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public int? DisplayOrder { get; set; }

                [NameInMap("EditorType")]
                [Validation(Required=false)]
                public string EditorType { get; set; }

                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public int? MaxLength { get; set; }

                [NameInMap("Maximum")]
                [Validation(Required=false)]
                public double? Maximum { get; set; }

                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public int? MinLength { get; set; }

                [NameInMap("Minimum")]
                [Validation(Required=false)]
                public double? Minimum { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                [NameInMap("PatternErrorMessage")]
                [Validation(Required=false)]
                public string PatternErrorMessage { get; set; }

                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("System")]
                [Validation(Required=false)]
                public bool? System { get; set; }

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
