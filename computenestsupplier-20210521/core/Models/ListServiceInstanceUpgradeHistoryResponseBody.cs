// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstanceUpgradeHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of items to return per page when paginating results. The maximum is 100, and the default is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to use for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAc3HCuYhJi/wvpk4xOr0VLbAx7BkQzyYC+ONO+WudHGKEdB0uWSY7AGnM3qCgm/Ynge7zU6NWdbj0Tegyajyqyc=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86CAC31E-3527-562C-869F-347E931C9B25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of upgrade history</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>List of upgrade histories.</para>
        /// </summary>
        [NameInMap("UpgradeHistory")]
        [Validation(Required=false)]
        public List<ListServiceInstanceUpgradeHistoryResponseBodyUpgradeHistory> UpgradeHistory { get; set; }
        public class ListServiceInstanceUpgradeHistoryResponseBodyUpgradeHistory : TeaModel {
            /// <summary>
            /// <para>End time of the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-26T09:09:51Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Version before the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FromVersion")]
            [Validation(Required=false)]
            public string FromVersion { get; set; }

            /// <summary>
            /// <para>Upgrade result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;PreUpgradeExecutionId\&quot;:\&quot;exec-123\&quot;}</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public string Results { get; set; }

            /// <summary>
            /// <para>Start time of the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-26T08:09:51Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>Upgrade status. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>upgrading: In progress.</para>
            /// </description></item>
            /// <item><description><para>UpgradeSuccessful: Upgrade successful.</para>
            /// </description></item>
            /// <item><description><para>UpgradeFailed: Upgrade failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UpgradeFailed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Version after the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ToVersion")]
            [Validation(Required=false)]
            public string ToVersion { get; set; }

            /// <summary>
            /// <para>Upgrade type.</para>
            /// <list type="bullet">
            /// <item><description>Upgrade</description></item>
            /// <item><description>Rollback</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Upgrade</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Upgrade history ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uh-1b21d65f75e94fa09745</para>
            /// </summary>
            [NameInMap("UpgradeHistoryId")]
            [Validation(Required=false)]
            public string UpgradeHistoryId { get; set; }

        }

    }

}
