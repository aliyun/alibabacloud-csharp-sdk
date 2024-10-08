// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateBenchmarkTaskRequest : TeaModel {
        /// <summary>
        /// <para>The request body. The body includes the parameters that are set to create a stress testing task. For more information, see <b>Table 1. Fields in the base parameter</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;base&quot;:  {
        ///          &quot;qps&quot;: 200
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
