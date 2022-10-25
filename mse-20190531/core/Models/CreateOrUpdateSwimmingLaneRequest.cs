// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("EnableRules")]
        [Validation(Required=false)]
        public bool? EnableRules { get; set; }

        [NameInMap("EntryRule")]
        [Validation(Required=false)]
        public string EntryRule { get; set; }

        [NameInMap("EntryRules")]
        [Validation(Required=false)]
        public List<CreateOrUpdateSwimmingLaneRequestEntryRules> EntryRules { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestEntryRules : TeaModel {
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RestItems")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneRequestEntryRulesRestItems> RestItems { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestEntryRulesRestItems : TeaModel {
                [NameInMap("Cond")]
                [Validation(Required=false)]
                public string Cond { get; set; }

                [NameInMap("Datum")]
                [Validation(Required=false)]
                public string Datum { get; set; }

                [NameInMap("Divisor")]
                [Validation(Required=false)]
                public int? Divisor { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NameList")]
                [Validation(Required=false)]
                public List<string> NameList { get; set; }

                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("Rate")]
                [Validation(Required=false)]
                public int? Rate { get; set; }

                [NameInMap("Remainder")]
                [Validation(Required=false)]
                public int? Remainder { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("LicenseKey")]
        [Validation(Required=false)]
        public string LicenseKey { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
