// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyEngineMigrationRequest : TeaModel {
        /// <summary>
        /// <para>The specific endpoints to switch. Set this parameter to a JSON string that contains the pairs of endpoints to swap.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when SwapConnectionString is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;pc-bp1m9tt23o5kh834y.rwlb.rds.aliyuncs.com\&quot;:\&quot;rm-bp1ycl5o6ojs957o0.mysql.rds.aliyuncs.com\&quot;}</para>
        /// </summary>
        [NameInMap("ConnectionStrings")]
        [Validation(Required=false)]
        public string ConnectionStrings { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-htri0****r4k9p</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The name of the new primary instance after the migration is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newmaster789</para>
        /// </summary>
        [NameInMap("NewMasterDBInstanceName")]
        [Validation(Required=false)]
        public string NewMasterDBInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the source database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source456</para>
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically swap connection strings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The application does not need to modify its configuration. Connections are automatically directed to the new instance.</para>
        /// </description></item>
        /// <item><description><para>false: You must manually update the application endpoint.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SwapConnectionString")]
        [Validation(Required=false)]
        public string SwapConnectionString { get; set; }

    }

}
