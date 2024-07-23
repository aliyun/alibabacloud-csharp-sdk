// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAvatarTrainingJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitAvatarTrainingJobResponseBodyData Data { get; set; }
        public class SubmitAvatarTrainingJobResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>29faef8144638ba42eb8e037</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><em><b><b>ACB-44F2-5F2D-88D7-1283E70</b></b></em></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
