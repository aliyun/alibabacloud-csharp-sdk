// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListAirflowsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NOT_FOUND</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NesLoKLEdIZrKhDT7I2gS****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Reuqest ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Root")]
        [Validation(Required=false)]
        public ListAirflowsResponseBodyRoot Root { get; set; }
        public class ListAirflowsResponseBodyRoot : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListAirflowsResponseBodyRootList> List { get; set; }
            public class ListAirflowsResponseBodyRootList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>af-7a6ygsh80d****</para>
                /// </summary>
                [NameInMap("AirflowId")]
                [Validation(Required=false)]
                public string AirflowId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-airflow</para>
                /// </summary>
                [NameInMap("AirflowName")]
                [Validation(Required=false)]
                public string AirflowName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SMALL</para>
                /// </summary>
                [NameInMap("AppSpec")]
                [Validation(Required=false)]
                public string AppSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AIRFLOW</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                [NameInMap("CustomAirflowCfg")]
                [Validation(Required=false)]
                public List<string> CustomAirflowCfg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default/dags</para>
                /// </summary>
                [NameInMap("DagsDir")]
                [Validation(Required=false)]
                public string DagsDir { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>quota exists</para>
                /// </summary>
                [NameInMap("DeployErrorMsg")]
                [Validation(Required=false)]
                public string DeployErrorMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-08-12T05:46:01.000+0000</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>osstest</para>
                /// </summary>
                [NameInMap("OssBucketName")]
                [Validation(Required=false)]
                public string OssBucketName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/airflow</para>
                /// </summary>
                [NameInMap("OssPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default/plugins</para>
                /// </summary>
                [NameInMap("PluginsDir")]
                [Validation(Required=false)]
                public string PluginsDir { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default/requirements.txt</para>
                /// </summary>
                [NameInMap("RequirementFile")]
                [Validation(Required=false)]
                public string RequirementFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sg-2ze1nak7h0alg1w****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default/startup.sh</para>
                /// </summary>
                [NameInMap("StartupFile")]
                [Validation(Required=false)]
                public string StartupFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEPLOYED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-uf6sxdc22x7sbdb****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>VPC ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbbfm33dy0y1pek****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WorkerServerlessReplicas")]
                [Validation(Required=false)]
                public int? WorkerServerlessReplicas { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8630242382****</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
