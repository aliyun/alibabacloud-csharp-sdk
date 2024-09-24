// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTraceInfoNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the node.</para>
        /// </summary>
        [NameInMap("Node")]
        [Validation(Required=false)]
        public DescribeTraceInfoNodeResponseBodyNode Node { get; set; }
        public class DescribeTraceInfoNodeResponseBodyNode : TeaModel {
            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>An array that consists of the properties of the node.</para>
            /// </summary>
            [NameInMap("PropertyList")]
            [Validation(Required=false)]
            public List<DescribeTraceInfoNodeResponseBodyNodePropertyList> PropertyList { get; set; }
            public class DescribeTraceInfoNodeResponseBodyNodePropertyList : TeaModel {
                /// <summary>
                /// <para>The name of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Incident</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alert</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alert</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62DXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
