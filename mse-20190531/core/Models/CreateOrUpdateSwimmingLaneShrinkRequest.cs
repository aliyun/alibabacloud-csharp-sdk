// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneShrinkRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:****
        /// 
        /// *   **zh-CN**: Chinese
        /// *   **en-US**: English.
        /// 
        /// > Default value: **zh-CN**.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Specifies whether to enable a lane.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Specifies whether to set a routing rule for the lane. If an Ingress gateway is used, this parameter is not required.
        /// </summary>
        [NameInMap("EnableRules")]
        [Validation(Required=false)]
        public bool? EnableRules { get; set; }

        /// <summary>
        /// The JSON string.
        /// </summary>
        [NameInMap("EntryRule")]
        [Validation(Required=false)]
        public string EntryRule { get; set; }

        /// <summary>
        /// The lane.
        /// </summary>
        [NameInMap("EntryRules")]
        [Validation(Required=false)]
        public List<CreateOrUpdateSwimmingLaneShrinkRequestEntryRules> EntryRules { get; set; }
        public class CreateOrUpdateSwimmingLaneShrinkRequestEntryRules : TeaModel {
            /// <summary>
            /// The common parameters in the JSON format.
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// Specifies whether to enable the rule. Valid values:
            /// 
            /// *   `true`: enables the rule.
            /// *   `false`: disables the rule.
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The path.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The list of paths.
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// The priority. A smaller value of this parameter indicates a higher priority.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// The information about the rule for the REST method.
            /// </summary>
            [NameInMap("RestItems")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneShrinkRequestEntryRulesRestItems> RestItems { get; set; }
            public class CreateOrUpdateSwimmingLaneShrinkRequestEntryRulesRestItems : TeaModel {
                /// <summary>
                /// The expression. =, >, <, >=, <=
                /// </summary>
                [NameInMap("Cond")]
                [Validation(Required=false)]
                public string Cond { get; set; }

                /// <summary>
                /// The base value used for the rawvalue operator.
                /// </summary>
                [NameInMap("Datum")]
                [Validation(Required=false)]
                public string Datum { get; set; }

                /// <summary>
                /// The divisor used for the mod operator.
                /// </summary>
                [NameInMap("Divisor")]
                [Validation(Required=false)]
                public int? Divisor { get; set; }

                /// <summary>
                /// The name of the rule. This parameter corresponds to the key of the Type parameter.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The list of names.
                /// </summary>
                [NameInMap("NameList")]
                [Validation(Required=false)]
                public List<string> NameList { get; set; }

                /// <summary>
                /// The operator type. Valid values: mod, list, rawvalue, and rate.
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// The rate.
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public int? Rate { get; set; }

                /// <summary>
                /// The remainder used for the mod operator.
                /// </summary>
                [NameInMap("Remainder")]
                [Validation(Required=false)]
                public int? Remainder { get; set; }

                /// <summary>
                /// The type of the rule. Valid values: cookie, param, and header.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The content of the rule.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("GatewaySwimmingLaneRouteJson")]
        [Validation(Required=false)]
        public string GatewaySwimmingLaneRouteJsonShrink { get; set; }

        /// <summary>
        /// The creation time.
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// The update time.
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// The group to which the lane belongs.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The ID of the primary key. A value -1 specifies a request that is used to create a lane. A value greater than 0 specifies a request that is used to modify a lane.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The license key in use.
        /// </summary>
        [NameInMap("LicenseKey")]
        [Validation(Required=false)]
        public string LicenseKey { get; set; }

        /// <summary>
        /// The name of the lane.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The service source. Valid value: edasmsc.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The value 0 indicates that the lane is disabled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The tag.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The Alibaba Cloud account. The format is a number, such as 136246975637\*\*\*\*. You can leave this parameter empty.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
