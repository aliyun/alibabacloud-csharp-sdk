// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemV2Request : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19xxxx31947xxxx</para>
        /// </summary>
        [NameInMap("assignedTo")]
        [Validation(Required=false)]
        public string AssignedTo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Req</para>
        /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>6aexxxxxa1d98c09c60xxxx16</para>
            /// </summary>
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11223331122</para>
        /// </summary>
        [NameInMap("parentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        [NameInMap("participants")]
        [Validation(Required=false)]
        public List<string> Participants { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asd345xxxxx9q9845xxxxx34</para>
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>455532323455</para>
        /// </summary>
        [NameInMap("sprintIdentifier")]
        [Validation(Required=false)]
        public string SprintIdentifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("trackers")]
        [Validation(Required=false)]
        public List<string> Trackers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1561159309......</para>
        /// </summary>
        [NameInMap("verifier")]
        [Validation(Required=false)]
        public string Verifier { get; set; }

        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<string> Versions { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9uy29901re573f561d69jn40</para>
        /// </summary>
        [NameInMap("workitemTypeIdentifier")]
        [Validation(Required=false)]
        public string WorkitemTypeIdentifier { get; set; }

    }

}
