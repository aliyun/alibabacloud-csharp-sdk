// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DryRunViolation : TeaModel {
        /// <summary>
        /// <para>The path of the violated field, such as schedule.intervalSecs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schedule.intervalSecs</para>
        /// </summary>
        [NameInMap("field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The violation description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schedule interval must be a multiple of 15 seconds</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The remediation suggestion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>must satisfy: 15-86400 seconds and a multiple of 15</para>
        /// </summary>
        [NameInMap("suggestion")]
        [Validation(Required=false)]
        public string Suggestion { get; set; }

    }

}
