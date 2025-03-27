// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCloudDriveServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the enterprise drive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-7782057786</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The name of the cloud disk that is created in Cloud Drive Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDS_Windows_1126</para>
        /// </summary>
        [NameInMap("CdsName")]
        [Validation(Required=false)]
        public string CdsName { get; set; }

        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// <remarks>
        /// <para> To allow end users to connect to cloud computers via virtual private clouds (VPCs), attach your office network to a CEN instance. The CEN instance connects to your on-premises network through VPN Gateway or Express Connect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cen-638u3wxds9snyc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The existing enterprise drive or its order that conflicts with the enterprise drive being created.</para>
        /// </summary>
        [NameInMap("ConflictCdsAndOrder")]
        [Validation(Required=false)]
        public CreateCloudDriveServiceResponseBodyConflictCdsAndOrder ConflictCdsAndOrder { get; set; }
        public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrder : TeaModel {
            /// <summary>
            /// <para>The conflicting enterprise drive.</para>
            /// </summary>
            [NameInMap("ConflictCds")]
            [Validation(Required=false)]
            public List<CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictCds> ConflictCds { get; set; }
            public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictCds : TeaModel {
                /// <summary>
                /// <para>The ID of the enterprise drive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+cds-778205****</para>
                /// </summary>
                [NameInMap("CdsId")]
                [Validation(Required=false)]
                public string CdsId { get; set; }

                /// <summary>
                /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The subscription orders of the conflicting enterprise drives that are unpaid.</para>
            /// </summary>
            [NameInMap("ConflictOrder")]
            [Validation(Required=false)]
            public List<CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictOrder> ConflictOrder { get; set; }
            public class CreateCloudDriveServiceResponseBodyConflictCdsAndOrderConflictOrder : TeaModel {
                /// <summary>
                /// <para>The ID of the enterprise drive. The enterprise drive cannot be used if the order is unpaid.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+cds-778205****</para>
                /// </summary>
                [NameInMap("CdsId")]
                [Validation(Required=false)]
                public string CdsId { get; set; }

                /// <summary>
                /// <para>The ID of the order. You can obtain an order ID on the <b>Orders</b> page in the Expenses and Costs console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22442411898****</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
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
        /// <para>The domain name of the enterprise AD office network.</para>
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
        /// <para>The maximum storage capacity of the enterprise drive. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>213674622976</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public string MaxSize { get; set; }

        /// <summary>
        /// <para>The type of the office network.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SIMPLE: convenience office network.</description></item>
        /// <item><description>AD_CONNECTOR: enterprise AD office network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AD_CONNECTOR</para>
        /// </summary>
        [NameInMap("OfficeSiteType")]
        [Validation(Required=false)]
        public string OfficeSiteType { get; set; }

        /// <summary>
        /// <para>The ID of the order. You can obtain an order ID on the Orders page in the Expenses and Costs console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>214552063030752</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>062B1439-709A-580E-85DF-CE97A1560565</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
