// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeStorageGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6666C5A5-75ED-422E-A022-7121FA18C968</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list information.</para>
        /// </summary>
        [NameInMap("StorageGateways")]
        [Validation(Required=false)]
        public List<DescribeStorageGatewayResponseBodyStorageGateways> StorageGateways { get; set; }
        public class DescribeStorageGatewayResponseBodyStorageGateways : TeaModel {
            /// <summary>
            /// <para>The internal CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.2.0/24</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The time when the storage gateway was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-14T03:07:47Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the storage gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-cmcc</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The IP address of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><em>.</em>.<em>.</em></para>
            /// </summary>
            [NameInMap("ServiceIp")]
            [Validation(Required=false)]
            public string ServiceIp { get; set; }

            /// <summary>
            /// <para>The status of the storage gateway. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>creating</description></item>
            /// <item><description>available</description></item>
            /// <item><description>deleting</description></item>
            /// <item><description>deleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the storage gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgw-***</para>
            /// </summary>
            [NameInMap("StorageGatewayId")]
            [Validation(Required=false)]
            public string StorageGatewayId { get; set; }

            /// <summary>
            /// <para>The name of the storage gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testGateway</para>
            /// </summary>
            [NameInMap("StorageGatewayName")]
            [Validation(Required=false)]
            public string StorageGatewayName { get; set; }

            /// <summary>
            /// <para>The type of the storage gateway. Default value: 1, which indicates iSCSI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StorageGatewayType")]
            [Validation(Required=false)]
            public int? StorageGatewayType { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-***</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
