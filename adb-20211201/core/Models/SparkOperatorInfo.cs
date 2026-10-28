// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkOperatorInfo : TeaModel {
        /// <summary>
        /// <para>The metric value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MetricValue")]
        [Validation(Required=false)]
        public long? MetricValue { get; set; }

        /// <summary>
        /// <para>The operator name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TableScan</para>
        /// </summary>
        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public byte[] OperatorName { get; set; }

    }

}
