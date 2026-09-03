// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCloudDriveServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the enterprise NAS drive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-778205****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The service name of the cloud storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDS_Windows_1126</para>
        /// </summary>
        [NameInMap("CdsName")]
        [Validation(Required=false)]
        public string CdsName { get; set; }

        /// <summary>
        /// <para>The instance ID of the Cloud Enterprise Network (CEN).</para>
        /// <remarks>
        /// <para>To connect to cloud desktops over a VPC, you can add the office network to a CEN instance. This CEN instance is the one to which the on-premises network is connected by using a VPN or Express Connect circuit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cen-638u3wxds9snyc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The existing NAS drive or NAS drive order that conflicts with the NAS drive to be created.</para>
        /// </summary>
        [NameInMap("ConflictCdsAndOrder")]
        [Validation(Required=false)]
        public CreateCloudDriveServiceResponseBodyConflictCdsAndOrder ConflictCdsAndOrder { get; set; }
        public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrder : TeaModel {
            /// <summary>
            /// <para>The information about the conflicting NAS drive.</para>
            /// </summary>
            [NameInMap("ConflictCds")]
            [Validation(Required=false)]
            public List<CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictCds> ConflictCds { get; set; }
            public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictCds : TeaModel {
                /// <summary>
                /// <para>The ID of the enterprise NAS drive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+cds-778205****</para>
                /// </summary>
                [NameInMap("CdsId")]
                [Validation(Required=false)]
                public string CdsId { get; set; }

                /// <summary>
                /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The information about the conflicting unpaid NAS drive order (subscription NAS drive order).</para>
            /// </summary>
            [NameInMap("ConflictOrder")]
            [Validation(Required=false)]
            public List<CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictOrder> ConflictOrder { get; set; }
            public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictOrder : TeaModel {
                /// <summary>
                /// <para>The ID of the enterprise NAS drive. The order is not paid, and the NAS drive is unavailable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+cds-778205****</para>
                /// </summary>
                [NameInMap("CdsId")]
                [Validation(Required=false)]
                public string CdsId { get; set; }

                /// <summary>
                /// <para>The order ID. You can obtain the order ID on the <b>Orders</b> page in the Alibaba Cloud User Center.</para>
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
        /// <para>The AD domain name of the AD office network.</para>
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
        /// <para>The maximum storage capacity of the enterprise NAS drive. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5368709120</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public string MaxSize { get; set; }

        /// <summary>
        /// <para>The network type of the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD_CONNECTOR</para>
        /// </summary>
        [NameInMap("OfficeSiteType")]
        [Validation(Required=false)]
        public string OfficeSiteType { get; set; }

        /// <summary>
        /// <para>The order ID. You can obtain the order ID on the Orders page in the Alibaba Cloud User Center.</para>
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
