// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class TransferInstanceClassRequest : TeaModel {
        [NameInMap("DatabaseCount")]
        [Validation(Required=false)]
        public int? DatabaseCount { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or data synchronization task. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r4yr723m199****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The instance specifications after the upgrade. You can call <a href="https://help.aliyun.com/document_detail/208925.html">DescribeDtsJobDetail</a> to query the instance specifications before the upgrade.</para>
        /// <list type="bullet">
        /// <item><description>Specifications supported by data migration instances: <b>xxlarge</b>, <b>xlarge</b>, <b>large</b>, <b>medium</b>, and <b>small</b>.</description></item>
        /// <item><description>Specifications supported by data synchronization instances: <b>large</b>, <b>medium</b>, <b>small</b>, and <b>micro</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the description and performance test results of each specification, see <a href="https://help.aliyun.com/document_detail/26606.html">Specifications of data migration instances</a> and <a href="https://help.aliyun.com/document_detail/26605.html">Specifications of data synchronization instances</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>large</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>Set this parameter to <b>UPGRADE</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
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

    }

}
