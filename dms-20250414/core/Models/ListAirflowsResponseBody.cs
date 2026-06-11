// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListAirflowsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NOT_FOUND</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The error code. This parameter is returned when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NesLoKLEdIZrKhDT7I2gS****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the data.</para>
        /// </summary>
        [NameInMap("Root")]
        [Validation(Required=false)]
        public ListAirflowsResponseBodyRoot Root { get; set; }
        public class ListAirflowsResponseBodyRoot : TeaModel {
            /// <summary>
            /// <para>The list of data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListAirflowsResponseBodyRootList> List { get; set; }
            public class ListAirflowsResponseBodyRootList : TeaModel {
                /// <summary>
                /// <para>The ID of the Airflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>af-7a6ygsh80d****</para>
                /// </summary>
                [NameInMap("AirflowId")]
                [Validation(Required=false)]
                public string AirflowId { get; set; }

                /// <summary>
                /// <para>The name of the Airflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-airflow</para>
                /// </summary>
                [NameInMap("AirflowName")]
                [Validation(Required=false)]
                public string AirflowName { get; set; }

                /// <summary>
                /// <para>The specifications of the Airflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SMALL</para>
                /// </summary>
                [NameInMap("AppSpec")]
                [Validation(Required=false)]
                public string AppSpec { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AIRFLOW</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                /// <summary>
                /// <para>The custom configuration.</para>
                /// </summary>
                [NameInMap("CustomAirflowCfg")]
                [Validation(Required=false)]
                public List<string> CustomAirflowCfg { get; set; }

                /// <summary>
                /// <para>The DAGs folder that Airflow scans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default/dags</para>
                /// </summary>
                [NameInMap("DagsDir")]
                [Validation(Required=false)]
                public string DagsDir { get; set; }

                /// <summary>
                /// <para>The error message returned when the deployment fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>quota exists</para>
                /// </summary>
                [NameInMap("DeployErrorMsg")]
                [Validation(Required=false)]
                public string DeployErrorMsg { get; set; }

                /// <summary>
                /// <para>The description of the Airflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the Airflow instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-08-12T05:46:01.000+0000</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The name of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>osstest</para>
                /// </summary>
                [NameInMap("OssBucketName")]
                [Validation(Required=false)]
                public string OssBucketName { get; set; }

                /// <summary>
                /// <para>The path in OSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/airflow</para>
                /// </summary>
                [NameInMap("OssPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                /// <summary>
                /// <para>The plugins folder that Airflow scans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default/plugins</para>
                /// </summary>
                [NameInMap("PluginsDir")]
                [Validation(Required=false)]
                public string PluginsDir { get; set; }

                /// <summary>
                /// <para>The path to the file that contains the dependencies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default/requirements.txt</para>
                /// </summary>
                [NameInMap("RequirementFile")]
                [Validation(Required=false)]
                public string RequirementFile { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-2ze1nak7h0alg1w****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The path to the script that is loaded when Airflow starts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default/startup.sh</para>
                /// </summary>
                [NameInMap("StartupFile")]
                [Validation(Required=false)]
                public string StartupFile { get; set; }

                /// <summary>
                /// <para>The status of the Airflow instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEPLOYED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf6sxdc22x7sbdb****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbbfm33dy0y1pek****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The number of worker nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WorkerServerlessReplicas")]
                [Validation(Required=false)]
                public int? WorkerServerlessReplicas { get; set; }

                /// <summary>
                /// <para>The ID of the DMS workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8630242382****</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The ID of the zone in the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The total number of matching Airflow instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
