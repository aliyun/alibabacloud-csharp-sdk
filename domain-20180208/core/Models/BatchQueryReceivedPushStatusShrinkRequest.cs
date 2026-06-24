// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class BatchQueryReceivedPushStatusShrinkRequest : TeaModel {
        /// <summary>
        /// <para>本次请求最多返回的记录条数</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>标记当前开始读取的位置，置空表示从头开始</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Push编号列表，最多50个</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;push_20250101_abc123&quot;,&quot;push_20250101_def456&quot;]</para>
        /// </summary>
        [NameInMap("PushNos")]
        [Validation(Required=false)]
        public string PushNosShrink { get; set; }

    }

}
