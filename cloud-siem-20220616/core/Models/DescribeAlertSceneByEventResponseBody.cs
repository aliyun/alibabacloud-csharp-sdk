// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertSceneByEventResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAlertSceneByEventResponseBodyData> Data { get; set; }
        public class DescribeAlertSceneByEventResponseBodyData : TeaModel {
            /// <summary>
            /// The alert name. The display name of the alert name varies based on the language of the system, such as Chinese and English.
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
            /// The alert title. The display name of the alert title varies based on the language of the system, such as Chinese and English.
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
            /// The alert type. The display name of the alert type varies based on the language of the system, such as Chinese and English.
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
            /// The objects that can be added to the whitelist.
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<DescribeAlertSceneByEventResponseBodyDataTargets> Targets { get; set; }
            public class DescribeAlertSceneByEventResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// The display name of the entity attribute field that can be added to the whitelist.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The entity attribute field that can be added to the whitelist.
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
                /// The supported right operands of the whitelist rule.
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
