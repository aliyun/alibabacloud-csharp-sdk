// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class EngineVersionMetadata : TeaModel {
        /// <summary>
        /// <para>The engine version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vvr-6.0.0-flink-1.15</para>
        /// </summary>
        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The features supported by the engine version.</para>
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public EngineVersionSupportedFeatures Features { get; set; }

        /// <summary>
        /// <para>The status of the engine version.</para>
        /// <list type="bullet">
        /// <item><description>STABLE</description></item>
        /// <item><description>BETA</description></item>
        /// <item><description>DEPRECATED</description></item>
        /// <item><description>EXPIRED</description></item>
        /// </list>
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
