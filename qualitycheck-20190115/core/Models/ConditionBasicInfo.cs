// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ConditionBasicInfo : TeaModel {
        [NameInMap("Check_range")]
        [Validation(Required=false)]
        public ConditionBasicInfoCheckRange CheckRange { get; set; }
        public class ConditionBasicInfoCheckRange : TeaModel {
            [NameInMap("Absolute")]
            [Validation(Required=false)]
            public bool? Absolute { get; set; }

            [NameInMap("AllSentencesSatisfy")]
            [Validation(Required=false)]
            public bool? AllSentencesSatisfy { get; set; }

            [NameInMap("Anchor")]
            [Validation(Required=false)]
            public ConditionBasicInfoCheckRangeAnchor Anchor { get; set; }
            public class ConditionBasicInfoCheckRangeAnchor : TeaModel {
                [NameInMap("Cid")]
                [Validation(Required=false)]
                public string Cid { get; set; }

                [NameInMap("Hit_time")]
                [Validation(Required=false)]
                public int? HitTime { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

            }

            [NameInMap("Range")]
            [Validation(Required=false)]
            public ConditionBasicInfoCheckRangeRange Range { get; set; }
            public class ConditionBasicInfoCheckRangeRange : TeaModel {
                [NameInMap("From")]
                [Validation(Required=false)]
                public int? From { get; set; }

                [NameInMap("To")]
                [Validation(Required=false)]
                public int? To { get; set; }

            }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public int? RoleId { get; set; }

        }

        [NameInMap("Cid")]
        [Validation(Required=false)]
        public string Cid { get; set; }

        [NameInMap("Exclusion")]
        [Validation(Required=false)]
        public int? Exclusion { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Lambda")]
        [Validation(Required=false)]
        public string Lambda { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Operators")]
        [Validation(Required=false)]
        public List<OperatorBasicInfo> Operators { get; set; }

        [NameInMap("Rid")]
        [Validation(Required=false)]
        public string Rid { get; set; }

        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public string UserGroup { get; set; }

    }

}
