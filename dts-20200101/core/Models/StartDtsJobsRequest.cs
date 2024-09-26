// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class StartDtsJobsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data migration or data synchronization task.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For multiple tasks, separate them with commas (<b>,</b>).</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l5o11f9029c****</para>
        /// </summary>
        [NameInMap("DtsJobIds")]
        [Validation(Required=false)]
        public string DtsJobIds { get; set; }

        /// <summary>
        /// <para>The region ID of the DTS instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
