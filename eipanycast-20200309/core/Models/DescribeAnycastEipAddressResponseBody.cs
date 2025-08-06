// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastEipAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the account to which the Anycast EIP belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25346073170691****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The information about the endpoint with which the Anycast EIP is associated.</para>
        /// </summary>
        [NameInMap("AnycastEipBindInfoList")]
        [Validation(Required=false)]
        public List<DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoList> AnycastEipBindInfoList { get; set; }
        public class DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoList : TeaModel {
            /// <summary>
            /// <para>The association mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Default</b>: the default mode. In this mode, the associated endpoint serves as the default origin server.</description></item>
            /// <item><description><b>Normal</b>: the standard mode. In this mode, the associated endpoint serves as a standard origin server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("AssociationMode")]
            [Validation(Required=false)]
            public string AssociationMode { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint with which the Anycast EIP is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-2zebb08phyczzawe****</para>
            /// </summary>
            [NameInMap("BindInstanceId")]
            [Validation(Required=false)]
            public string BindInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the endpoint is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-west-1</para>
            /// </summary>
            [NameInMap("BindInstanceRegionId")]
            [Validation(Required=false)]
            public string BindInstanceRegionId { get; set; }

            /// <summary>
            /// <para>The type of endpoint with which the Anycast EIP is associated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SlbInstance</b>: a CLB instance in a VPC.</description></item>
            /// <item><description><b>NetworkInterface</b>: an elastic network interface (ENI).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SlbInstance</para>
            /// </summary>
            [NameInMap("BindInstanceType")]
            [Validation(Required=false)]
            public string BindInstanceType { get; set; }

            /// <summary>
            /// <para>The time when the Anycast EIP was associated.</para>
            /// <para>The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-23T02:37:38Z</para>
            /// </summary>
            [NameInMap("BindTime")]
            [Validation(Required=false)]
            public string BindTime { get; set; }

            /// <summary>
            /// <para>The information about the access points in associated access areas when you associate an Anycast EIP with a cloud resource.</para>
            /// <para>If this is your first time associating an Anycast EIP with an endpoint, the system returns information about access points in all access areas.</para>
            /// </summary>
            [NameInMap("PopLocations")]
            [Validation(Required=false)]
            public List<DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoListPopLocations> PopLocations { get; set; }
            public class DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoListPopLocations : TeaModel {
                /// <summary>
                /// <para>The information about the access points in associated access areas when you associate an Anycast EIP with a cloud resource.</para>
                /// <para>If this is your first time associating an Anycast EIP with an endpoint, the system returns information about access points in all access areas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-west-1-pop</para>
                /// </summary>
                [NameInMap("PopLocation")]
                [Validation(Required=false)]
                public string PopLocation { get; set; }

            }

            /// <summary>
            /// <para>The secondary private IP address of the associated ENI.</para>
            /// <para>This parameter is valid only when <b>BindInstanceType</b> is set to <b>NetworkInterface</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// <para>The status of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BINDING</b></description></item>
            /// <item><description><b>BINDED</b></description></item>
            /// <item><description><b>UNBINDING</b></description></item>
            /// <item><description><b>DELETED</b></description></item>
            /// <item><description><b>MODIFYING</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BINDING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Anycast EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aeip-bp1ix34fralt4ykf3****</para>
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the Anycast EIP. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The BID of the account to which the Anycast EIP belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26842</para>
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        /// <summary>
        /// <para>The status of the Anycast EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: running as expected</description></item>
        /// <item><description><b>FinancialLocked</b>: locked due to overdue payments</description></item>
        /// <item><description><b>RiskExpired</b>: locked due to security reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The point in time at which the Anycast EIP was created.</para>
        /// <para>The time follows the ISO8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-23T01:37:38Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the Anycast EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The billing method of the Anycast EIP.</para>
        /// <para>Only <b>PostPaid</b> may be returned, which indicates the pay-as-you-go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The metering method of the Anycast EIP.</para>
        /// <para>Only <b>PayByTraffic</b> may be returned, which indicates the pay-by-data-transfer metering method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The IP address of the Anycast EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139.95.XX.XX</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The name of the Anycast EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>docname</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzssisocarfy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The access area of the Anycast EIP.</para>
        /// <para>Only <b>international</b> may be returned, which indicates the areas outside the Chinese mainland.</para>
        /// 
        /// <b>Example:</b>
        /// <para>international</para>
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is managed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public int? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The status of the Anycast EIP.</para>
        /// <list type="bullet">
        /// <item><description><b>Associating</b></description></item>
        /// <item><description><b>Unassociating</b></description></item>
        /// <item><description><b>Allocated</b></description></item>
        /// <item><description><b>Associated</b></description></item>
        /// <item><description><b>Modifying</b></description></item>
        /// <item><description><b>Releasing</b></description></item>
        /// <item><description><b>Released</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Associated</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The information about the tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeAnycastEipAddressResponseBodyTags> Tags { get; set; }
        public class DescribeAnycastEipAddressResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
