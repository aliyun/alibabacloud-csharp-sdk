// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeComfyTaskWaitingQueueRequest : TeaModel {
        /// <summary>
        /// <para>The waiting queue information of a specified Hive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive-26cd567b35c04a0a90f0xxxxx</para>
        /// </summary>
        [NameInMap("HiveId")]
        [Validation(Required=false)]
        public string HiveId { get; set; }

    }

}
