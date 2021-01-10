// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeLinktTemplateselectablecustomfieldsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public long? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListLinkeLinktTemplateselectablecustomfieldsResponseBodyData> Data { get; set; }
        public class ListLinkeLinktTemplateselectablecustomfieldsResponseBodyData : TeaModel {
            [NameInMap("CopyFrom")]
            [Validation(Required=false)]
            public long? CopyFrom { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DynamicOptionFetchUrl")]
            [Validation(Required=false)]
            public string DynamicOptionFetchUrl { get; set; }

            [NameInMap("Editable")]
            [Validation(Required=false)]
            public bool? Editable { get; set; }

            [NameInMap("EnableSearch")]
            [Validation(Required=false)]
            public bool? EnableSearch { get; set; }

            [NameInMap("FieldFormat")]
            [Validation(Required=false)]
            public string FieldFormat { get; set; }

            [NameInMap("FieldLabel")]
            [Validation(Required=false)]
            public string FieldLabel { get; set; }

            [NameInMap("FormInvisible")]
            [Validation(Required=false)]
            public bool? FormInvisible { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Invisible")]
            [Validation(Required=false)]
            public bool? Invisible { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ProjectSign")]
            [Validation(Required=false)]
            public string ProjectSign { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            [NameInMap("DynamicFieldRequiredDependentFields")]
            [Validation(Required=false)]
            public List<long?> DynamicFieldRequiredDependentFields { get; set; }

            [NameInMap("DynamicFieldRequiredInfluencedFields")]
            [Validation(Required=false)]
            public List<long?> DynamicFieldRequiredInfluencedFields { get; set; }

            [NameInMap("DynamicOptionFetchDependentFields")]
            [Validation(Required=false)]
            public List<long?> DynamicOptionFetchDependentFields { get; set; }

            [NameInMap("DynamicOptionFetchInfluencedFields")]
            [Validation(Required=false)]
            public List<long?> DynamicOptionFetchInfluencedFields { get; set; }

            [NameInMap("PossibleValues")]
            [Validation(Required=false)]
            public List<string> PossibleValues { get; set; }

        }

    }

}
