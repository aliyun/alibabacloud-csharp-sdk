// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePurchasedApiGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api group description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of domain names.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribePurchasedApiGroupResponseBodyDomains Domains { get; set; }
        public class DescribePurchasedApiGroupResponseBodyDomains : TeaModel {
            [NameInMap("DomainItem")]
            [Validation(Required=false)]
            public List<DescribePurchasedApiGroupResponseBodyDomainsDomainItem> DomainItem { get; set; }
            public class DescribePurchasedApiGroupResponseBodyDomainsDomainItem : TeaModel {
                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_domain.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48977d7b96074966a7c9c2a8872d7e06</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weather</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

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
        /// <para>The region where the API group is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61A16D46-EC04-5288-8A18-811B0F536CC2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
