// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddMediaConnectFlowInputResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public AddMediaConnectFlowInputResponseBodyContent Content { get; set; }
        public class AddMediaConnectFlowInputResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>rtmp://1.2.3.4:1935/live/AliTestInput_8666ec062190f00e263012666319a5be</para>
            /// </summary>
            [NameInMap("InputUrl")]
            [Validation(Required=false)]
            public string InputUrl { get; set; }

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
        /// <para>11357BE8-4C54-58EA-890A-5AB646EDE4B2</para>
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
        public int? RetCode { get; set; }

    }

}
