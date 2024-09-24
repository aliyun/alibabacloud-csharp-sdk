// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAnalyticdbByPrimaryDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of associated analytic instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AnalyticDBCount")]
        [Validation(Required=false)]
        public int? AnalyticDBCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>77862BFF-ED59-552A-A2E8-692FEAFC9527</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
