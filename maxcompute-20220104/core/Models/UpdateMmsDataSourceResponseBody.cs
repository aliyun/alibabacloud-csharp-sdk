// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateMmsDataSourceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateMmsDataSourceResponseBodyData Data { get; set; }
        public class UpdateMmsDataSourceResponseBodyData : TeaModel {
            [NameInMap("asyncTaskId")]
            [Validation(Required=false)]
            public long? AsyncTaskId { get; set; }

            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>76CE80C8-7392-5591-BCC8-610AFBF78ADF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
