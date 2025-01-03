// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateProjectFieldResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>errormessage</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("project")]
        [Validation(Required=false)]
        public UpdateProjectFieldResponseBodyProject Project { get; set; }
        public class UpdateProjectFieldResponseBodyProject : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Project</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Project</para>
            /// </summary>
            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19xx7043xxxxxxx914</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OJAY</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>b787ff504c0b36f8b71d15a4fd</para>
                /// </summary>
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ace3wxxxxxxx7rff3ee</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("valueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1623916393000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1684134690000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxxxx.png">https://xxxxxx.png</a></para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxxxx.png">https://xxxxxx.png</a></para>
            /// </summary>
            [NameInMap("iconBig")]
            [Validation(Required=false)]
            public string IconBig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;small&quot;:&quot;<a href="https://xxxxxx.png%22,%22big%22:%22https://img.yyyyyy.png%22%7D">https://xxxxxx.png&quot;,&quot;big&quot;:&quot;https://img.yyyyyy.png&quot;}</a></para>
            /// </summary>
            [NameInMap("iconGroup")]
            [Validation(Required=false)]
            public string IconGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://img.yyyyyy.png">https://img.yyyyyy.png</a></para>
            /// </summary>
            [NameInMap("iconSmall")]
            [Validation(Required=false)]
            public string IconSmall { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>66893</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1e2ea73d24652d5874d001b351</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e8b2xxxxxx2abdxxxxxxxx23</para>
            /// </summary>
            [NameInMap("identifierPath")]
            [Validation(Required=false)]
            public string IdentifierPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("logicalStatus")]
            [Validation(Required=false)]
            public string LogicalStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19xx7043xxxxxxx914</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5e70xxxxxxcd000xxxxe96</para>
            /// </summary>
            [NameInMap("organizationIdentifier")]
            [Validation(Required=false)]
            public string OrganizationIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("parentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8a40xxxxxxxxxxxxx64</para>
            /// </summary>
            [NameInMap("statusIdentifier")]
            [Validation(Required=false)]
            public string StatusIdentifier { get; set; }

            [NameInMap("statusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8a4058a71159b68254......</para>
            /// </summary>
            [NameInMap("statusStageIdentifier")]
            [Validation(Required=false)]
            public string StatusStageIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CustomProject</para>
            /// </summary>
            [NameInMap("typeIdentifier")]
            [Validation(Required=false)]
            public string TypeIdentifier { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>true/false</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
