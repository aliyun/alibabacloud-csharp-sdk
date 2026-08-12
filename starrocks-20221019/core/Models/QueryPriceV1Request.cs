// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryPriceV1Request : TeaModel {
        /// <summary>
        /// <para>Agent compute group.</para>
        /// </summary>
        [NameInMap("AgentNodeGroup")]
        [Validation(Required=false)]
        public QueryPriceV1RequestAgentNodeGroup AgentNodeGroup { get; set; }
        public class QueryPriceV1RequestAgentNodeGroup : TeaModel {
            /// <summary>
            /// <para>Number of CUs. A Compute Unit (CU) is the basic billing unit. One CU equals one vCPU plus 4 GiB of memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

        }

        /// <summary>
        /// <para>BE or CN compute group information.</para>
        /// </summary>
        [NameInMap("BackendNodeGroups")]
        [Validation(Required=false)]
        public List<QueryPriceV1RequestBackendNodeGroups> BackendNodeGroups { get; set; }
        public class QueryPriceV1RequestBackendNodeGroups : TeaModel {
            /// <summary>
            /// <para>Number of CUs. A Compute Unit (CU) is the basic billing unit. One CU equals one vCPU plus 4 GiB of memory. For ramEnhanced instances, one CU equals one vCPU plus 8 GiB of memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public string Cu { get; set; }

            /// <summary>
            /// <para>Number of disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("diskNumber")]
            [Validation(Required=false)]
            public int? DiskNumber { get; set; }

            /// <summary>
            /// <para>Local SSD instance type for the node group. This field applies only to ECS-based instances with specType set to localSSD or bigData.</para>
            /// 
            /// <b>Example:</b>
            /// <para>local_ssd_4_4xlarge</para>
            /// </summary>
            [NameInMap("localStorageInstanceType")]
            [Validation(Required=false)]
            public string LocalStorageInstanceType { get; set; }

            /// <summary>
            /// <para>Number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("residentNodeNumber")]
            [Validation(Required=false)]
            public int? ResidentNodeNumber { get; set; }

            /// <summary>
            /// <para>Compute group specification type. Supported types include the following:</para>
            /// <list type="bullet">
            /// <item><description><para>standard: Standard Edition.</para>
            /// </description></item>
            /// <item><description><para>localSSD: Local SSD.</para>
            /// </description></item>
            /// <item><description><para>bigData: Large-storage Edition.</para>
            /// </description></item>
            /// <item><description><para>ramEnhanced: Memory-enhanced instance family.</para>
            /// </description></item>
            /// <item><description><para>networkEnhanced: Network-enhanced instance family.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("specType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>Disk performance level. Supported values include the following:</para>
            /// <list type="bullet">
            /// <item><description><para>pl0: Maximum random read/write IOPS per disk is 10,000.</para>
            /// </description></item>
            /// <item><description><para>pl1: Maximum random read/write IOPS per disk is 50,000.</para>
            /// </description></item>
            /// <item><description><para>pl2: Maximum random read/write IOPS per disk is 100,000.</para>
            /// </description></item>
            /// <item><description><para>pl3: Maximum random read/write IOPS per disk is 1,000,000.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pl1</para>
            /// </summary>
            [NameInMap("storagePerformanceLevel")]
            [Validation(Required=false)]
            public string StoragePerformanceLevel { get; set; }

            /// <summary>
            /// <para>Storage size in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("storageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

        }

        /// <summary>
        /// <para>Subscription duration. Valid only when PayType is prePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>FE node group information.</para>
        /// </summary>
        [NameInMap("FrontendNodeGroups")]
        [Validation(Required=false)]
        public List<QueryPriceV1RequestFrontendNodeGroups> FrontendNodeGroups { get; set; }
        public class QueryPriceV1RequestFrontendNodeGroups : TeaModel {
            /// <summary>
            /// <para>Number of CUs. A Compute Unit (CU) is the basic billing unit. One CU equals one vCPU plus 4 GiB of memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public string Cu { get; set; }

            /// <summary>
            /// <para>Number of disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("diskNumber")]
            [Validation(Required=false)]
            public int? DiskNumber { get; set; }

            /// <summary>
            /// <para>Local SSD instance type. Do not set this field for FE compute groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("localStorageInstanceType")]
            [Validation(Required=false)]
            public string LocalStorageInstanceType { get; set; }

            /// <summary>
            /// <para>Number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("residentNodeNumber")]
            [Validation(Required=false)]
            public int? ResidentNodeNumber { get; set; }

            /// <summary>
            /// <para>Compute group specification type. Only standard is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("specType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>Disk performance level. Only pl1 is supported. Maximum random read/write IOPS per disk is 50,000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl1</para>
            /// </summary>
            [NameInMap("storagePerformanceLevel")]
            [Validation(Required=false)]
            public string StoragePerformanceLevel { get; set; }

            /// <summary>
            /// <para>Storage size in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("storageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

        }

        /// <summary>
        /// <para>Observer compute group information.</para>
        /// </summary>
        [NameInMap("ObserverNodeGroups")]
        [Validation(Required=false)]
        public List<QueryPriceV1RequestObserverNodeGroups> ObserverNodeGroups { get; set; }
        public class QueryPriceV1RequestObserverNodeGroups : TeaModel {
            /// <summary>
            /// <para>Number of CUs. A Compute Unit (CU) is the basic billing unit. One CU equals one vCPU plus 4 GiB of memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public string Cu { get; set; }

            /// <summary>
            /// <para>Number of disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("diskNumber")]
            [Validation(Required=false)]
            public int? DiskNumber { get; set; }

            /// <summary>
            /// <para>Local SSD instance type. Do not set this field for Observer compute groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("localStorageInstanceType")]
            [Validation(Required=false)]
            public string LocalStorageInstanceType { get; set; }

            /// <summary>
            /// <para>Number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("residentNodeNumber")]
            [Validation(Required=false)]
            public int? ResidentNodeNumber { get; set; }

            /// <summary>
            /// <para>Compute group specification type. Only standard is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("specType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>Disk performance level. Only pl1 is supported. Maximum random read/write IOPS per disk is 50,000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl1</para>
            /// </summary>
            [NameInMap("storagePerformanceLevel")]
            [Validation(Required=false)]
            public string StoragePerformanceLevel { get; set; }

            /// <summary>
            /// <para>Storage size in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("storageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

        }

        /// <summary>
        /// <para>Instance edition:</para>
        /// <list type="bullet">
        /// <item><description><para>Trial Edition (trial).</para>
        /// </description></item>
        /// <item><description><para>Standard Edition (official).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>official</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>Payment type:</para>
        /// <ol>
        /// <item><description><para>Subscription (prePaid).</para>
        /// </description></item>
        /// <item><description><para>Pay-as-you-go (postPaid).</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>prePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Subscription duration unit:</para>
        /// <list type="bullet">
        /// <item><description><para>Month (Month)</para>
        /// </description></item>
        /// <item><description><para>Year (Year)</para>
        /// </description></item>
        /// </list>
        /// <para>Valid only when PayType is prePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>Coupon ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_12378dfj6</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Cluster run mode:</para>
        /// <list type="bullet">
        /// <item><description><para>Shared-nothing (shared_nothing).</para>
        /// </description></item>
        /// <item><description><para>Shared-data (shared_data).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>shared_data</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

    }

}
