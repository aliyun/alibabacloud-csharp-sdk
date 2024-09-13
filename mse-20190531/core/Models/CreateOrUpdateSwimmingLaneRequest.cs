// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values: zh and en. Default value: zh. The value zh indicates Chinese, and the value en indicates English.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Specifies whether to enable the lane.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Specifies whether to configure a routing rule for the lane. If an Ingress gateway is used, this parameter is not required.
        /// </summary>
        [NameInMap("EnableRules")]
        [Validation(Required=false)]
        public bool? EnableRules { get; set; }

        /// <summary>
        /// The JSON string.
        /// </summary>
        [NameInMap("EntryRule")]
        [Validation(Required=false)]
        [Obsolete]
        public string EntryRule { get; set; }

        [NameInMap("EntryRules")]
        [Validation(Required=false)]
        public List<CreateOrUpdateSwimmingLaneRequestEntryRules> EntryRules { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestEntryRules : TeaModel {
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

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

        /// <summary>
        /// The information about the routing rule for the gateway. This parameter is required when a cloud-native gateway is used as the ingress.
        /// </summary>
        [NameInMap("GatewaySwimmingLaneRouteJson")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJson GatewaySwimmingLaneRouteJson { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJson : TeaModel {
            [NameInMap("CanaryModel")]
            [Validation(Required=false)]
            public int? CanaryModel { get; set; }

            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// The matching conditions.
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJsonConditions> Conditions { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJsonConditions : TeaModel {
                /// <summary>
                /// The matching condition. Valid values:
                /// 
                /// *   PRE: prefix matching
                /// *   EQUAL: exact matching
                /// *   ERGULAR: regular expression matching
                /// </summary>
                [NameInMap("Cond")]
                [Validation(Required=false)]
                public string Cond { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type of the parameter. Valid values:
                /// 
                /// *   header
                /// *   param
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the gateway.
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// The unique ID of the gateway.
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

            /// <summary>
            /// The route IDs.
            /// </summary>
            [NameInMap("RouteIdList")]
            [Validation(Required=false)]
            public List<long?> RouteIdList { get; set; }

            [NameInMap("RouteIndependentPercentageEnable")]
            [Validation(Required=false)]
            public bool? RouteIndependentPercentageEnable { get; set; }

            [NameInMap("RouteIndependentPercentageList")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJsonRouteIndependentPercentageList> RouteIndependentPercentageList { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJsonRouteIndependentPercentageList : TeaModel {
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                [NameInMap("RouteId")]
                [Validation(Required=false)]
                public long? RouteId { get; set; }

            }

        }

        /// <summary>
        /// The language of the response. Valid values:****
        /// 
        /// *   **zh-CN**: Chinese
        /// *   **en-US**: English
        /// 
        /// > Default value: **zh-CN**.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The ID of the primary key. The value -1 indicates a request that is used to create a lane. A value greater than 0 indicates a request that is used to modify a lane.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The name of the lane.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("PathIndependentPercentageEnable")]
        [Validation(Required=false)]
        public bool? PathIndependentPercentageEnable { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tag.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
