// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyData> Data { get; set; }
        public class ListClustersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.9.3</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster can be upgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanUpdate")]
            [Validation(Required=false)]
            public bool? CanUpdate { get; set; }

            /// <summary>
            /// <para>The billing method, including subscription and pay-as-you-go.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subscription</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The alias of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-7413****</para>
            /// </summary>
            [NameInMap("ClusterAliasName")]
            [Validation(Required=false)]
            public string ClusterAliasName { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-st21ri2****</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The cluster type, including ZooKeeper, Nacos-Ans, and Eureka.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Eureka</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-31 11:36:08</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-01 00:00:00</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The initialization status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RESTART_SUCCESS</para>
            /// </summary>
            [NameInMap("InitStatus")]
            [Validation(Required=false)]
            public string InitStatus { get; set; }

            /// <summary>
            /// <para>The number of clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public long? InstanceCount { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-st21ri2****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The public address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.98.XX.XX</para>
            /// </summary>
            [NameInMap("InternetAddress")]
            [Validation(Required=false)]
            public string InternetAddress { get; set; }

            /// <summary>
            /// <para>The public domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-7413****-p.eureka.mse.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InternetDomain")]
            [Validation(Required=false)]
            public string InternetDomain { get; set; }

            /// <summary>
            /// <para>The private network address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// <para>The internal domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-7413****-eureka.mse.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }

            /// <summary>
            /// <para>The O&amp;M time window.</para>
            /// </summary>
            [NameInMap("MaintenancePeriod")]
            [Validation(Required=false)]
            public ListClustersResponseBodyDataMaintenancePeriod MaintenancePeriod { get; set; }
            public class ListClustersResponseBodyDataMaintenancePeriod : TeaModel {
                /// <summary>
                /// <para>The end time of the O&amp;M time window.</para>
                /// 
                /// <b>Example:</b>
                /// <para>06:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The start time of the O&amp;M time window.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The edition of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse_pro</para>
            /// </summary>
            [NameInMap("MseVersion")]
            [Validation(Required=false)]
            public string MseVersion { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmv7jiavm4uxa</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tags bound to the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The version information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EUREKA_1_9_3</para>
            /// </summary>
            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public string VersionCode { get; set; }

            /// <summary>
            /// <para>The version lifecycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STABLE</para>
            /// </summary>
            [NameInMap("VersionLifecycle")]
            [Validation(Required=false)]
            public string VersionLifecycle { get; set; }

            /// <summary>
            /// <para>The ID of the VPC where the cluster is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1hcg467ekqsv0zr****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of instances returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69AD2AA7-DB47-449B-941B-B14409DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
