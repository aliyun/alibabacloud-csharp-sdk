// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class HotUpdateJobFailureInfo : TeaModel {
        /// <summary>
        /// <para>The error level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LOW</para>
        /// </summary>
        [NameInMap("failureSeverity")]
        [Validation(Required=false)]
        public string FailureSeverity { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The error cause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
