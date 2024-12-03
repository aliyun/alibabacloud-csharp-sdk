// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryResourcePackageInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryResourcePackageInstancesResponseBodyData Data { get; set; }
        public class QueryResourcePackageInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The details of the instances.</para>
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
                    /// <para>The services to which the resource plan is applicable.</para>
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
                    /// <para>The commodity code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    /// <summary>
                    /// <para>The deduction type. Example: Absolute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Absolute</para>
                    /// </summary>
                    [NameInMap("DeductType")]
                    [Validation(Required=false)]
                    public string DeductType { get; set; }

                    /// <summary>
                    /// <para>The time when the resource plan took effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-09-12T09:51:56Z</para>
                    /// </summary>
                    [NameInMap("EffectiveTime")]
                    [Validation(Required=false)]
                    public string EffectiveTime { get; set; }

                    /// <summary>
                    /// <para>The time when the resource plan expired.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-03-12T16:00:00Z</para>
                    /// </summary>
                    [NameInMap("ExpiryTime")]
                    [Validation(Required=false)]
                    public string ExpiryTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSSBAG-cn-v0h1s4hma01</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The type of the resource plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FPT_ossbag_absolute_Storage_sh</para>
                    /// </summary>
                    [NameInMap("PackageType")]
                    [Validation(Required=false)]
                    public string PackageType { get; set; }

                    /// <summary>
                    /// <para>The ID of the region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The remaining quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40.000</para>
                    /// </summary>
                    [NameInMap("RemainingAmount")]
                    [Validation(Required=false)]
                    public string RemainingAmount { get; set; }

                    /// <summary>
                    /// <para>The unit of the remaining quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GB</para>
                    /// </summary>
                    [NameInMap("RemainingAmountUnit")]
                    [Validation(Required=false)]
                    public string RemainingAmountUnit { get; set; }

                    /// <summary>
                    /// <para>The remarks on the resource plan. The remarks must be made in Chinese.</para>
                    /// </summary>
                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// <para>The status of the resource plan. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Available</description></item>
                    /// <item><description>Expired</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The total quota of the resource plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40.000</para>
                    /// </summary>
                    [NameInMap("TotalAmount")]
                    [Validation(Required=false)]
                    public string TotalAmount { get; set; }

                    /// <summary>
                    /// <para>The unit of the total quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GB</para>
                    /// </summary>
                    [NameInMap("TotalAmountUnit")]
                    [Validation(Required=false)]
                    public string TotalAmountUnit { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public string PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
