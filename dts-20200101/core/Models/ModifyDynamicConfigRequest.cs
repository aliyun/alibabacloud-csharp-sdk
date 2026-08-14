// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDynamicConfigRequest : TeaModel {
        /// <summary>
        /// <para>The rate limit configurations.</para>
        /// <list type="bullet">
        /// <item><description><b>dts.datamove.blaster.qps.max</b>: the queries per second (QPS) for querying the source database.</description></item>
        /// <item><description><b>dts.datamove.source.rps.max</b>: the records per second (RPS) for full data synchronization or migration.</description></item>
        /// <item><description><b>dts.datamove.source.bps.max</b>: the data volume per second for full data synchronization or migration. Unit: bytes per second.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If <b>JobCode</b> is set to <b>03</b>, you must set <b>EnableLimit</b> to <b>true</b> for the three parameters to take effect.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If <b>JobCode</b> is set to <b>04</b> or <b>07</b>, you only need to configure <b>dts.datamove.source.rps.max</b> and <b>dts.datamove.source.bps.max</b>.</description></item>
        /// <item><description>A value of <b>-1</b> indicates that no rate limit is applied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;dts.datamove.source.rps.max&quot;: 5000,
        ///       &quot;dts.datamove.source.bps.max&quot;: 10485760
        /// }</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public string ConfigList { get; set; }

        /// <summary>
        /// <para>The ID of the data synchronization or migration task.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to obtain the task ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta7w132u12h****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>Specifies whether to limit the migration rate of the full data synchronization or migration task. Valid values: <b>true</b> and <b>false</b>.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>JobCode</b> is set to <b>03</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLimit")]
        [Validation(Required=false)]
        public bool? EnableLimit { get; set; }

        /// <summary>
        /// <para>The task code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>03</b>: full data synchronization or migration task.</description></item>
        /// <item><description><b>04</b>: incremental data migration task.</description></item>
        /// <item><description><b>07</b>: incremental data synchronization task.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07</para>
        /// </summary>
        [NameInMap("JobCode")]
        [Validation(Required=false)]
        public string JobCode { get; set; }

        /// <summary>
        /// <para>The ID of the region where the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
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
        /// <para>rg-aekz6zsi7ce5rpy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
