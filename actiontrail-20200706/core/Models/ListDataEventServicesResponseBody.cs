// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class ListDataEventServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataEventServicesResponseBodyData Data { get; set; }
        public class ListDataEventServicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries returned for the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VjE6bHJlTGoxdm1M****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The supported Alibaba Cloud services and the data events for each service.</para>
            /// </summary>
            [NameInMap("ServiceInfos")]
            [Validation(Required=false)]
            public List<ListDataEventServicesResponseBodyDataServiceInfos> ServiceInfos { get; set; }
            public class ListDataEventServicesResponseBodyDataServiceInfos : TeaModel {
                /// <summary>
                /// <para>The data events supported by the service.</para>
                /// </summary>
                [NameInMap("EventNames")]
                [Validation(Required=false)]
                public List<string> EventNames { get; set; }

                /// <summary>
                /// <para>The cloud service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cms</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>851038F3-33AB-4C49-97D7-6AB37D35****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
