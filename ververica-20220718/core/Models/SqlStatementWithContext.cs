// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlStatementWithContext : TeaModel {
        [NameInMap("additionalDependencies")]
        [Validation(Required=false)]
        public List<string> AdditionalDependencies { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("batchMode")]
        [Validation(Required=false)]
        public bool? BatchMode { get; set; }

        [NameInMap("flinkConfiguration")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlinkConfiguration { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("statement")]
        [Validation(Required=false)]
        public string Statement { get; set; }

        [NameInMap("versionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
