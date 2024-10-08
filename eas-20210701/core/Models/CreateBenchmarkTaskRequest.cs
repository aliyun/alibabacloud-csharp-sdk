// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateBenchmarkTaskRequest : TeaModel {
        /// <summary>
        /// <para>The request body. The body includes the parameters that are set to create a stress testing task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;base&quot;: {
        ///         &quot;duration&quot;: 600
        ///     },
        ///     &quot;service&quot;: {
        ///         &quot;serviceName&quot;: &quot;test_service&quot;,
        ///         &quot;requestToken&quot;: &quot;test_token&quot;
        ///     },
        ///     &quot;data&quot;: {
        ///         &quot;path&quot;: &quot;<a href="https://larec-benchmark-cd.oss-cn-chengdu.aliyuncs.com/youbei/sv_dbmtl/data/youbei.warmup.tf.bin">https://larec-benchmark-cd.oss-cn-chengdu.aliyuncs.com/youbei/sv_dbmtl/data/youbei.warmup.tf.bin</a>&quot;,
        ///         &quot;dataType&quot;: &quot;binary&quot;
        ///     },
        ///     &quot;optional&quot;: {
        ///        &quot;maxRt&quot;: 100
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
