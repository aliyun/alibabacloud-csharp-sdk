// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CreateSanityCheckTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BEBDF2EE-642E-5992-8907-D2011A7ACEFE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>917479ff-c869-49ea-908e-ae85bd987bc0</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
