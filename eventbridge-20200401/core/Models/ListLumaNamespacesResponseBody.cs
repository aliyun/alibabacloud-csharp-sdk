// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListLumaNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates a successful call. A specific error code is returned upon failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of namespaces bound to the Agent. All results are returned at once without pagination.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLumaNamespacesResponseBodyData Data { get; set; }
        public class ListLumaNamespacesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of namespaces bound to the Agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Name&quot;:&quot;my_namespace&quot;}]</para>
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<Namespace> Namespaces { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the operation. The value is Operation success when the call succeeds, or a specific error description when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, used for troubleshooting and ticket feedback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of true indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
