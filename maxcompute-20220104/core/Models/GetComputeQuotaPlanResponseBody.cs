// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetComputeQuotaPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetComputeQuotaPlanResponseBodyData Data { get; set; }
        public class GetComputeQuotaPlanResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the quota plan was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730946421757</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Whether it is currently effective.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>A Quota plan that has taken effect cannot be deleted, i.e., isEffective=true</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true/false</para>
            /// </summary>
            [NameInMap("isEffective")]
            [Validation(Required=false)]
            public bool? IsEffective { get; set; }

            /// <summary>
            /// <para>The name of the quota plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>planA</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The details of the quota.</para>
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public GetComputeQuotaPlanResponseBodyDataQuota Quota { get; set; }
            public class GetComputeQuotaPlanResponseBodyDataQuota : TeaModel {
                /// <summary>
                /// <para>Cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AT-120N</para>
                /// </summary>
                [NameInMap("cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719886322347</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Creator\&quot;s cloud account UID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>672863518</para>
                /// </summary>
                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The ID of the level-1 quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2413</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the level-1 quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>quota_a</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The nickname of the level-1 quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>quota_nickname</para>
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>CU value parameters for the level-1 quota.</para>
                /// </summary>
                [NameInMap("parameter")]
                [Validation(Required=false)]
                public GetComputeQuotaPlanResponseBodyDataQuotaParameter Parameter { get; set; }
                public class GetComputeQuotaPlanResponseBodyDataQuotaParameter : TeaModel {
                    /// <summary>
                    /// <para>The value of elastic Reserved CUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("elasticReservedCU")]
                    [Validation(Required=false)]
                    public long? ElasticReservedCU { get; set; }

                    /// <summary>
                    /// <para>The value of maxCU in Reserved CUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("maxCU")]
                    [Validation(Required=false)]
                    public long? MaxCU { get; set; }

                    /// <summary>
                    /// <para>The value of minCU in Reserved CUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("minCU")]
                    [Validation(Required=false)]
                    public long? MinCU { get; set; }

                }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Resource status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The list of level-2 quotas.</para>
                /// </summary>
                [NameInMap("subQuotaInfoList")]
                [Validation(Required=false)]
                public List<GetComputeQuotaPlanResponseBodyDataQuotaSubQuotaInfoList> SubQuotaInfoList { get; set; }
                public class GetComputeQuotaPlanResponseBodyDataQuotaSubQuotaInfoList : TeaModel {
                    /// <summary>
                    /// <para>Cluster ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AT-120N</para>
                    /// </summary>
                    [NameInMap("cluster")]
                    [Validation(Required=false)]
                    public string Cluster { get; set; }

                    /// <summary>
                    /// <para>Creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1718155201628</para>
                    /// </summary>
                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>Creator cloud account UID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>672863518</para>
                    /// </summary>
                    [NameInMap("creatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    /// <summary>
                    /// <para>The ID of the level-2 quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10940</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the level-2 quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dp_cn_shanghai_1696659792_p</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The nickname of the level-2 quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subquotaA</para>
                    /// </summary>
                    [NameInMap("nickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    /// <summary>
                    /// <para>The parameters of the level-2 quota.</para>
                    /// </summary>
                    [NameInMap("parameter")]
                    [Validation(Required=false)]
                    public GetComputeQuotaPlanResponseBodyDataQuotaSubQuotaInfoListParameter Parameter { get; set; }
                    public class GetComputeQuotaPlanResponseBodyDataQuotaSubQuotaInfoListParameter : TeaModel {
                        /// <summary>
                        /// <para>The value of elastic Reserved CUs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("elasticReservedCU")]
                        [Validation(Required=false)]
                        public long? ElasticReservedCU { get; set; }

                        /// <summary>
                        /// <para>whether to enable the priority feature.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true/false</para>
                        /// </summary>
                        [NameInMap("enablePriority")]
                        [Validation(Required=false)]
                        public bool? EnablePriority { get; set; }

                        /// <summary>
                        /// <para>Whether it is exclusive.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true/false</para>
                        /// </summary>
                        [NameInMap("forceReservedMin")]
                        [Validation(Required=false)]
                        public bool? ForceReservedMin { get; set; }

                        /// <summary>
                        /// <para>The value of maxCU in Reserved CUs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("maxCU")]
                        [Validation(Required=false)]
                        public long? MaxCU { get; set; }

                        /// <summary>
                        /// <para>The value of minCU in Reserved CUs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("minCU")]
                        [Validation(Required=false)]
                        public long? MinCU { get; set; }

                        /// <summary>
                        /// <para>Scheduling policy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Fifo/Fair</para>
                        /// </summary>
                        [NameInMap("schedulerType")]
                        [Validation(Required=false)]
                        public string SchedulerType { get; set; }

                        /// <summary>
                        /// <para>The upper limit for CUs that can be concurrently used by a job scheduled to the quota.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("singleJobCULimit")]
                        [Validation(Required=false)]
                        public long? SingleJobCULimit { get; set; }

                    }

                    /// <summary>
                    /// <para>Region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>Resource status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ON</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>Tenant ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>478403690625249</para>
                    /// </summary>
                    [NameInMap("tenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// <para>The type of quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FUXI_ONLINE</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>Version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1386</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>Tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>478403690625249</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>Corresponds to the <c>resourceSystemType</c> field of the control cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FUXI_ONLINE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1964</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QUOTA_PLAN_NOT_FOUND</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan \&quot;***\&quot; does not exist</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: informational response. The request is received and is being processed.</description></item>
        /// <item><description>2xx: success. The request is successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: redirection. The request is redirected, and further actions are required to complete the request.</description></item>
        /// <item><description>4xx: client error. The request contains invalid request parameters or syntaxes, or specific request conditions cannot be met.</description></item>
        /// <item><description>5xx: server error. The server cannot meet requirements due to other reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA1320AB-7766-5EC7-B0F6-8B20E2298567</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
