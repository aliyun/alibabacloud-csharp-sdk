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
        /// <para>The ID of the precheck task. You can call <b>DescribePreCheckStatus</b> to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b4my3zg929a****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

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
        /// <para>Specifies whether to suppress the precheck item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Suppress the precheck item.</description></item>
        /// <item><description><b>false</b>: Unsuppress the precheck item.</description></item>
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
        /// <para>The abbreviated names of the precheck items to suppress or unsuppress. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>[&quot;CHECK_SAME_OBJ&quot;]</b>: check for objects with the same name.</description></item>
        /// <item><description><b>[&quot;CHECK_SAME_USER&quot;]</b>: check for accounts with different names.</description></item>
        /// <item><description><b>[&quot;CHECK_SRC&quot;]</b>: source database version check.</description></item>
        /// <item><description><b>[&quot;CHECK_TOPOLOGY&quot;]</b>: topology version check. For the topology versions supported by DTS, see <a href="https://help.aliyun.com/document_detail/124115.html">Topology overview</a>.</description></item>
        /// <item><description><b>[&quot;CHECK_SERVER_ID&quot;]</b>: source database server_id check.</description></item>
        /// <item><description><b>[&quot;CHECK_DEST_TABLE_EMPTY&quot;]</b>: destination database object existence check.</description></item>
        /// <item><description><b>[&quot;CHECK_SUPER_AUTH_DEST&quot;]</b>: destination database super account permission check.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Separate multiple item names with commas (,), for example, <b>[&quot;CHECK_SRC&quot;,&quot;CHECK_SAME_OBJ&quot;]</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;CHECK_SAME_OBJ&quot;]</para>
        /// </summary>
        [NameInMap("SkipPreCheckItems")]
        [Validation(Required=false)]
        public string SkipPreCheckItems { get; set; }

        /// <summary>
        /// <para>The full names of the precheck items to suppress or unsuppress. This parameter corresponds to the <b>SkipPreCheckItems</b> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>[&quot;CHECK_SAME_OBJ_DETAIL&quot;]</b>: check for objects with the same name.</description></item>
        /// <item><description><b>[&quot;CHECK_SAME_USER_DETAIL&quot;]</b>: check for accounts with different names.</description></item>
        /// <item><description><b>[&quot;CHECK_SRC_DETAIL&quot;]</b>: source database version check.</description></item>
        /// <item><description><b>[&quot;CHECK_TOPOLOGY_DETAIL&quot;]</b>: topology version check. For the topology versions supported by DTS, see <a href="https://help.aliyun.com/document_detail/124115.html">Topology overview</a>.</description></item>
        /// <item><description><b>[&quot;CHECK_SERVER_ID_DETAIL&quot;]</b>: source database server_id check.</description></item>
        /// <item><description><b>[&quot;CHECK_DEST_TABLE_EMPTY_DETAIL&quot;]</b>: check whether the destination database tables are empty.</description></item>
        /// <item><description><b>[&quot;CHECK_SUPER_AUTH_DEST_DETAIL&quot;]</b>: check the super account permissions of the destination database.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Separate multiple item names with commas (,), for example, <b>[&quot;CHECK_SRC_DETAIL&quot;,&quot;CHECK_SAME_OBJ_DETAIL&quot;]</b>.</para>
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
