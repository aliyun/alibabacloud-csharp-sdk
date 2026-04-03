// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateFunagentInput : TeaModel {
        [NameInMap("adminName")]
        [Validation(Required=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// <para>敏感字段</para>
        /// </summary>
        [NameInMap("adminSecret")]
        [Validation(Required=false)]
        public string AdminSecret { get; set; }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("dbConnections")]
        [Validation(Required=false)]
        public int? DbConnections { get; set; }

        [NameInMap("dbHost")]
        [Validation(Required=false)]
        public string DbHost { get; set; }

        [NameInMap("dbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>敏感字段</para>
        /// </summary>
        [NameInMap("dbPassword")]
        [Validation(Required=false)]
        public string DbPassword { get; set; }

        [NameInMap("dbPort")]
        [Validation(Required=false)]
        public int? DbPort { get; set; }

        [NameInMap("dbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("dbUsername")]
        [Validation(Required=false)]
        public string DbUsername { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
