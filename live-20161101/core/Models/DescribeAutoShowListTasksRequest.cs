// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeAutoShowListTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio whose scheduled tasks you want to query.</para>
        /// <remarks>
        /// <para>If you create a scheduled task by calling the <a href="https://help.aliyun.com/document_detail/2848056.html">InitializeAutoShowListTask</a> operation, use the CasterId value returned by that operation. If you leave this parameter empty, all scheduled tasks under your account are queried by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
