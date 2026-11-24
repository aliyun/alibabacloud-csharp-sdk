// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AuthReportInterval : TeaModel {
        /// <summary>
        /// <para>The unit of the effective recovery duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Minute</b>: Minutes.</description></item>
        /// <item><description><b>Hour</b>: Hours.</description></item>
        /// <item><description><b>Day</b>: Days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Minute</para>
        /// </summary>
        [NameInMap("TimeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        /// <summary>
        /// <para>The numeric value of the effective recovery duration. The unit is specified by TimeUnit. A non-zero value must be at least 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public long? Value { get; set; }

    }

}
