// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsDataSourceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateMmsDataSourceResponseBodyData Data { get; set; }
        public class CreateMmsDataSourceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("dataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B42CA730-8187-50F1-9FE0-6733297036DB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
