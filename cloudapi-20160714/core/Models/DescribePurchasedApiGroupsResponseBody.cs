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

        /// <summary>
        /// <para>The attributes of the API group.</para>
        /// </summary>
        [NameInMap("PurchasedApiGroupAttributes")]
        [Validation(Required=false)]
        public DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributes PurchasedApiGroupAttributes { get; set; }
        public class DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributes : TeaModel {
            [NameInMap("PurchasedApiGroupAttribute")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributesPurchasedApiGroupAttribute> PurchasedApiGroupAttribute { get; set; }
            public class DescribePurchasedApiGroupsResponseBodyPurchasedApiGroupAttributesPurchasedApiGroupAttribute : TeaModel {
                /// <summary>
                /// <para>The billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>POSTPAID</para>
                /// </summary>
                [NameInMap("BillingType")]
                [Validation(Required=false)]
                public string BillingType { get; set; }

                /// <summary>
                /// <para>The description of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the API group expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-19T00:00:00</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The ID of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8e91f23f88f94348855b82c9a73209f3</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group1</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The maximum number of calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("InvokeTimesMax")]
                [Validation(Required=false)]
                public long? InvokeTimesMax { get; set; }

                /// <summary>
                /// <para>The current number of calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("InvokeTimesNow")]
                [Validation(Required=false)]
                public long? InvokeTimesNow { get; set; }

                /// <summary>
                /// <para>The time when the API group was purchased.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-19T00:00:00</para>
                /// </summary>
                [NameInMap("PurchasedTime")]
                [Validation(Required=false)]
                public string PurchasedTime { get; set; }

                /// <summary>
                /// <para>The ID of the region where the API group is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status of the API group.</para>
                /// <list type="bullet">
                /// <item><description><b>NORMAL</b>: The API group is normal.</description></item>
                /// <item><description><b>DELETE</b>: The API group is deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
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
