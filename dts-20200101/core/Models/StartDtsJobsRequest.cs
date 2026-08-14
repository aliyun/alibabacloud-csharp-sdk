// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class StartDtsJobsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the data migration or synchronization tasks.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Separate multiple task IDs with commas (,).</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query DTS task IDs.</description></item>
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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the node is a seamless integration (zero-ETL) node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No.</description></item>
        /// <item><description><b>true</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
