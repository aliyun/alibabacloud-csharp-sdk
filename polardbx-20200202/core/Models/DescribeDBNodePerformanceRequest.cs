// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBNodePerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The node type. Valid values: polarx_cn, polarx_dn, polarx_cdc, polarx_gms, and polarx_columnar.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polarx_cn</para>
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// <para>The name of the PolarDB-X instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-*******</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The node names. Separate multiple node names with commas (,). You can specify up to 10 CDC nodes and compute nodes, or up to 1 data node at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-i-<b><b><b>,pxc-i-</b></b></b>*</para>
        /// </summary>
        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public string DBNodeIds { get; set; }

        /// <summary>
        /// <para>The node role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>master: primary node.</description></item>
        /// <item><description>slave: secondary node. This value applies to DN and GMS nodes.</description></item>
        /// <item><description>standby: secondary node. This value applies to CN nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("DBNodeRole")]
        [Validation(Required=false)]
        public string DBNodeRole { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the YYYY-MM-ddTHH:mmZ format (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2012-06-18T15:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The metric names. Separate multiple metric names with commas (,). You can specify up to 6 metrics. For more information, see <a href="https://help.aliyun.com/document_detail/332726.html">Performance metrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cpu_Usage,Mem_Usage</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the YYYY-MM-ddTHH:mmZ format (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2012-06-08T15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
