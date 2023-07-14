// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEventBridgeIntegrationsResponseBody : TeaModel {
        /// <summary>
        /// The information about EventBridge integrations that is returned on each page.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListEventBridgeIntegrationsResponseBodyPageBean PageBean { get; set; }
        public class ListEventBridgeIntegrationsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The EventBridge integrations.
            /// </summary>
            [NameInMap("EventBridgeIntegrations")]
            [Validation(Required=false)]
            public List<ListEventBridgeIntegrationsResponseBodyPageBeanEventBridgeIntegrations> EventBridgeIntegrations { get; set; }
            public class ListEventBridgeIntegrationsResponseBodyPageBeanEventBridgeIntegrations : TeaModel {
                /// <summary>
                /// The description of the EventBridge integration.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

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

            }

            /// <summary>
            /// The number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of EventBridge integrations that are returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
