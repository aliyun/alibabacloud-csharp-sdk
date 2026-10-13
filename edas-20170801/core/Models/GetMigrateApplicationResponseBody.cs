// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetMigrateApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMigrateApplicationResponseBodyData Data { get; set; }
        public class GetMigrateApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The list of results.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<GetMigrateApplicationResponseBodyDataResult> Result { get; set; }
            public class GetMigrateApplicationResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The detailed status of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;a259bc63-c1f4-48ba-89b1-d6a4591e946c\&quot;:{\&quot;app_name\&quot;:\&quot;prodoam1\&quot;,\&quot;cluster_name\&quot;:\&quot;hthoamtest\&quot;,\&quot;cluster_id\&quot;:\&quot;f68945a8-47af-4644-a951-0486d674f26e\&quot;,\&quot;error_msg\&quot;:\&quot;\&quot;,\&quot;is_multilingual_app\&quot;:false,\&quot;state\&quot;:\&quot;success\&quot;,\&quot;clusterId\&quot;:\&quot;f68945a8-47af-4644-a951-0486d674f26e\&quot;,\&quot;app_id\&quot;:\&quot;a259bc63-c1f4-48ba-89b1-d6a4591e946c\&quot;,\&quot;logical_region_id\&quot;:\&quot;cn-hangzhou\&quot;,\&quot;k8sNamespace\&quot;:\&quot;default\&quot;},\&quot;c5a258ac-f02d-4035-b59f-cd7f4a34156a\&quot;:{\&quot;app_name\&quot;:\&quot;testoam1\&quot;,\&quot;cluster_name\&quot;:\&quot;hthoamtest\&quot;,\&quot;cluster_id\&quot;:\&quot;f68945a8-47af-4644-a951-0486d674f26e\&quot;,\&quot;error_msg\&quot;:\&quot;\&quot;,\&quot;is_multilingual_app\&quot;:false,\&quot;state\&quot;:\&quot;success\&quot;,\&quot;clusterId\&quot;:\&quot;f68945a8-47af-4644-a951-0486d674f26e\&quot;,\&quot;app_id\&quot;:\&quot;c5a258ac-f02d-4035-b59f-cd7f4a34156a\&quot;,\&quot;logical_region_id\&quot;:\&quot;cn-hangzhou\&quot;,\&quot;k8sNamespace\&quot;:\&quot;default\&quot;},\&quot;d132c827-db2f-444e-bc9e-9182d8112806\&quot;:{\&quot;app_name\&quot;:\&quot;oam1\&quot;,\&quot;cluster_name\&quot;:\&quot;hthoamtest\&quot;,\&quot;cluster_id\&quot;:\&quot;f68945a8-47af-4644-a951-0486d674f26e\&quot;,\&quot;error_msg\&quot;:\&quot;\&quot;,\&quot;is_multilingual_app\&quot;:false,\&quot;state\&quot;:\&quot;success\&quot;,\&quot;clusterId\&quot;:\&quot;f68945a8-47af-4644-a951-0486d674f26e\&quot;,\&quot;app_id\&quot;:\&quot;d132c827-db2f-444e-bc9e-9182d8112806\&quot;,\&quot;logical_region_id\&quot;:\&quot;cn-hangzhou\&quot;,\&quot;k8sNamespace\&quot;:\&quot;default\&quot;}}&quot;</para>
                /// </summary>
                [NameInMap("appDetailState")]
                [Validation(Required=false)]
                public string AppDetailState { get; set; }

                /// <summary>
                /// <para>Indicates whether binary resources are cleaned up. Valid values: 0: not cleaned up. 1: cleaned up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("binaryCleaned")]
                [Validation(Required=false)]
                public long? BinaryCleaned { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1791512615778</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The additional information.</para>
                /// </summary>
                [NameInMap("extraInfo")]
                [Validation(Required=false)]
                public GetMigrateApplicationResponseBodyDataResultExtraInfo ExtraInfo { get; set; }
                public class GetMigrateApplicationResponseBodyDataResultExtraInfo : TeaModel {
                    /// <summary>
                    /// <para>appJsonFile</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;<a href="https://edas-hz-secure.oss-cn-hangzhou.aliyuncs.com/edas-app-migration/1057288613002791/e7c2e7d9-5e87-46a2-99e9-2be0b577a3fd/edas-app.json?Expires=1791517039&OSSAccessKeyId=LTAIWLbjtAGvdMWX&Signature=HyZ2b3u5mlP56T8QgkARwWE5cQc%3D">https://edas-hz-secure.oss-cn-hangzhou.aliyuncs.com/edas-app-migration/1057288613002791/e7c2e7d9-5e87-46a2-99e9-2be0b577a3fd/edas-app.json?Expires=1791517039&amp;OSSAccessKeyId=LTAIWLbjtAGvdMWX&amp;Signature=HyZ2b3u5mlP56T8QgkARwWE5cQc%3D</a>&quot;</para>
                    /// </summary>
                    [NameInMap("appJsonFile")]
                    [Validation(Required=false)]
                    public string AppJsonFile { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>“”</para>
                    /// </summary>
                    [NameInMap("errorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                }

                /// <summary>
                /// <para>The migration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;e7c2e7d9-5e87-46a2-99e9-2be0b577a3fd&quot;</para>
                /// </summary>
                [NameInMap("migrationId")]
                [Validation(Required=false)]
                public string MigrationId { get; set; }

                /// <summary>
                /// <para>The operation type of the migration task. Valid values: 1: import. 2: export. 3: clone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("migrationType")]
                [Validation(Required=false)]
                public long? MigrationType { get; set; }

                /// <summary>
                /// <para>The executor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lvwan</para>
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>regionId</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The application migration status. Valid values: failed: Failed. finished: Succeeded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>finished</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The task progress percentage, stored as a floating-point number. For example, if the API returns 0.33, the progress bar displays 33%.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.33</para>
                /// </summary>
                [NameInMap("statePercent")]
                [Validation(Required=false)]
                public string StatePercent { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1791512615778</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b52155517851187240212426d0099</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
