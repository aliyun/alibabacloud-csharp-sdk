// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceModificationPriceRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribeInstanceModificationPriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribeInstanceModificationPriceRequestSystemDisk : TeaModel {
            /// <summary>
            /// $.parameters[6].schema.enumValueTitles
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

        }

        /// <summary>
        /// $.parameters[2].schema.description
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribeInstanceModificationPriceRequestDataDisk> DataDisk { get; set; }
        public class DescribeInstanceModificationPriceRequestDataDisk : TeaModel {
            /// <summary>
            /// $.parameters[4].schema.description
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// $.parameters[2].schema.example
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// $.parameters[2].schema.enumValueTitles
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// $.parameters[6].schema.description
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// $.parameters[6].schema.example
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// $.parameters[6].schema.items.enumValueTitles
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
