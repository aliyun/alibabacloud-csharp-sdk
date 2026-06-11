// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiStatisticsConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to record the body of incoming requests.</para>
        /// </summary>
        [NameInMap("logRequestContent")]
        [Validation(Required=false)]
        public bool? LogRequestContent { get; set; }

        /// <summary>
        /// <para>Specifies whether to record the body of outgoing responses.</para>
        /// </summary>
        [NameInMap("logResponseContent")]
        [Validation(Required=false)]
        public bool? LogResponseContent { get; set; }

        /// <summary>
        /// <para>An array of configurations for extracting data from specific paths.</para>
        /// </summary>
        [NameInMap("pathFieldConfigs")]
        [Validation(Required=false)]
        public List<AiStatisticsConfigPathFieldConfigs> PathFieldConfigs { get; set; }
        public class AiStatisticsConfigPathFieldConfigs : TeaModel {
            /// <summary>
            /// <para>A key-value map for extracting fields. Keys are custom names, and values are paths to the data within the request or response body.</para>
            /// </summary>
            [NameInMap("fieldPaths")]
            [Validation(Required=false)]
            public Dictionary<string, AiStatisticsPathField> FieldPaths { get; set; }

            /// <summary>
            /// <para>The API endpoint path to which this configuration applies, such as /user/id.</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

    }

}
