// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryTraceExtractJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTraceExtractJobResponseBodyData Data { get; set; }
        public class QueryTraceExtractJobResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>example water mark</para>
            /// </summary>
            [NameInMap("Trace")]
            [Validation(Required=false)]
            public string Trace { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D9F3008-9316-5817-BFA3-6180D752039D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
