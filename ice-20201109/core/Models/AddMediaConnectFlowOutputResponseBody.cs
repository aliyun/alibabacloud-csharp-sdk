// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddMediaConnectFlowOutputResponseBody : TeaModel {
        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public AddMediaConnectFlowOutputResponseBodyContent Content { get; set; }
        public class AddMediaConnectFlowOutputResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The output URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>srt://1.2.3.4:1025</para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

        }

        /// <summary>
        /// <para>The call description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11AA9E73-FBA0-58DC-97BA-D606D847BCB6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned error code. A value of 0 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

    }

}
