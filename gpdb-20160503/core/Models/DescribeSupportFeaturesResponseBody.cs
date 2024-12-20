// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSupportFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63E5BE60-91FF-57F1-B873-7F1EB734B93D_2724</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The features supported by the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sample_data: sample dataset. For more information, see <a href="https://help.aliyun.com/document_detail/452278.html">Sample dataset</a>.</description></item>
        /// <item><description>diagnose_and_optimize: diagnostics and optimization. For more information, see <a href="https://help.aliyun.com/document_detail/323453.html">Diagnostics and optimization</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[ &quot;sample_data&quot;, &quot;diagnose_and_optimize&quot; ]</para>
        /// </summary>
        [NameInMap("SupportFeatureList")]
        [Validation(Required=false)]
        public string SupportFeatureList { get; set; }

    }

}
