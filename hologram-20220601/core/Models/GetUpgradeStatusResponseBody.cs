// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetUpgradeStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetUpgradeStatusResponseBodyData> Data { get; set; }
        public class GetUpgradeStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Details about the upgrade process, formatted as a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;UpgradePhase&quot;:&quot;Upgrade&quot;,&quot;StatusCode&quot;:&quot;LeaderRestartFailed&quot;,&quot;FlightingReport&quot;:{&quot;SQLResultStat&quot;:{&quot;TotalExecuted&quot;:9000&quot;Exceptions&quot;:0,&quot;Incorrect&quot;:1,&quot;Slow&quot;:1,&quot;DQLSpeedup&quot;:2}&quot;SegmentFormatStat&quot;:[{&quot;Database&quot;:&quot;test_db&quot;,&quot;TableUsingSegmentCount&quot;:5},{&quot;Database&quot;:&quot;user_order&quot;,&quot;TableUsingSegmentCount&quot;:7}],&quot;EstimatedUpgradeTime&quot;:{&quot;StopInstance&quot;:30,&quot;BackupData&quot;:120,&quot;UpgradeInstance&quot;:600},&quot;ReadPermissionCheckStat&quot;:[{&quot;db&quot;:&quot;tst0&quot;,&quot;user&quot;:&quot;v4_300433463265624129&quot;,&quot;schema&quot;:&quot;dim_db&quot;,&quot;table&quot;:&quot;it_rpt_org_tree_info_partition_all&quot;},{&quot;db&quot;:&quot;tst1&quot;,&quot;user&quot;:&quot;v4_300433463265624129&quot;,&quot;schema&quot;:&quot;dim_db&quot;,&quot;table&quot;:&quot;it_rpt_org_tree_info_partition_all_2&quot;},]},&quot;UpgradingSteps&quot;:{&quot;Stop&quot;:{&quot;Status&quot;:&quot;Success&quot;,&quot;StartTime&quot;:&quot;2023-05-09T06:48:28.843Z&quot;,&quot;StopTime&quot;:&quot;2023-05-09T06:48:28.843Z&quot;},&quot;Backup&quot;:{&quot;Status&quot;:&quot;Success&quot;,&quot;StartTime&quot;:&quot;2023-05-09T06:48:28.843Z&quot;,&quot;StopTime&quot;:&quot;2023-05-09T06:48:28.843Z&quot;},&quot;DoUpgrade&quot;:{&quot;Status&quot;:&quot;Success&quot;,&quot;StartTime&quot;:&quot;2023-05-09T06:48:28.843Z&quot;,&quot;StopTime&quot;:&quot;2023-05-09T06:48:28.843Z&quot;},&quot;Rollback&quot;:{&quot;Status&quot;:&quot;Success&quot;,&quot;StartTime&quot;:&quot;2023-05-09T06:48:28.843Z&quot;,&quot;StopTime&quot;:&quot;2023-05-09T06:48:28.843Z&quot;}},&quot;Instances&quot;:{&quot;LeaderInstanceId&quot;:&quot;hgxxx&quot;,&quot;LeaderInstanceName&quot;:&quot;ERP instance&quot;,&quot;LeaderInstanceStatus&quot;:&quot;Running&quot;,&quot;FollowerInstances&quot;:[{&quot;InstanceId&quot;:&quot;hgxxx&quot;,&quot;InstanceName&quot;:&quot;TMSinstance&quot;,&quot;Status&quot;:&quot;Running&quot;},{&quot;InstanceId&quot;:&quot;hxxx&quot;&quot;InstanceName&quot;:&quot;WMS readonly&quot;,&quot;Status&quot;:&quot;Unavailable&quot;}]}}</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public string Details { get; set; }

            /// <summary>
            /// <para>The version of the instance before the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.3.23</para>
            /// </summary>
            [NameInMap("FromVersion")]
            [Validation(Required=false)]
            public string FromVersion { get; set; }

            /// <summary>
            /// <para>The completion time of the preparation phase, in ISO 8601 format: <c>YYYY-MM-DDThh:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-09T06:48:28.843Z</para>
            /// </summary>
            [NameInMap("PrepareFinishTime")]
            [Validation(Required=false)]
            public string PrepareFinishTime { get; set; }

            /// <summary>
            /// <para>The status of the Airflow directed acyclic graph (DAG) used for the instance upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>archived</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The target version of the upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.3.24</para>
            /// </summary>
            [NameInMap("ToVersion")]
            [Validation(Required=false)]
            public string ToVersion { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the API call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>404</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the API call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal server error.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D73E42D0-AA72-5880-B96F-548B43C84736</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. This parameter does not reflect the status of the upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
