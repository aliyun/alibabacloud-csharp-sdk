// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedOriginalQuery : TeaModel {
        /// <summary>
        /// <para>The request query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州美食</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The publish time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoLimit</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
