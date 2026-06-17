// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAccessInstanceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the synchronization node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdi-3bc2f91695ee48bd9377</para>
        /// </summary>
        [NameInMap("AccessInstanceId")]
        [Validation(Required=false)]
        public string AccessInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the synchronization node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AckClusterConnector</para>
        /// </summary>
        [NameInMap("AccessInstanceType")]
        [Validation(Required=false)]
        public string AccessInstanceType { get; set; }

        /// <summary>
        /// <para>The language of the response messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-c92d4544ef7b6a42</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
