// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call failed.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataList> List { get; set; }
            public class ListInstancesResponseBodyDataList : TeaModel {
                /// <summary>
                /// The commodity code of the instance. The commodity code of ApsaraMQ for RocketMQ 5.0 instances has a similar format to ons_rmqsub_public_cn.
                /// </summary>
                [NameInMap("commodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// The time when the version of the instance was updated.
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The time when the instance expires.
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The number of consumer groups that are created on the instance.
                /// </summary>
                [NameInMap("groupCount")]
                [Validation(Required=false)]
                public long? GroupCount { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("instanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The billing method of the instance.
                /// 
                /// Valid values:
                /// 
                /// *   PayAsYouGo
                /// *   Subscription
                /// </summary>
                [NameInMap("paymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                /// <summary>
                /// The product information.
                /// </summary>
                [NameInMap("productInfo")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyDataListProductInfo ProductInfo { get; set; }
                public class ListInstancesResponseBodyDataListProductInfo : TeaModel {
                    /// <summary>
                    /// Indicates whether the message trace feature is enabled. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// 
                    /// This parameter is not in use. By default, the message trace feature is enabled for ApsaraMQ for RocketMQ instances, regardless of whether this parameter is configured.
                    /// </summary>
                    [NameInMap("traceOn")]
                    [Validation(Required=false)]
                    public bool? TraceOn { get; set; }

                }

                /// <summary>
                /// The ID of the region in which the instance resides.
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The time when the instance was released.
                /// </summary>
                [NameInMap("releaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// The instance description.
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The ID of the resource group to which the instance belongs.
                /// </summary>
                [NameInMap("resourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The primary edition of the instance.
                /// 
                /// Valid values:
                /// 
                /// *   standard: Standard Edition
                /// *   ultimate: Enterprise Platinum Edition
                /// *   professional: Professional Edition
                /// </summary>
                [NameInMap("seriesCode")]
                [Validation(Required=false)]
                public string SeriesCode { get; set; }

                /// <summary>
                /// The code of the service to which the instance belongs. The service code of ApsaraMQ for RocketMQ is rmq.
                /// </summary>
                [NameInMap("serviceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// The time when the instance was created.
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The instance status.
                /// 
                /// Valid values:
                /// 
                /// *   RELEASED
                /// *   RUNNING
                /// *   STOPPED
                /// *   CHANGING
                /// *   CREATING
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The sub-category edition of the instance.
                /// 
                /// Valid values:
                /// 
                /// *   cluster_ha: Cluster High-availability Edition
                /// *   single_node: Standalone Edition
                /// </summary>
                [NameInMap("subSeriesCode")]
                [Validation(Required=false)]
                public string SubSeriesCode { get; set; }

                /// <summary>
                /// The resource tags.
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyDataListTags> Tags { get; set; }
                public class ListInstancesResponseBodyDataListTags : TeaModel {
                    /// <summary>
                    /// The tag key of the resource.
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value of the resource.
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The number of topics that are created on the instance.
                /// </summary>
                [NameInMap("topicCount")]
                [Validation(Required=false)]
                public long? TopicCount { get; set; }

                /// <summary>
                /// The time when the instance was last modified.
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The ID of the user who owns the instance.
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The dynamic error code.
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic error message.
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
