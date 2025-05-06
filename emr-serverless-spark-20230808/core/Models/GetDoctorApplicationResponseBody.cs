// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetDoctorApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDoctorApplicationResponseBodyData Data { get; set; }
        public class GetDoctorApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The diagnostics list.</para>
            /// </summary>
            [NameInMap("suggestions")]
            [Validation(Required=false)]
            public List<string> Suggestions { get; set; }

        }

    }

}
