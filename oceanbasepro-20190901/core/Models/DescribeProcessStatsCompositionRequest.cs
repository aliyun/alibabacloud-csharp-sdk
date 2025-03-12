// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProcessStatsCompositionRequest : TeaModel {
        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.<em>.</em>.*</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.<em>.</em>.*</para>
        /// </summary>
        [NameInMap("ServerIp")]
        [Validation(Required=false)]
        public string ServerIp { get; set; }

        /// <summary>
        /// <para>The SQL statement, which can contain LIKE clauses. You can specify only part of the clauses in the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT  ****   FROM ****   WHERE **** = ? AND **** = ?   ORDER BY **** ASC</para>
        /// </summary>
        [NameInMap("SqlText")]
        [Validation(Required=false)]
        public string SqlText { get; set; }

        /// <summary>
        /// <para>The status of the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t33h8y08k****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The user identifier (UID) of the OceanBase database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139*************</para>
        /// </summary>
        [NameInMap("UId")]
        [Validation(Required=false)]
        public string UId { get; set; }

        /// <summary>
        /// <para>The username of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;test_user&quot;]</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public string Users { get; set; }

    }

}
