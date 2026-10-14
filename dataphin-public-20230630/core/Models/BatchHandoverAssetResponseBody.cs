// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class BatchHandoverAssetResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result of the batch asset owner transfer.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchHandoverAssetResponseBodyData Data { get; set; }
        public class BatchHandoverAssetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error message. This parameter is empty if no error occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NullPointException</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The number of failed transfers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>The list of asset GUIDs for which the transfer failed. This parameter is empty if all transfers succeed.</para>
            /// </summary>
            [NameInMap("FailedGuids")]
            [Validation(Required=false)]
            public List<string> FailedGuids { get; set; }

            /// <summary>
            /// <para>The status of the batch transfer task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: Initial.</description></item>
            /// <item><description>HANDOVER_RECORDS_GENERATED: Records generated.</description></item>
            /// <item><description>PROCESSING_WITHOUT_APPROVAL: Processing.</description></item>
            /// <item><description>SUCCESS: Success.</description></item>
            /// <item><description>FINISHED_WITH_EXCEPTION: Finished with failures.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of successful transfers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>The total number of transferred assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
