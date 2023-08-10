// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSubscriptionMetaResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the subtasks.
        /// </summary>
        [NameInMap("SubscriptionMetaList")]
        [Validation(Required=false)]
        public List<DescribeSubscriptionMetaResponseBodySubscriptionMetaList> SubscriptionMetaList { get; set; }
        public class DescribeSubscriptionMetaResponseBodySubscriptionMetaList : TeaModel {
            /// <summary>
            /// The consumer offset of the subtask. It is a UNIX timestamp that is generated when the client consumes the first data record. Unit: seconds.
            /// 
            /// >  You can use a search engine to obtain a UNIX timestamp converter.
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public long? Checkpoint { get; set; }

            /// <summary>
            /// The objects of the subtask. For more information, see [Objects of DTS tasks](~~209545~~).
            /// </summary>
            [NameInMap("DBList")]
            [Validation(Required=false)]
            public string DBList { get; set; }

            /// <summary>
            /// The endpoint and port number of the change tracking instance.
            /// </summary>
            [NameInMap("DProxyUrl")]
            [Validation(Required=false)]
            public string DProxyUrl { get; set; }

            /// <summary>
            /// The consumer group ID of the subtask.
            /// </summary>
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            /// <summary>
            /// The topic of the subtask.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
