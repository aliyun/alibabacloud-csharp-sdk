// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateUniRestorePlanRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qtc</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The unique identifier of the database backup client on the destination server for restoration.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeUniBackupDatabase~~">DescribeUniBackupDatabase</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ac457b30598d11ed800000163e02****</para>
        /// </summary>
        [NameInMap("InstanceUuid")]
        [Validation(Required=false)]
        public string InstanceUuid { get; set; }

        /// <summary>
        /// <para>The ID of the database anti-ransomware backup policy.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeUniBackupPolicies~~">DescribeUniBackupPolicies</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The <b>reset_scn</b> value of the selected record from the recoverable points in time when you query backups for an Oracle database.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeUniRecoverableList~~">DescribeUniRecoverableList</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>925702.0</para>
        /// </summary>
        [NameInMap("ResetScn")]
        [Validation(Required=false)]
        public string ResetScn { get; set; }

        /// <summary>
        /// <para>The <b>reset_time</b> value of the selected record from the recoverable points in time when you query backups for an Oracle database.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeUniRecoverableList~~">DescribeUniRecoverableList</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-29 01:06:24</para>
        /// </summary>
        [NameInMap("ResetTime")]
        [Validation(Required=false)]
        public string ResetTime { get; set; }

        /// <summary>
        /// <para>The database restoration information when the database type is MSSQL. The value is a JSON string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of the database.</description></item>
        /// <item><description><b>files</b>: the file path of the database.<remarks>
        /// <para>Call the <a href="~~DescribeUniRecoverableList~~">DescribeUniRecoverableList</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;files&quot;: {&quot;qtc&quot;:&quot;F:\\database\\qtc.mdf&quot;,&quot;qtc_log&quot;:&quot;F:\\database\\qtc_0.ldf&quot;},
        /// &quot;name&quot;:&quot;qtc&quot;}</para>
        /// </summary>
        [NameInMap("RestoreInfo")]
        [Validation(Required=false)]
        public string RestoreInfo { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore the database.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeRestorePlans~~">DescribeRestorePlans</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656957664000</para>
        /// </summary>
        [NameInMap("TimePoint")]
        [Validation(Required=false)]
        public long? TimePoint { get; set; }

    }

}
