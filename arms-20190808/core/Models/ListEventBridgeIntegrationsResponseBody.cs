// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEventBridgeIntegrationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about EventBridge integrations that is returned on each page.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListEventBridgeIntegrationsResponseBodyPageBean PageBean { get; set; }
        public class ListEventBridgeIntegrationsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The EventBridge integrations.</para>
            /// </summary>
            [NameInMap("EventBridgeIntegrations")]
            [Validation(Required=false)]
            public List<ListEventBridgeIntegrationsResponseBodyPageBeanEventBridgeIntegrations> EventBridgeIntegrations { get; set; }
            public class ListEventBridgeIntegrationsResponseBodyPageBeanEventBridgeIntegrations : TeaModel {
                /// <summary>
                /// <para>The description of the EventBridge integration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the EventBridge integration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the EventBridge integration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EventBridge_Test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of EventBridge integrations that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2B289756-E791-5842-BCBD-AD414C******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
