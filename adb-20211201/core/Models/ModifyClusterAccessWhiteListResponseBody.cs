// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyClusterAccessWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>370D09FD-442A-5225-AAD3-7362CAE39177</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1564657730</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
