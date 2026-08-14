// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DeleteDtsJobsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the data migration, data synchronization, or change tracking tasks.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify up to 10 task IDs, separated by commas (,).</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the DTS task IDs.</description></item>
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
        /// <para>The region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>A special parameter for specific business scenarios. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg3m1213ye7l****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>A special parameter for specific business scenarios. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
