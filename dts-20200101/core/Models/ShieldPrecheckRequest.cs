// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ShieldPrecheckRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data migration or data synchronization instance. You can call the <b>DescribeMigrationJobs</b> or DescribeSynchronizationJobs operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsi76118o3w92****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The precheck items that you want to ignore. Separate multiple items with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CHECK_SAME_OBJ</b>: schema name conflict</para>
        /// </description></item>
        /// <item><description><para><b>CHECK_SAME_USER</b>: multiple usernames for one instance</para>
        /// </description></item>
        /// <item><description><para><b>CHECK_SRC</b>: source database version</para>
        /// </description></item>
        /// <item><description><para><b>CHECK_TOPOLOGY</b>: topology</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the topologies supported by DTS, see <a href="https://help.aliyun.com/document_detail/124115.html">Synchronization topologies</a>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>CHECK_SERVER_ID</b>: value of server_id in the source database</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHECK_SAME_OBJ</para>
        /// </summary>
        [NameInMap("PrecheckItems")]
        [Validation(Required=false)]
        public string PrecheckItems { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
