// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventTypesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the types of anomalous events.
        /// 
        /// > If you leave the ParentTypeId parameter empty, anomalous event types are returned. If you set the ParentTypeId parameter, anomalous event subtypes under the specified anomalous event type are returned.
        /// </summary>
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public List<DescribeEventTypesResponseBodyEventTypeList> EventTypeList { get; set; }
        public class DescribeEventTypesResponseBodyEventTypeList : TeaModel {
            /// <summary>
            /// The code of the anomalous event type.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The description of the anomalous event type.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the anomalous event type.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the anomalous event type.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// An array that consists of anomalous event subtypes.
            /// </summary>
            [NameInMap("SubTypeList")]
            [Validation(Required=false)]
            public List<DescribeEventTypesResponseBodyEventTypeListSubTypeList> SubTypeList { get; set; }
            public class DescribeEventTypesResponseBodyEventTypeListSubTypeList : TeaModel {
                /// <summary>
                /// The service to which the anomalous event detection rule applies. Valid values include **MaxCompute, OSS, ADS, OTS, and RDS**.
                /// </summary>
                [NameInMap("AdaptedProduct")]
                [Validation(Required=false)]
                public string AdaptedProduct { get; set; }

                /// <summary>
                /// The code of the anomalous event subtype.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The code of the configuration.
                /// </summary>
                [NameInMap("ConfigCode")]
                [Validation(Required=false)]
                public string ConfigCode { get; set; }

                /// <summary>
                /// The content format of anomalous event detection rule. Valid values:
                /// 
                /// *   **0**: numeric values such as thresholds
                /// *   **1**: text such as IP addresses
                /// </summary>
                [NameInMap("ConfigContentType")]
                [Validation(Required=false)]
                public int? ConfigContentType { get; set; }

                /// <summary>
                /// The description of the configuration.
                /// </summary>
                [NameInMap("ConfigDescription")]
                [Validation(Required=false)]
                public string ConfigDescription { get; set; }

                /// <summary>
                /// The value of the configuration.
                /// </summary>
                [NameInMap("ConfigValue")]
                [Validation(Required=false)]
                public string ConfigValue { get; set; }

                /// <summary>
                /// The description of the anomalous event subtype.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The number of times that the anomalous event hits the anomalous event detection rule.
                /// </summary>
                [NameInMap("EventHitCount")]
                [Validation(Required=false)]
                public int? EventHitCount { get; set; }

                /// <summary>
                /// The ID of the anomalous event subtype.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The name of the anomalous event subtype.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Indicates whether detection is enabled for the anomalous event subtype. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
