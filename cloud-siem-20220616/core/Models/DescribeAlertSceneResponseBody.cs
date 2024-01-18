// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertSceneResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAlertSceneResponseBodyData> Data { get; set; }
        public class DescribeAlertSceneResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the alert. The value varies based on the display language (Chinese or English) of the Security Center console.
            /// </summary>
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            /// <summary>
            /// The ID of the alert name.
            /// </summary>
            [NameInMap("AlertNameId")]
            [Validation(Required=false)]
            public string AlertNameId { get; set; }

            /// <summary>
            /// The title of the alert notification. The value varies based on the display language (Chinese or English) of the Security Center console.
            /// </summary>
            [NameInMap("AlertTile")]
            [Validation(Required=false)]
            public string AlertTile { get; set; }

            /// <summary>
            /// The ID of the alert title.
            /// </summary>
            [NameInMap("AlertTileId")]
            [Validation(Required=false)]
            public string AlertTileId { get; set; }

            /// <summary>
            /// The type of the alert. The value varies based on the display language (Chinese or English) of the Security Center console.
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// The ID of the alert type.
            /// </summary>
            [NameInMap("AlertTypeId")]
            [Validation(Required=false)]
            public string AlertTypeId { get; set; }

            /// <summary>
            /// The information about the entities for which you need to add the alert to the whitelist.
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<DescribeAlertSceneResponseBodyDataTargets> Targets { get; set; }
            public class DescribeAlertSceneResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// The display name of the attribute for the entity.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The attribute of the entity.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The right operand that is displayed by default in the whitelist rule.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// The right operands supported by the whitelist rule.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
