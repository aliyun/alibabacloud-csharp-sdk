// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class HotUpdateJobStatus : TeaModel {
        /// <summary>
        /// <para>The error message of the dynamical update.</para>
        /// </summary>
        [NameInMap("failure")]
        [Validation(Required=false)]
        public HotUpdateJobFailureInfo Failure { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBC799F0-AS7S-1D30-8A4F-882ED4DD****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the dynamic update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HOT_UPDATED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
