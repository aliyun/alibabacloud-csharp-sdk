// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCloudDriveServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the enterprise network disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-778205****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The name of the cloud storage service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDS_Windows_1126</para>
        /// </summary>
        [NameInMap("CdsName")]
        [Validation(Required=false)]
        public string CdsName { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// <remarks>
        /// <para>If you want to connect to a cloud desktop through a VPC, you can add the office network to a CEN instance. This CEN instance connects to your on-premises network through a VPN or a dedicated line.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cen-638u3wxds9snyc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The existing enterprise network disks or orders for enterprise network disks that conflict with the enterprise network disk that you want to create.</para>
        /// </summary>
        [NameInMap("ConflictCdsAndOrder")]
        [Validation(Required=false)]
        public CreateCloudDriveServiceResponseBodyConflictCdsAndOrder ConflictCdsAndOrder { get; set; }
        public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrder : TeaModel {
            /// <summary>
            /// <para>The information of conflicting enterprise network disks.</para>
            /// </summary>
            [NameInMap("ConflictCds")]
            [Validation(Required=false)]
            public List<CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictCds> ConflictCds { get; set; }
            public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictCds : TeaModel {
                /// <summary>
                /// <para>The ID of the enterprise network disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+cds-778205****</para>
                /// </summary>
                [NameInMap("CdsId")]
                [Validation(Required=false)]
                public string CdsId { get; set; }

                /// <summary>
                /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the regions that are supported by Elastic Desktop Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The information of conflicting unpaid orders for enterprise network disks (orders for subscription enterprise network disks).</para>
            /// </summary>
            [NameInMap("ConflictOrder")]
            [Validation(Required=false)]
            public List<CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictOrder> ConflictOrder { get; set; }
            public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictOrder : TeaModel {
                /// <summary>
                /// <para>The ID of the enterprise network disk (The order is not paid, and the enterprise network disk cannot be used).</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+cds-778205****</para>
                /// </summary>
                [NameInMap("CdsId")]
                [Validation(Required=false)]
                public string CdsId { get; set; }

                /// <summary>
                /// <para>The order ID. You can obtain the order ID on the <b>Order Management</b> page in the Alibaba Cloud User Center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22442411898****</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The name of the Active Directory (AD) domain corresponding to the AD office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1.local</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExistConflictCds</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The maximum storage usage of the enterprise network disk. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5368709120</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public string MaxSize { get; set; }

        /// <summary>
        /// <para>The office network type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD_CONNECTOR</para>
        /// </summary>
        [NameInMap("OfficeSiteType")]
        [Validation(Required=false)]
        public string OfficeSiteType { get; set; }

        /// <summary>
        /// <para>The order ID. You can obtain the order ID on the Order Management page in the Alibaba Cloud User Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>214552063030752</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>062B1439-709A-580E-85DF-CE97A156****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
