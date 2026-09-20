// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CreateRestorePlanRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraDB for HBase Performance-enhanced Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp150tns0sjxs****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore all tables. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Restores all tables in the ApsaraDB for HBase Performance-enhanced Edition cluster.</description></item>
        /// <item><description><b>false</b>: Does not restore all tables in the ApsaraDB for HBase Performance-enhanced Edition cluster.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to <b>true</b>, the <b>Tables</b> parameter is invalid. If this parameter is set to <b>false</b>, the <b>Tables</b> parameter is required.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RestoreAllTable")]
        [Validation(Required=false)]
        public bool? RestoreAllTable { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore data by using the copy method. Set the value to <b>true</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RestoreByCopy")]
        [Validation(Required=false)]
        public bool? RestoreByCopy { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore data. The point in time must be within the recoverable time range. You can call the <a href="https://help.aliyun.com/document_detail/188365.html">DescribeRecoverableTimeRange</a> operation to query the recoverable time range.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-05T05:49:42Z</para>
        /// </summary>
        [NameInMap("RestoreToDate")]
        [Validation(Required=false)]
        public string RestoreToDate { get; set; }

        /// <summary>
        /// <para>The table names. Specify one table name per line. Wildcards (*) are not supported.</para>
        /// <list type="bullet">
        /// <item><description>To restore to the current table, use the format: <c>namespace:table</c>. Example: <c>default:testTable</c>.</description></item>
        /// <item><description>To restore to a different table, use the format: <c>namespace:table/namespace:table2</c>. Example: <c>default:testTable/default:testTable2</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test_ns:test_table/test_ns:test_table2</para>
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public string Tables { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraDB for HBase Performance-enhanced Edition cluster to which data is restored. You can also restore data to the cluster that is currently backed up.</para>
        /// <remarks>
        /// <para>The specified ApsaraDB for HBase Performance-enhanced Edition cluster and the backed-up ApsaraDB for HBase Performance-enhanced Edition cluster must meet the following requirements:<list type="bullet"></para>
        /// </remarks>
        /// <item><description>They are of the same version.</description></item>
        /// <item><description>They are in the same region.</description></item>
        /// <item><description>They are associated with the BDS cluster.</description></item></list>.
        /// 
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp169l540vc6c****</para>
        /// </summary>
        [NameInMap("TargetClusterId")]
        [Validation(Required=false)]
        public string TargetClusterId { get; set; }

    }

}
