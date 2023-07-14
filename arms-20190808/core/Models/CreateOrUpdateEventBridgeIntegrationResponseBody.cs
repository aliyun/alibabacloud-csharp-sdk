// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateEventBridgeIntegrationResponseBody : TeaModel {
        /// <summary>
        /// The information about the EventBridge integration.
        /// </summary>
        [NameInMap("EventBridgeIntegration")]
        [Validation(Required=false)]
        public CreateOrUpdateEventBridgeIntegrationResponseBodyEventBridgeIntegration EventBridgeIntegration { get; set; }
        public class CreateOrUpdateEventBridgeIntegrationResponseBodyEventBridgeIntegration : TeaModel {
            /// <summary>
            /// The AccessKey ID that is used to connect to EventBridge.
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// The AccessKey secret that is used to connect to EventBridge.
            /// </summary>
            [NameInMap("AccessSecret")]
            [Validation(Required=false)]
            public string AccessSecret { get; set; }

            /// <summary>
            /// The description of the EventBridge integration.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The public endpoint of EventBridge.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The name of the event bus.
            /// </summary>
            [NameInMap("EventBusName")]
            [Validation(Required=false)]
            public string EventBusName { get; set; }

            /// <summary>
            /// The region ID of the event bus.
            /// </summary>
            [NameInMap("EventBusRegionId")]
            [Validation(Required=false)]
            public string EventBusRegionId { get; set; }

            /// <summary>
            /// The ID of the EventBridge integration.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the EventBridge integration.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The event source.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
