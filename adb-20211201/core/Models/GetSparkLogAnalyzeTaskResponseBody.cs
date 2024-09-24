// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkLogAnalyzeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the Spark log analysis task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SparkAnalyzeLogTask Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1DF5AF5B-C803-1861-A0FF-63666A557709</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
