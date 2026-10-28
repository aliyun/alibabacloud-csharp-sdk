// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SubmitSparkLogAnalyzeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the Spark log analysis task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SparkAnalyzeLogTask Data { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1DF5AF5B-C803-1861-A0FF-63666A557709</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
