// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListGroupIdResponseBody : TeaModel {
        /// <summary>
        /// The details of a queried group.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGroupIdResponseBodyData> Data { get; set; }
        public class ListGroupIdResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the group was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The queried group that belongs to the ApsaraMQ for MQTT instance.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// Indicates whether a separate namespace is configured for the ApsaraMQ for MQTT instance. Valid values:
            /// 
            /// *   **true**: A separate namespace is configured for the ApsaraMQ for MQTT instance. Resource names must be unique within an ApsaraMQ for MQTT instance but can be the same across ApsaraMQ for MQTT instances.
            /// *   **false**: No separate namespace is configured for the ApsaraMQ for MQTT instance. Resource names must be globally unique within an ApsaraMQ for MQTT instance and across ApsaraMQ for MQTT instances.
            /// </summary>
            [NameInMap("IndependentNaming")]
            [Validation(Required=false)]
            public bool? IndependentNaming { get; set; }

            /// <summary>
            /// The ID of the ApsaraMQ for MQTT instance to which the group belongs.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The time when the group was last updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The request ID. This parameter is a common parameter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
