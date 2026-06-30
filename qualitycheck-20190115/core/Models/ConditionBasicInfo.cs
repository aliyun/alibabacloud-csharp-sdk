// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ConditionBasicInfo : TeaModel {
        /// <summary>
        /// <para>Detection range</para>
        /// </summary>
        [NameInMap("Check_range")]
        [Validation(Required=false)]
        public ConditionBasicInfoCheckRange CheckRange { get; set; }
        public class ConditionBasicInfoCheckRange : TeaModel {
            /// <summary>
            /// <para>false: relative position; the sentence position is determined in combination with the anchor and the role</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Absolute")]
            [Validation(Required=false)]
            public bool? Absolute { get; set; }

            /// <summary>
            /// <para>true: Every sentence must satisfy the condition;</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllSentencesSatisfy")]
            [Validation(Required=false)]
            public bool? AllSentencesSatisfy { get; set; }

            /// <summary>
            /// <para>Precondition and postcondition</para>
            /// </summary>
            [NameInMap("Anchor")]
            [Validation(Required=false)]
            public ConditionBasicInfoCheckRangeAnchor Anchor { get; set; }
            public class ConditionBasicInfoCheckRangeAnchor : TeaModel {
                /// <summary>
                /// <para>Condition ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("Cid")]
                [Validation(Required=false)]
                public string Cid { get; set; }

                /// <summary>
                /// <para>Hit count</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Hit_time")]
                [Validation(Required=false)]
                public int? HitTime { get; set; }

                /// <summary>
                /// <para>Location</para>
                /// 
                /// <b>Example:</b>
                /// <para>BEFORE</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

            }

            /// <summary>
            /// <para>Relative range</para>
            /// </summary>
            [NameInMap("Range")]
            [Validation(Required=false)]
            public ConditionBasicInfoCheckRangeRange Range { get; set; }
            public class ConditionBasicInfoCheckRangeRange : TeaModel {
                /// <summary>
                /// <para>Start index of the conversation</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public int? From { get; set; }

                /// <summary>
                /// <para>End index of the conversation</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public int? To { get; set; }

            }

            /// <summary>
            /// <para>Corresponds to RoleType.type</para>
            /// 
            /// <b>Example:</b>
            /// <para>客服</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Corresponds to RoleType.id</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public int? RoleId { get; set; }

        }

        /// <summary>
        /// <para>Condition ID, which may be the primary key in the database or a transformed identifier such as a, b, or c</para>
        /// 
        /// <b>Example:</b>
        /// <para>a</para>
        /// </summary>
        [NameInMap("Cid")]
        [Validation(Required=false)]
        public string Cid { get; set; }

        /// <summary>
        /// <para>Exclude</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Exclusion")]
        [Validation(Required=false)]
        public int? Exclusion { get; set; }

        /// <summary>
        /// <para>Primary key in the database</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Lambda expression; for example: a&amp;&amp;b</para>
        /// 
        /// <b>Example:</b>
        /// <para>a</para>
        /// </summary>
        [NameInMap("Lambda")]
        [Validation(Required=false)]
        public string Lambda { get; set; }

        /// <summary>
        /// <para>Condition name</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>List of operators</para>
        /// </summary>
        [NameInMap("Operators")]
        [Validation(Required=false)]
        public List<OperatorBasicInfo> Operators { get; set; }

        /// <summary>
        /// <para>ID of the rule to which the condition belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Rid")]
        [Validation(Required=false)]
        public string Rid { get; set; }

        /// <summary>
        /// <para>User group</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public string UserGroup { get; set; }

    }

}
