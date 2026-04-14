// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePurchasedApiGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PurchasedApiGroupAttributes")]
        [Validation(Required=false)]
        public DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributes PurchasedApiGroupAttributes { get; set; }
        public class DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributes : TeaModel {
            [NameInMap("PurchasedApiGroupAttribute")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributesPurchasedApiGroupAttribute> PurchasedApiGroupAttribute { get; set; }
            public class DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributesPurchasedApiGroupAttribute : TeaModel {
                [NameInMap("BillingType")]
                [Validation(Required=false)]
                public string BillingType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("InvokeTimesMax")]
                [Validation(Required=false)]
                public long? InvokeTimesMax { get; set; }

                [NameInMap("InvokeTimesNow")]
                [Validation(Required=false)]
                public long? InvokeTimesNow { get; set; }

                [NameInMap("PurchasedTime")]
                [Validation(Required=false)]
                public string PurchasedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36BBBAD4-1CFB-489F-841A-8CA52EEA787E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
