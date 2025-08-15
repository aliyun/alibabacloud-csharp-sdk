// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class ListDataEventServicesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataEventServicesResponseBodyData Data { get; set; }
        public class ListDataEventServicesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VjE6bHJlTGoxdm1M****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("ServiceInfos")]
            [Validation(Required=false)]
            public List<ListDataEventServicesResponseBodyDataServiceInfos> ServiceInfos { get; set; }
            public class ListDataEventServicesResponseBodyDataServiceInfos : TeaModel {
                [NameInMap("EventNames")]
                [Validation(Required=false)]
                public List<string> EventNames { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Cms</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>851038F3-33AB-4C49-97D7-6AB37D35****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
