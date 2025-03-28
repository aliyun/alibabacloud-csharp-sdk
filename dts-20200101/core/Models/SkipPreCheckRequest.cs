// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SkipPreCheckRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c7412z57g8k****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The precheck task ID. You can call the <b>DescribePreCheckStatus</b> operation to query the task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b4my3zg929a****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the precheck item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public bool? Skip { get; set; }

        /// <summary>
        /// <para>The shortened name of the precheck item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>[&quot;CHECK_SAME_OBJ&quot;]</b>: object name conflict.</description></item>
        /// <item><description><b>[&quot;CHECK_SAME_USER&quot;]</b>: username conflict.</description></item>
        /// <item><description><b>[&quot;CHECK_SRC&quot;]</b>: source database version.</description></item>
        /// <item><description><b>[&quot;CHECK_TOPOLOGY&quot;]</b>: topology. For more information about the topologies supported by Data Transmission Service (DTS), see <a href="https://help.aliyun.com/document_detail/124115.html">Synchronization topologies</a>.</description></item>
        /// <item><description><b>[&quot;CHECK_SERVER_ID&quot;]</b>: the server ID of the source database.</description></item>
        /// <item><description><b>[&quot;CHECK_DEST_TABLE_EMPTY&quot;]</b>: existence of objects in the destination database.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Separate multiple item names with commas (,). Example: <b>[&quot;CHECK_SRC&quot;,&quot;CHECK_SAME_OBJ&quot;]</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;CHECK_SAME_OBJ&quot;]</para>
        /// </summary>
        [NameInMap("SkipPreCheckItems")]
        [Validation(Required=false)]
        public string SkipPreCheckItems { get; set; }

        /// <summary>
        /// <para>The precheck item name. This parameter corresponds to <b>SkipPreCheckItems</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>[&quot;CHECK_SAME_OBJ_DETAIL&quot;]</b>: object name conflict.</description></item>
        /// <item><description><b>[&quot;CHECK_SAME_USER_DETAIL&quot;]</b>: username conflict.</description></item>
        /// <item><description><b>[&quot;CHECK_SRC_DETAIL&quot;]</b>: source database version.</description></item>
        /// <item><description><b>[&quot;CHECK_TOPOLOGY_DETAIL&quot;]</b>: topology. For more information about the topologies supported by DTS, see <a href="https://help.aliyun.com/document_detail/124115.html">Synchronization topologies</a>.</description></item>
        /// <item><description><b>[&quot;CHECK_SERVER_ID_DETAIL&quot;]</b>: the server ID of the source database.</description></item>
        /// <item><description><b>[&quot;CHECK_DEST_TABLE_EMPTY_DETAIL&quot;]</b>: empty tables in the destination database.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Separate multiple item names with commas (,). Example: <b>[&quot;CHECK_SRC_DETAIL&quot;,&quot;CHECK_SAME_OBJ_DETAIL&quot;]</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;CHECK_SAME_OBJ_DETAIL&quot;]</para>
        /// </summary>
        [NameInMap("SkipPreCheckNames")]
        [Validation(Required=false)]
        public string SkipPreCheckNames { get; set; }

    }

}
