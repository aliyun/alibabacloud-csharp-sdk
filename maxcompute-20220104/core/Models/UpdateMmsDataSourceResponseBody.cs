// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateMmsDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateMmsDataSourceResponseBodyData Data { get; set; }
        public class UpdateMmsDataSourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the asynchronous task. When you test the data source configuration, this ID is used to obtain the test result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("asyncTaskId")]
            [Validation(Required=false)]
            public long? AsyncTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000017</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76CE80C8-7392-5591-BCC8-610AFBF78ADF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
