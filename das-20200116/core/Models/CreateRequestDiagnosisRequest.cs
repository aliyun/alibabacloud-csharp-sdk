// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateRequestDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>das</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-0iwhhl8gx0ld6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para> This parameter must be specified for PolarDB for MySQL, PolarDB for PostgreSQL (Compatible with Oracle), and ApsaraDB for MongoDB instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>202****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The SQL statement that you want to diagnose.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from test where name = \&quot;mockUser\&quot;</para>
        /// </summary>
        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
