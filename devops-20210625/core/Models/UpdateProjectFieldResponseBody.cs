// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateProjectFieldResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("project")]
        [Validation(Required=false)]
        public UpdateProjectFieldResponseBodyProject Project { get; set; }
        public class UpdateProjectFieldResponseBodyProject : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("customCode")]
            [Validation(Required=false)]
            public string CustomCode { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("fieldList")]
            [Validation(Required=false)]
            public List<UpdateProjectFieldResponseBodyProjectFieldList> FieldList { get; set; }
            public class UpdateProjectFieldResponseBodyProjectFieldList : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("valueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("iconBig")]
            [Validation(Required=false)]
            public string IconBig { get; set; }

            [NameInMap("iconGroup")]
            [Validation(Required=false)]
            public string IconGroup { get; set; }

            [NameInMap("iconSmall")]
            [Validation(Required=false)]
            public string IconSmall { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("identifierPath")]
            [Validation(Required=false)]
            public string IdentifierPath { get; set; }

            [NameInMap("logicalStatus")]
            [Validation(Required=false)]
            public string LogicalStatus { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("organizationIdentifier")]
            [Validation(Required=false)]
            public string OrganizationIdentifier { get; set; }

            [NameInMap("parentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("statusIdentifier")]
            [Validation(Required=false)]
            public string StatusIdentifier { get; set; }

            [NameInMap("statusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            [NameInMap("statusStageIdentifier")]
            [Validation(Required=false)]
            public string StatusStageIdentifier { get; set; }

            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            [NameInMap("typeIdentifier")]
            [Validation(Required=false)]
            public string TypeIdentifier { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true/false
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
