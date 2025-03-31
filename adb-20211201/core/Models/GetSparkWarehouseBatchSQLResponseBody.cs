// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkWarehouseBatchSQLResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;DBClusterId\&quot;: \&quot;amv-uf6485635fz852mn\&quot;, \&quot;Statements\&quot;: [{\&quot;Code\&quot;: \&quot;show databases\&quot;, \&quot;State\&quot;: \&quot;FINISHED\&quot;, \&quot;StatementId\&quot;: \&quot;sq202501141001sh8e12e080006846-0000\&quot;, \&quot;Result\&quot;: \&quot;+--------------------+n</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SparkBatchSQL Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3D44EDA0-A9DC-580D-9B5A-019370C075F4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
