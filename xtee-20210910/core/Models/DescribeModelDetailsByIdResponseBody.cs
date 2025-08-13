// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeModelDetailsByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public List<DescribeModelDetailsByIdResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeModelDetailsByIdResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Model prediction result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;AUC\&quot;:0.9895246624946594,\&quot;Count\&quot;:2489,\&quot;DecisionMark\&quot;:[0.0,0.0010000000474974513,0.05287817938420348,0.0]}</para>
            /// </summary>
            [NameInMap("modelEffectEvaluation")]
            [Validation(Required=false)]
            public string ModelEffectEvaluation { get; set; }

        }

    }

}
