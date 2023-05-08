// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTraceInfoNodeResponseBody : TeaModel {
        /// <summary>
        /// The details about the node.
        /// </summary>
        [NameInMap("Node")]
        [Validation(Required=false)]
        public DescribeTraceInfoNodeResponseBodyNode Node { get; set; }
        public class DescribeTraceInfoNodeResponseBodyNode : TeaModel {
            /// <summary>
            /// The name of the node.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// An array that consists of the properties of the node.
            /// </summary>
            [NameInMap("PropertyList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoNodeResponseBodyNodePropertyList> PropertyList { get; set; }
            public class DescribeTraceInfoNodeResponseBodyNodePropertyList : TeaModel {
                /// <summary>
                /// The name of the property.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the property.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The type of the node.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
