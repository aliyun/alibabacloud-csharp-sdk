// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateSQLEvaluateTaskRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of all instances in the target region, including instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-shr4idrgogti89</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the instance on which the target SQL statement is executed. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of the target SQL statement, including the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transfer_for_st</para>
        /// </summary>
        [NameInMap("DstDb")]
        [Validation(Required=false)]
        public string DstDb { get; set; }

        /// <summary>
        /// <para>The password of the target SQL statement. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of the target SQL statement, including the password.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DstPassword")]
        [Validation(Required=false)]
        public string DstPassword { get; set; }

        /// <summary>
        /// <para>The ID of the target SQL statement. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of the target SQL statement, including the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-zkrc1****l54rc</para>
        /// </summary>
        [NameInMap("DstResId")]
        [Validation(Required=false)]
        public string DstResId { get; set; }

        /// <summary>
        /// <para>The username of the destination instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds_test</para>
        /// </summary>
        [NameInMap("DstUserName")]
        [Validation(Required=false)]
        public string DstUserName { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196841.html">DescribeRegions</a> operation to query the regions supported by PolarDB-X, including region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The description of the target SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-drds-&gt;auto</para>
        /// </summary>
        [NameInMap("SlinkTaskDesc")]
        [Validation(Required=false)]
        public string SlinkTaskDesc { get; set; }

        /// <summary>
        /// <para>The task ID for executing the target SQL statement. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeCloudCenterInstances</a> operation to query the IDs of target SQL statements supported by PolarDB-X.</para>
        /// 
        /// <b>Example:</b>
        /// <para>etx-szr2rr6i*****</para>
        /// </summary>
        [NameInMap("SlinkTaskId")]
        [Validation(Required=false)]
        public string SlinkTaskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the source ApsaraDB RDS instance. Valid values: *<b>enable</b>: enabled. *<b>disabled</b>: disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transfer_test3</para>
        /// </summary>
        [NameInMap("SrcDb")]
        [Validation(Required=false)]
        public string SrcDb { get; set; }

        /// <summary>
        /// <para>The port number of the source instance. Valid values: 3200 to 3999. &gt; This parameter is available and required only when <b>DBEndpointInstanceType</b> is set to <b>polardb-o</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcPassword")]
        [Validation(Required=false)]
        public string SrcPassword { get; set; }

        /// <summary>
        /// <para>The ID of the source ApsaraDB RDS instance. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196836.html">DescribeDropSystemEventMetaList</a> operation to query the details of all source ApsaraDB RDS instances in the target region, including instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-shr****rgkh87z</para>
        /// </summary>
        [NameInMap("SrcResId")]
        [Validation(Required=false)]
        public string SrcResId { get; set; }

        /// <summary>
        /// <para>The type of the source instance. Valid values: RDS_MYSQL, POLARX1, POLARX2_STANDARD, POLARX2_ENTERPRISE, and POLARDB_M.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POLARX2</para>
        /// </summary>
        [NameInMap("SrcResType")]
        [Validation(Required=false)]
        public string SrcResType { get; set; }

        /// <summary>
        /// <para>The username of the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds_test</para>
        /// </summary>
        [NameInMap("SrcUserName")]
        [Validation(Required=false)]
        public string SrcUserName { get; set; }

    }

}
