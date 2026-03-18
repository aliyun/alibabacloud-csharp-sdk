// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetComputeQuotaPlanResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetComputeQuotaPlanResponseBodyData Data { get; set; }
        public class GetComputeQuotaPlanResponseBodyData : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("isEffective")]
            [Validation(Required=false)]
            public bool? IsEffective { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("quota")]
            [Validation(Required=false)]
            public GetComputeQuotaPlanResponseBodyDataQuota Quota { get; set; }
            public class GetComputeQuotaPlanResponseBodyDataQuota : TeaModel {
                [NameInMap("cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("parameter")]
                [Validation(Required=false)]
                public GetComputeQuotaPlanResponseBodyDataQuotaParameter Parameter { get; set; }
                public class GetComputeQuotaPlanResponseBodyDataQuotaParameter : TeaModel {
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

                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("subQuotaInfoList")]
                [Validation(Required=false)]
                public List<GetComputeQuotaPlanResponseBodyDataQuotaSubQuotaInfoList> SubQuotaInfoList { get; set; }
                public class GetComputeQuotaPlanResponseBodyDataQuotaSubQuotaInfoList : TeaModel {
                    [NameInMap("cluster")]
                    [Validation(Required=false)]
                    public string Cluster { get; set; }

                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("creatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    [NameInMap("parameter")]
                    [Validation(Required=false)]
                    public GetComputeQuotaPlanResponseBodyDataQuotaSubQuotaInfoListParameter Parameter { get; set; }
                    public class GetComputeQuotaPlanResponseBodyDataQuotaSubQuotaInfoListParameter : TeaModel {
                        [NameInMap("elasticReservedCU")]
                        [Validation(Required=false)]
                        public long? ElasticReservedCU { get; set; }

                        [NameInMap("enablePriority")]
                        [Validation(Required=false)]
                        public bool? EnablePriority { get; set; }

                        [NameInMap("forceReservedMin")]
                        [Validation(Required=false)]
                        public bool? ForceReservedMin { get; set; }

                        [NameInMap("maxCU")]
                        [Validation(Required=false)]
                        public long? MaxCU { get; set; }

                        [NameInMap("minCU")]
                        [Validation(Required=false)]
                        public long? MinCU { get; set; }

                        [NameInMap("schedulerType")]
                        [Validation(Required=false)]
                        public string SchedulerType { get; set; }

                        [NameInMap("singleJobCULimit")]
                        [Validation(Required=false)]
                        public long? SingleJobCULimit { get; set; }

                    }

                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("tenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
