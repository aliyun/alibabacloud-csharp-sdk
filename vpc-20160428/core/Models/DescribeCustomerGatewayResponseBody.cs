// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeCustomerGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The autonomous system number of the on-premises data center gateway device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65535</para>
        /// </summary>
        [NameInMap("Asn")]
        [Validation(Required=false)]
        public long? Asn { get; set; }

        /// <summary>
        /// <para>The authentication key of the BGP routing protocol for the on-premises data center gateway device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AuthKey****</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>The timestamp when the customer gateway was created. Unit: milliseconds.</para>
        /// <para>The timestamp is in the UNIX format and represents the total number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC to the time when the customer gateway was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1492747187000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The instance ID of the customer gateway.</para>
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
        /// <para>The IP address of the on-premises data center gateway device.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A0457BC9-6C0F-4437-AB9D-FB2EABC1D6A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the customer gateway belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query resource group information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzs372yg****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeCustomerGatewayResponseBodyTags Tags { get; set; }
        public class DescribeCustomerGatewayResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeCustomerGatewayResponseBodyTagsTag> Tag { get; set; }
            public class DescribeCustomerGatewayResponseBodyTagsTag : TeaModel {
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
