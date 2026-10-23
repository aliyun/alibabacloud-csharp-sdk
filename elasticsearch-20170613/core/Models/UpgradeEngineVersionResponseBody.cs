// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpgradeEngineVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DC*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<UpgradeEngineVersionResponseBodyResult> Result { get; set; }
        public class UpgradeEngineVersionResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Specifies whether the check is passed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: Passed.</description></item>
            /// <item><description>failed: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The check information.</para>
            /// </summary>
            [NameInMap("validateResult")]
            [Validation(Required=false)]
            public List<UpgradeEngineVersionResponseBodyResultValidateResult> ValidateResult { get; set; }
            public class UpgradeEngineVersionResponseBodyResultValidateResult : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ClusterStatusNotHealth</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The cluster status is not health</para>
                /// </summary>
                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The error type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>clusterStatus: Cluster health status.</description></item>
                /// <item><description>clusterConfigYml: Cluster YML file.</description></item>
                /// <item><description>clusterConfigPlugins: Cluster configuration file.</description></item>
                /// <item><description>clusterResource: Cluster resources.</description></item>
                /// <item><description>clusterSnapshot: Cluster snapshot.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>clusterStatus</para>
                /// </summary>
                [NameInMap("errorType")]
                [Validation(Required=false)]
                public string ErrorType { get; set; }

            }

            /// <summary>
            /// <para>The check type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>checkClusterHealth: Cluster health status.</description></item>
            /// <item><description>checkConfigCompatible: Configuration compatibility status.</description></item>
            /// <item><description>checkClusterResource: Resource space status.</description></item>
            /// <item><description>checkClusterSnapshot: Snapshot existence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>checkClusterHealth</para>
            /// </summary>
            [NameInMap("validateType")]
            [Validation(Required=false)]
            public string ValidateType { get; set; }

        }

    }

}
