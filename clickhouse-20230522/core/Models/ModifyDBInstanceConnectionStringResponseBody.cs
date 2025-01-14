// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyDBInstanceConnectionStringResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyDBInstanceConnectionStringResponseBodyData Data { get; set; }
        public class ModifyDBInstanceConnectionStringResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The endpoint of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-2ze34****-clickhouse..clickhouseserver.pre.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-xxxxx</para>
            /// </summary>
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-xxxxx</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("DisabledPorts")]
            [Validation(Required=false)]
            public string DisabledPorts { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
