// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeCustomerGatewaysResponseBody : TeaModel {
        [NameInMap("CustomerGateways")]
        [Validation(Required=false)]
        public DescribeCustomerGatewaysResponseBodyCustomerGateways CustomerGateways { get; set; }
        public class DescribeCustomerGatewaysResponseBodyCustomerGateways : TeaModel {
            [NameInMap("CustomerGateway")]
            [Validation(Required=false)]
            public List<DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGateway> CustomerGateway { get; set; }
            public class DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGateway : TeaModel {
                [NameInMap("Asn")]
                [Validation(Required=false)]
                public long? Asn { get; set; }

                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("CustomerGatewayId")]
                [Validation(Required=false)]
                public string CustomerGatewayId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTags Tags { get; set; }
                public class DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTagsTag> Tag { get; set; }
                    public class DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E82612A9-CB90-4D7E-B394-1DB7F6509B29</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
