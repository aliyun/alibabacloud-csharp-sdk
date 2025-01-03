// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateTestResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>131xxx38624xxxx68</para>
        /// </summary>
        [NameInMap("executor")]
        [Validation(Required=false)]
        public string Executor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TO DO</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
