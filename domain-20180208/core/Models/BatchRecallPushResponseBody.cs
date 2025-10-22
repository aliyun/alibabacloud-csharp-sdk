// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class BatchRecallPushResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public BatchRecallPushResponseBodyModule Module { get; set; }
        public class BatchRecallPushResponseBodyModule : TeaModel {
            [NameInMap("RecallResults")]
            [Validation(Required=false)]
            public List<BatchRecallPushResponseBodyModuleRecallResults> RecallResults { get; set; }
            public class BatchRecallPushResponseBodyModuleRecallResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>成功</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NL20250508100515000002</para>
                /// </summary>
                [NameInMap("OutBizId")]
                [Validation(Required=false)]
                public string OutBizId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C39ECA8A-BB5E-4F92-B013-6A032FA06B04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
