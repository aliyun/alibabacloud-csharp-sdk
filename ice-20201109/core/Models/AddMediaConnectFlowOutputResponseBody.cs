// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddMediaConnectFlowOutputResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public AddMediaConnectFlowOutputResponseBodyContent Content { get; set; }
        public class AddMediaConnectFlowOutputResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>srt://1.2.3.4:1025</para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11AA9E73-FBA0-58DC-97BA-D606D847BCB6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public string RetCode { get; set; }

    }

}
