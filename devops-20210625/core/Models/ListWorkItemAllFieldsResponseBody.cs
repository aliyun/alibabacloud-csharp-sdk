// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkItemAllFieldsResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<ListWorkItemAllFieldsResponseBodyFields> Fields { get; set; }
        public class ListWorkItemAllFieldsResponseBodyFields : TeaModel {
            [NameInMap("className")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("defaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("isRequired")]
            [Validation(Required=false)]
            public bool? IsRequired { get; set; }

            [NameInMap("isShowWhenCreate")]
            [Validation(Required=false)]
            public bool? IsShowWhenCreate { get; set; }

            [NameInMap("isSystemRequired")]
            [Validation(Required=false)]
            public bool? IsSystemRequired { get; set; }

            [NameInMap("linkWithService")]
            [Validation(Required=false)]
            public string LinkWithService { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("options")]
            [Validation(Required=false)]
            public List<ListWorkItemAllFieldsResponseBodyFieldsOptions> Options { get; set; }
            public class ListWorkItemAllFieldsResponseBodyFieldsOptions : TeaModel {
                [NameInMap("displayValue")]
                [Validation(Required=false)]
                public string DisplayValue { get; set; }

                [NameInMap("fieldIdentifier")]
                [Validation(Required=false)]
                public string FieldIdentifier { get; set; }

                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public long? Level { get; set; }

                [NameInMap("position")]
                [Validation(Required=false)]
                public long? Position { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("valueEn")]
                [Validation(Required=false)]
                public string ValueEn { get; set; }

            }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
