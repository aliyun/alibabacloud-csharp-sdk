// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class CdcYamlArtifact : TeaModel {
        /// <summary>
        /// <para>Full URL paths to the additional dependencies.</para>
        /// </summary>
        [NameInMap("additionalDependencies")]
        [Validation(Required=false)]
        public List<string> AdditionalDependencies { get; set; }

        /// <summary>
        /// <para>Code for the data ingestion job.</para>
        /// </summary>
        [NameInMap("cdcYaml")]
        [Validation(Required=false)]
        public string CdcYaml { get; set; }

    }

}
