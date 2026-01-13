// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CancelKyuubiSparkApplicationResponseBody : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public CancelKyuubiSparkApplicationResponseBodyBody Body { get; set; }
        public class CancelKyuubiSparkApplicationResponseBodyBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>spark-339f844005b6404c95f9f7c7a13b****</para>
            /// </summary>
            [NameInMap("applicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
