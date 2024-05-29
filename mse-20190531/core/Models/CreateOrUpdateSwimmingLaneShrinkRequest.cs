// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneShrinkRequest : TeaModel {
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
        public List<CreateOrUpdateSwimmingLaneShrinkRequestEntryRules> EntryRules { get; set; }
        public class CreateOrUpdateSwimmingLaneShrinkRequestEntryRules : TeaModel {
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
            public List<CreateOrUpdateSwimmingLaneShrinkRequestEntryRulesRestItems> RestItems { get; set; }
            public class CreateOrUpdateSwimmingLaneShrinkRequestEntryRulesRestItems : TeaModel {
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
        public string GatewaySwimmingLaneRouteJsonShrink { get; set; }

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
