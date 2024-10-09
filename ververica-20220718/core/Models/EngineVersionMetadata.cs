// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class EngineVersionMetadata : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vvr-6.0.0-flink-1.15</para>
        /// </summary>
        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("features")]
        [Validation(Required=false)]
        public EngineVersionSupportedFeatures Features { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STABLE</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
