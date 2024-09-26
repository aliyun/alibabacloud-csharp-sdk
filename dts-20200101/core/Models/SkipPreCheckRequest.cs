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
        /// <para>The ID of the precheck task. You can call the <b>DescribePreCheckStatus</b> operation to query the task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b4my3zg929a****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

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

        /// <summary>
        /// <para>Specifies whether to skip the precheck item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: skips the precheck item.</description></item>
        /// <item><description><b>false</b>: does not skip the precheck item.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required.</para>
        /// </remarks>
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
        /// <item><description><para><b>CHECK_SAME_OBJ</b>: object name conflict</para>
        /// </description></item>
        /// <item><description><para><b>CHECK_SAME_USER</b>: multiple usernames for one instance</para>
        /// </description></item>
        /// <item><description><para><b>CHECK_SRC</b>: source database version</para>
        /// </description></item>
        /// <item><description><para><b>CHECK_TOPOLOGY</b>: topology type</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the topologies supported by DTS, see <a href="https://help.aliyun.com/document_detail/124115.html">Synchronization topologies</a>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>CHECK_SERVER_ID</b>: the server ID of the source database</description></item>
        /// </list>
        /// <remarks>
        /// <para> Separate multiple shortened names with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CHECK_SAME_OBJ</para>
        /// </summary>
        [NameInMap("SkipPreCheckItems")]
        [Validation(Required=false)]
        public string SkipPreCheckItems { get; set; }

        /// <summary>
        /// <para>The name of the precheck item. This parameter corresponds to the <b>SkipPreCheckItems</b> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CHECK_SAME_OBJ_DETAIL</b>: object name conflict</para>
        /// </description></item>
        /// <item><description><para><b>CHECK_SAME_USER_DETAIL</b>: multiple usernames for one instance</para>
        /// </description></item>
        /// <item><description><para><b>CHECK_SRC_DETAIL</b>: source database version</para>
        /// </description></item>
        /// <item><description><para><b>CHECK_TOPOLOGY_DETAIL</b>: topology type</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the topologies supported by DTS, see <a href="https://help.aliyun.com/document_detail/124115.html">Synchronization topologies</a>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>CHECK_SERVER_ID_DETAIL</b>: the server ID of the source database</description></item>
        /// </list>
        /// <remarks>
        /// <para> Separate multiple item names with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CHECK_SAME_OBJ_DETAIL</para>
        /// </summary>
        [NameInMap("SkipPreCheckNames")]
        [Validation(Required=false)]
        public string SkipPreCheckNames { get; set; }

    }

}
