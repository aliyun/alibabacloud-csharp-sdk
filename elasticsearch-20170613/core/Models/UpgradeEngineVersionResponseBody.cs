// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpgradeEngineVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The verification information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DC*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the error. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>clusterStatus: the health status of the cluster.</description></item>
        /// <item><description>clusterConfigYml: Cluster YML File</description></item>
        /// <item><description>clusterConfigPlugins: Cluster Configuration File</description></item>
        /// <item><description>clusterResource: cluster resources</description></item>
        /// <item><description>clusterSnapshot: cluster snapshot</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<UpgradeEngineVersionResponseBodyResult> Result { get; set; }
        public class UpgradeEngineVersionResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// </summary>
            [NameInMap("validateResult")]
            [Validation(Required=false)]
            public List<UpgradeEngineVersionResponseBodyResultValidateResult> ValidateResult { get; set; }
            public class UpgradeEngineVersionResponseBodyResultValidateResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ClusterStatusNotHealth</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>The cluster status is not health</para>
                /// </summary>
                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The verification is passed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>success: through</description></item>
                /// <item><description>failed: failed</description></item>
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
            /// <para>The error code returned if the request failed.</para>
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
