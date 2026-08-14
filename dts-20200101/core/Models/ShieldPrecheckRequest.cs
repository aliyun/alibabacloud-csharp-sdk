// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ShieldPrecheckRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data migration or synchronization instance. You can call the <b>DescribeMigrationJobs</b> or DescribeSynchronizationJobs operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsi76118o3w92****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The precheck items to skip. Separate multiple items with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CHECK_SAME_OBJ</b>: checks whether objects with the same name exist.</description></item>
        /// <item><description><b>CHECK_SAME_USER</b>: checks whether accounts with different names exist.</description></item>
        /// <item><description><b>CHECK_SRC</b>: checks the source database version.</description></item>
        /// <item><description><b>CHECK_TOPOLOGY</b>: checks the topology version.<remarks>
        /// <para>For the topology versions supported by DTS, see <a href="https://help.aliyun.com/document_detail/124115.html">Topology overview</a>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>CHECK_SERVER_ID</b>: checks the server_id of the source database.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHECK_SAME_OBJ</para>
        /// </summary>
        [NameInMap("PrecheckItems")]
        [Validation(Required=false)]
        public string PrecheckItems { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
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
