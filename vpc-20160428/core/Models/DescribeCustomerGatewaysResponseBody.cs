// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeCustomerGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about customer gateways.</para>
        /// </summary>
        [NameInMap("CustomerGateways")]
        [Validation(Required=false)]
        public DescribeCustomerGatewaysResponseBodyCustomerGateways CustomerGateways { get; set; }
        public class DescribeCustomerGatewaysResponseBodyCustomerGateways : TeaModel {
            [NameInMap("CustomerGateway")]
            [Validation(Required=false)]
            public List<DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGateway> CustomerGateway { get; set; }
            public class DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGateway : TeaModel {
                /// <summary>
                /// <para>The autonomous system number (ASN) of the gateway device in the data center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65530</para>
                /// </summary>
                [NameInMap("Asn")]
                [Validation(Required=false)]
                public long? Asn { get; set; }

                /// <summary>
                /// <para>The authentication key that is used to connect to the gateway device in the data center by using Border Gateway Protocol (BGP).</para>
                /// 
                /// <b>Example:</b>
                /// <para>AuthKey****</para>
                /// </summary>
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

                /// <summary>
                /// <para>The time when the customer gateway was created. Unit: millisecond.</para>
                /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1492747187000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The customer gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cgw-bp1pvpl9r9adju6l5****</para>
                /// </summary>
                [NameInMap("CustomerGatewayId")]
                [Validation(Required=false)]
                public string CustomerGatewayId { get; set; }

                /// <summary>
                /// <para>The description of the customer gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desctest</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The IP address of the gateway device in the data center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>139.32.XX.XX</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The name of the customer gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nametest</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the customer gateway belongs.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzs372yg****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The tags that are added to the customer gateway.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTags Tags { get; set; }
                public class DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTagsTag> Tag { get; set; }
                    public class DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TagKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TagValue</para>
                        /// </summary>
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
