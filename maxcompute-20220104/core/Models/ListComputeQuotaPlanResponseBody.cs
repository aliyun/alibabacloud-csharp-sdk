// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListComputeQuotaPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListComputeQuotaPlanResponseBodyData Data { get; set; }
        public class ListComputeQuotaPlanResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of quota plan.</para>
            /// </summary>
            [NameInMap("planList")]
            [Validation(Required=false)]
            public List<ListComputeQuotaPlanResponseBodyDataPlanList> PlanList { get; set; }
            public class ListComputeQuotaPlanResponseBodyDataPlanList : TeaModel {
                /// <summary>
                /// <para>The time when the quota plan was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1731394621890</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

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
                public ListComputeQuotaPlanResponseBodyDataPlanListQuota Quota { get; set; }
                public class ListComputeQuotaPlanResponseBodyDataPlanListQuota : TeaModel {
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
                    /// <para>The time when the level-1 quota was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1730247361356</para>
                    /// </summary>
                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the Alibaba Cloud account that is used to create the resource.</para>
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
                    /// <para>186</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the level-1 quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dp_cn_hangzhou_1717465943_p</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The nickname of the level-1 quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>os_MyQuota_p</para>
                    /// </summary>
                    [NameInMap("nickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    /// <summary>
                    /// <para>The description of the level-1 quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///   &quot;enablePriority&quot;: false,
                    ///   &quot;minCU&quot;: 25,
                    ///   &quot;adhocCU&quot;: 0,
                    ///   &quot;elasticReservedCU&quot;: 0,
                    ///   &quot;forceReservedMin&quot;: false,
                    ///   &quot;maxCU&quot;: 50,
                    ///   &quot;schedulerType&quot;: &quot;Fifo&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("parameter")]
                    [Validation(Required=false)]
                    public ListComputeQuotaPlanResponseBodyDataPlanListQuotaParameter Parameter { get; set; }
                    public class ListComputeQuotaPlanResponseBodyDataPlanListQuotaParameter : TeaModel {
                        [NameInMap("elasticReservedCU")]
                        [Validation(Required=false)]
                        public long? ElasticReservedCU { get; set; }

                        [NameInMap("maxCU")]
                        [Validation(Required=false)]
                        public long? MaxCU { get; set; }

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
                    /// <para>The list of subquotas.</para>
                    /// </summary>
                    [NameInMap("subQuotaInfoList")]
                    [Validation(Required=false)]
                    public List<ListComputeQuotaPlanResponseBodyDataPlanListQuotaSubQuotaInfoList> SubQuotaInfoList { get; set; }
                    public class ListComputeQuotaPlanResponseBodyDataPlanListQuotaSubQuotaInfoList : TeaModel {
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
                        /// <para>The creation time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1730946421757</para>
                        /// </summary>
                        [NameInMap("createTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        /// <summary>
                        /// <para>The ID of the Alibaba Cloud account that is used to create the resource.</para>
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
                        /// <para>6790</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name of the level-2 quota.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dp_cn_shanghai_1702627945_p</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The nickname of the level-2 quota.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>os_MyQuota</para>
                        /// </summary>
                        [NameInMap("nickName")]
                        [Validation(Required=false)]
                        public string NickName { get; set; }

                        /// <summary>
                        /// <para>The description of the level-2 quota.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///   &quot;enablePriority&quot;: false,
                        ///   &quot;minCU&quot;: 25,
                        ///   &quot;adhocCU&quot;: 0,
                        ///   &quot;elasticReservedCU&quot;: 0,
                        ///   &quot;forceReservedMin&quot;: false,
                        ///   &quot;maxCU&quot;: 50,
                        ///   &quot;schedulerType&quot;: &quot;Fifo&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("parameter")]
                        [Validation(Required=false)]
                        public ListComputeQuotaPlanResponseBodyDataPlanListQuotaSubQuotaInfoListParameter Parameter { get; set; }
                        public class ListComputeQuotaPlanResponseBodyDataPlanListQuotaSubQuotaInfoListParameter : TeaModel {
                            [NameInMap("elasticReservedCU")]
                            [Validation(Required=false)]
                            public long? ElasticReservedCU { get; set; }

                            [NameInMap("maxCU")]
                            [Validation(Required=false)]
                            public long? MaxCU { get; set; }

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
                        /// <para>The version number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2056</para>
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
                    /// <para>The type of quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FUXI_ONLINE</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2056</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This object does not exist.</para>
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
        /// <para>0bc3b4ae16685836687916212e7850</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
