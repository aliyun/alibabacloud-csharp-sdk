// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetSnapshotSettingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7B6CE6E1-5BA0-56DA-BFFD-8D90692F1EFC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSnapshotSettingResponseBodyResult Result { get; set; }
        public class GetSnapshotSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 01 ? * * *</para>
            /// </summary>
            [NameInMap("quartzRegex")]
            [Validation(Required=false)]
            public string QuartzRegex { get; set; }

        }

    }

}
