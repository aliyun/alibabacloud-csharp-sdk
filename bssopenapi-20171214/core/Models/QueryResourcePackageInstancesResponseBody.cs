// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryResourcePackageInstancesResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryResourcePackageInstancesResponseBodyData Data { get; set; }
        public class QueryResourcePackageInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the host.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The details of the instances.
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public QueryResourcePackageInstancesResponseBodyDataInstances Instances { get; set; }
            public class QueryResourcePackageInstancesResponseBodyDataInstances : TeaModel {
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public List<QueryResourcePackageInstancesResponseBodyDataInstancesInstance> Instance { get; set; }
                public class QueryResourcePackageInstancesResponseBodyDataInstancesInstance : TeaModel {
                    /// <summary>
                    /// The services to which the resource plan is applicable.
                    /// </summary>
                    [NameInMap("ApplicableProducts")]
                    [Validation(Required=false)]
                    public QueryResourcePackageInstancesResponseBodyDataInstancesInstanceApplicableProducts ApplicableProducts { get; set; }
                    public class QueryResourcePackageInstancesResponseBodyDataInstancesInstanceApplicableProducts : TeaModel {
                        [NameInMap("Product")]
                        [Validation(Required=false)]
                        public List<string> Product { get; set; }

                    }

                    /// <summary>
                    /// The commodity code.
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    /// <summary>
                    /// The deduction type. Example: Absolute.
                    /// </summary>
                    [NameInMap("DeductType")]
                    [Validation(Required=false)]
                    public string DeductType { get; set; }

                    /// <summary>
                    /// The time when the resource plan took effect.
                    /// </summary>
                    [NameInMap("EffectiveTime")]
                    [Validation(Required=false)]
                    public string EffectiveTime { get; set; }

                    /// <summary>
                    /// The time when the resource plan expired.
                    /// </summary>
                    [NameInMap("ExpiryTime")]
                    [Validation(Required=false)]
                    public string ExpiryTime { get; set; }

                    /// <summary>
                    /// The ID of the instance.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The type of the resource plan.
                    /// </summary>
                    [NameInMap("PackageType")]
                    [Validation(Required=false)]
                    public string PackageType { get; set; }

                    /// <summary>
                    /// The ID of the region.
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// The remaining quota.
                    /// </summary>
                    [NameInMap("RemainingAmount")]
                    [Validation(Required=false)]
                    public string RemainingAmount { get; set; }

                    /// <summary>
                    /// The unit of the remaining quota.
                    /// </summary>
                    [NameInMap("RemainingAmountUnit")]
                    [Validation(Required=false)]
                    public string RemainingAmountUnit { get; set; }

                    /// <summary>
                    /// The remarks on the resource plan. The remarks must be made in Chinese.
                    /// </summary>
                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// The status of the resource plan. Valid values:
                    /// 
                    /// *   Available
                    /// *   Expired
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The total quota of the resource plan.
                    /// </summary>
                    [NameInMap("TotalAmount")]
                    [Validation(Required=false)]
                    public string TotalAmount { get; set; }

                    /// <summary>
                    /// The unit of the total quota.
                    /// </summary>
                    [NameInMap("TotalAmountUnit")]
                    [Validation(Required=false)]
                    public string TotalAmountUnit { get; set; }

                }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public string PageNum { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
