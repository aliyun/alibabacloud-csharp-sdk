// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class StopDistributionCommand : TeaModel {
        /// <summary>
        /// <para>The LM shop ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21000019</para>
        /// </summary>
        [NameInMap("lmShopId")]
        [Validation(Required=false)]
        public string LmShopId { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>660057403063402509</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48A34399-A72C-1E23-8388-7E63A1B2E927</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The submission time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-01 10:01:00</para>
        /// </summary>
        [NameInMap("requestTime")]
        [Validation(Required=false)]
        public string RequestTime { get; set; }

        /// <summary>
        /// <para>The submitter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_user</para>
        /// </summary>
        [NameInMap("requestUser")]
        [Validation(Required=false)]
        public string RequestUser { get; set; }

    }

}
