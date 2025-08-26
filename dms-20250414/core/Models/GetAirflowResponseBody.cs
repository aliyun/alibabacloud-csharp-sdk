// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetAirflowResponseBody : TeaModel {
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
        /// <para>Unknown error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Reuqest ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-CD3E-4D98-8264-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Root")]
        [Validation(Required=false)]
        public GetAirflowResponseBodyRoot Root { get; set; }
        public class GetAirflowResponseBodyRoot : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>af-7a6ygsh80dx1jn****</para>
            /// </summary>
            [NameInMap("AirflowId")]
            [Validation(Required=false)]
            public string AirflowId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testairflow</para>
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
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("DeployErrorMsg")]
            [Validation(Required=false)]
            public string DeployErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test airflow</para>
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
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default/requirements.txt</para>
            /// </summary>
            [NameInMap("RequirementFile")]
            [Validation(Required=false)]
            public string RequirementFile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-2ze9gj646bkv****</para>
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
            /// <para>vsw-bp1931trfxkvf74v****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zevqv4obraqd5p****</para>
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
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
