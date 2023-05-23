// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCensRequest : TeaModel {
        /// <summary>
        /// The key of the tag.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeCensRequestFilter> Filter { get; set; }
        public class DescribeCensRequestFilter : TeaModel {
            /// <summary>
            /// The name of the CEN instance.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The time when the CEN instance was created.
            /// 
            /// The time follows the ISO8601 standard in the `YYYY-MM-DDThh:mmZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The value of the filter condition.
        /// 
        /// This parameter sets the value of a filter **key**. You can specify multiple values for a filter **key**. The logical operator among multiple filter values is **OR**. If a CEN instance matches one or more of the values that you specify, the CEN instance matches the filter condition.
        /// 
        /// You can specify at most five values in each filter condition.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **50**. Default value: **10**.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCensRequestTag> Tag { get; set; }
        public class DescribeCensRequestTag : TeaModel {
            /// <summary>
            /// The list of the filter conditions.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The description of the CEN instance.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
