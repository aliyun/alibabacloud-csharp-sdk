// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SubmitVLExtractionTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data structure.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public SubmitVLExtractionTaskResponseBodyData Data { get; set; }
        public class SubmitVLExtractionTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>411ce93a-7eb5-40cf-836a-53c32f097663</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
