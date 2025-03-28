// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDynamicConfigRequest : TeaModel {
        /// <summary>
        /// <para>The specific throttling configuration.</para>
        /// <list type="bullet">
        /// <item><description><b>dts.datamove.blaster.qps.max</b>: The rate at which queries are made to the source database per second.</description></item>
        /// <item><description><b>dts.datamove.source.rps.max</b>: The number of rows that are fully synchronized or migrated per second.</description></item>
        /// <item><description><b>dts.datamove.source.bps.max</b>: the amount of data processed per second for full synchronization or migration. Unit: MB.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set the <b>JobCode</b> parameter to <b>03</b>, you need to specify <b>true</b> for the <b>EnableLimit</b> parameter. Otherwise, the configuration cannot take effect.</para>
        /// </description></item>
        /// <item><description><para>If you set the <b>JobCode</b> parameter to <b>04</b> or <b>07</b>, you only need to specify the <b>dts.datamove.source.rps.max</b> and <b>dts.datamove.source.bps.max</b> parameters.</para>
        /// </description></item>
        /// <item><description><para>A value of \<em>\</em>-1\<em>\</em> indicates no rate limit.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;dts.datamove.source.rps.max\&quot;:5000,\&quot;dts.datamove.source.bps.max\&quot;:10485760}</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public string ConfigList { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or synchronization task.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</para>
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
        /// <para>Specifies whether to enable throttling for data synchronization or migration. Valid values: <b>true</b> and <b>false</b>.</para>
        /// <remarks>
        /// <para> Only needs to be configured when the <b>JobCode</b> parameter is set to <b>03</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLimit")]
        [Validation(Required=false)]
        public bool? EnableLimit { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>03</b>: a full data synchronization or full data migration task.</description></item>
        /// <item><description><b>04</b>: an incremental data migration task.</description></item>
        /// <item><description><b>07</b>: an incremental data synchronization task.</description></item>
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
        /// <para>The region ID of the DTS instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz6zsi7ce5rpy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
