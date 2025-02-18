// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetQuotaPlanResponseBodyData Data { get; set; }
        public class GetQuotaPlanResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the quota plan was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-16T06:07:45Z</para>
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
            public GetQuotaPlanResponseBodyDataQuota Quota { get; set; }
            public class GetQuotaPlanResponseBodyDataQuota : TeaModel {
                /// <summary>
                /// <para>The information of the order.</para>
                /// </summary>
                [NameInMap("billingPolicy")]
                [Validation(Required=false)]
                public GetQuotaPlanResponseBodyDataQuotaBillingPolicy BillingPolicy { get; set; }
                public class GetQuotaPlanResponseBodyDataQuotaBillingPolicy : TeaModel {
                    /// <summary>
                    /// <para>The billing method of the quota. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>subscription: a subscription quota.</description></item>
                    /// <item><description>payasyougo: a pay-as-you-go quota.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subscription</para>
                    /// </summary>
                    [NameInMap("billingMethod")]
                    [Validation(Required=false)]
                    public string BillingMethod { get; set; }

                    /// <summary>
                    /// <para>The specifications of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OdpsStandard</para>
                    /// </summary>
                    [NameInMap("odpsSpecCode")]
                    [Validation(Required=false)]
                    public string OdpsSpecCode { get; set; }

                    /// <summary>
                    /// <para>The ID of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>45245678</para>
                    /// </summary>
                    [NameInMap("orderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AT-120N</para>
                /// </summary>
                [NameInMap("cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// <para>The time when the quota plan was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-06T02:14:44Z</para>
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
                /// <para>The ID of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>quota_a</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The alias of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>quota_nickname</para>
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The description of the quota.</para>
                /// </summary>
                [NameInMap("parameter")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameter { get; set; }

                /// <summary>
                /// <para>The ID of the parent resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The information of the scheduling plan.</para>
                /// </summary>
                [NameInMap("scheduleInfo")]
                [Validation(Required=false)]
                public GetQuotaPlanResponseBodyDataQuotaScheduleInfo ScheduleInfo { get; set; }
                public class GetQuotaPlanResponseBodyDataQuotaScheduleInfo : TeaModel {
                    /// <summary>
                    /// <para>The quota plan that takes effect based on the scheduling plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planA</para>
                    /// </summary>
                    [NameInMap("currPlan")]
                    [Validation(Required=false)]
                    public string CurrPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the current quota plan is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0800</para>
                    /// </summary>
                    [NameInMap("currTime")]
                    [Validation(Required=false)]
                    public string CurrTime { get; set; }

                    /// <summary>
                    /// <para>The next quota plan that will take effect based on the scheduling plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planB</para>
                    /// </summary>
                    [NameInMap("nextPlan")]
                    [Validation(Required=false)]
                    public string NextPlan { get; set; }

                    /// <summary>
                    /// <para>The time when the next quota plan is scheduled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1700</para>
                    /// </summary>
                    [NameInMap("nextTime")]
                    [Validation(Required=false)]
                    public string NextTime { get; set; }

                    /// <summary>
                    /// <para>If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>planC</para>
                    /// </summary>
                    [NameInMap("oncePlan")]
                    [Validation(Required=false)]
                    public string OncePlan { get; set; }

                    /// <summary>
                    /// <para>The time when the quota plan immediately takes effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1500</para>
                    /// </summary>
                    [NameInMap("onceTime")]
                    [Validation(Required=false)]
                    public string OnceTime { get; set; }

                    /// <summary>
                    /// <para>The name of the operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>userA</para>
                    /// </summary>
                    [NameInMap("operatorName")]
                    [Validation(Required=false)]
                    public string OperatorName { get; set; }

                }

                /// <summary>
                /// <para>The status of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The information of the level-2 quota.</para>
                /// </summary>
                [NameInMap("subQuotaInfoList")]
                [Validation(Required=false)]
                public List<GetQuotaPlanResponseBodyDataQuotaSubQuotaInfoList> SubQuotaInfoList { get; set; }
                public class GetQuotaPlanResponseBodyDataQuotaSubQuotaInfoList : TeaModel {
                    /// <summary>
                    /// <para>The information of the order.</para>
                    /// </summary>
                    [NameInMap("billingPolicy")]
                    [Validation(Required=false)]
                    public GetQuotaPlanResponseBodyDataQuotaSubQuotaInfoListBillingPolicy BillingPolicy { get; set; }
                    public class GetQuotaPlanResponseBodyDataQuotaSubQuotaInfoListBillingPolicy : TeaModel {
                        /// <summary>
                        /// <para>The billing method of the quota. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>subscription: a subscription quota.</description></item>
                        /// <item><description>payasyougo: a pay-as-you-go quota.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>subscription</para>
                        /// </summary>
                        [NameInMap("billingMethod")]
                        [Validation(Required=false)]
                        public string BillingMethod { get; set; }

                        /// <summary>
                        /// <para>The specifications of the order.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OdpsStandard</para>
                        /// </summary>
                        [NameInMap("odpsSpecCode")]
                        [Validation(Required=false)]
                        public string OdpsSpecCode { get; set; }

                        /// <summary>
                        /// <para>The ID of the order.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>45245678</para>
                        /// </summary>
                        [NameInMap("orderId")]
                        [Validation(Required=false)]
                        public string OrderId { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AT-120N</para>
                    /// </summary>
                    [NameInMap("cluster")]
                    [Validation(Required=false)]
                    public string Cluster { get; set; }

                    /// <summary>
                    /// <para>The time when the resource was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-09-06T02:14:44Z</para>
                    /// </summary>
                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the user who created the quota plan.</para>
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
                    /// <para>1000048</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the level-2 quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subquotaA</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The alias of the level-2 quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subquotaA</para>
                    /// </summary>
                    [NameInMap("nickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    /// <summary>
                    /// <para>The description of the quota.</para>
                    /// </summary>
                    [NameInMap("parameter")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Parameter { get; set; }

                    /// <summary>
                    /// <para>The ID of the parent resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("parentId")]
                    [Validation(Required=false)]
                    public string ParentId { get; set; }

                    /// <summary>
                    /// <para>The ID of the region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing</para>
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The information of the scheduling plan.</para>
                    /// </summary>
                    [NameInMap("scheduleInfo")]
                    [Validation(Required=false)]
                    public GetQuotaPlanResponseBodyDataQuotaSubQuotaInfoListScheduleInfo ScheduleInfo { get; set; }
                    public class GetQuotaPlanResponseBodyDataQuotaSubQuotaInfoListScheduleInfo : TeaModel {
                        /// <summary>
                        /// <para>The quota plan that takes effect based on the scheduling plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>planA</para>
                        /// </summary>
                        [NameInMap("currPlan")]
                        [Validation(Required=false)]
                        public string CurrPlan { get; set; }

                        /// <summary>
                        /// <para>The time when the current quota plan is scheduled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0800</para>
                        /// </summary>
                        [NameInMap("currTime")]
                        [Validation(Required=false)]
                        public string CurrTime { get; set; }

                        /// <summary>
                        /// <para>The next quota plan that will take effect based on the scheduling plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>planB</para>
                        /// </summary>
                        [NameInMap("nextPlan")]
                        [Validation(Required=false)]
                        public string NextPlan { get; set; }

                        /// <summary>
                        /// <para>The time when the next quota plan is scheduled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1700</para>
                        /// </summary>
                        [NameInMap("nextTime")]
                        [Validation(Required=false)]
                        public string NextTime { get; set; }

                        /// <summary>
                        /// <para>If the quota plan that immediately takes effect is different from the current quota plan, this parameter is not empty.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>planC</para>
                        /// </summary>
                        [NameInMap("oncePlan")]
                        [Validation(Required=false)]
                        public string OncePlan { get; set; }

                        /// <summary>
                        /// <para>The time when the quota plan immediately takes effect.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1500</para>
                        /// </summary>
                        [NameInMap("onceTime")]
                        [Validation(Required=false)]
                        public string OnceTime { get; set; }

                        /// <summary>
                        /// <para>The name of the operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userA</para>
                        /// </summary>
                        [NameInMap("operatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                    }

                    /// <summary>
                    /// <para>The status of the resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ON</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The tag of the resource for the quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The ID of the tenant.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>478403690625249</para>
                    /// </summary>
                    [NameInMap("tenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// <para>The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the cluster.</para>
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The tag of the resource for the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>478403690625249</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The type of the resource system. This parameter corresponds to the resourceSystemType parameter of the cluster.</para>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0be3e0aa16667684362147582e038f</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
