// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemRequest : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试内容</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RICHTEXT</para>
        /// </summary>
        [NameInMap("descriptionFormat")]
        [Validation(Required=false)]
        public string DescriptionFormat { get; set; }

        [NameInMap("fieldValueList")]
        [Validation(Required=false)]
        public List<CreateWorkitemRequestFieldValueList> FieldValueList { get; set; }
        public class CreateWorkitemRequestFieldValueList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6aexxxxxa1d98c09c60xxxx16</para>
            /// </summary>
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>77c7fb03c4186c8691d6...</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("workitemIdentifier")]
            [Validation(Required=false)]
            public string WorkitemIdentifier { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3a0c9cdd24ae1e1995b8...</para>
        /// </summary>
        [NameInMap("parent")]
        [Validation(Required=false)]
        public string Parent { get; set; }

        [NameInMap("participant")]
        [Validation(Required=false)]
        public List<string> Participant { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asd345xxxxx9q9845xxxxx34</para>
        /// </summary>
        [NameInMap("space")]
        [Validation(Required=false)]
        public string Space { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

        [NameInMap("sprint")]
        [Validation(Required=false)]
        public List<string> Sprint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试工作项</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("tracker")]
        [Validation(Required=false)]
        public List<string> Tracker { get; set; }

        [NameInMap("verifier")]
        [Validation(Required=false)]
        public List<string> Verifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9uyxxxxxre573f561dxxn40</para>
        /// </summary>
        [NameInMap("workitemType")]
        [Validation(Required=false)]
        public string WorkitemType { get; set; }

    }

}
