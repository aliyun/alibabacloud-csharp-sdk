// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class ListAnycastEipAddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Anycast EIPs.</para>
        /// </summary>
        [NameInMap("AnycastList")]
        [Validation(Required=false)]
        public List<ListAnycastEipAddressesResponseBodyAnycastList> AnycastList { get; set; }
        public class ListAnycastEipAddressesResponseBodyAnycastList : TeaModel {
            /// <summary>
            /// <para>The ID of the account to which the Anycast EIP belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123440159596****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The list of cloud resources with which the Anycast EIPs are associated.</para>
            /// </summary>
            [NameInMap("AnycastEipBindInfoList")]
            [Validation(Required=false)]
            public List<ListAnycastEipAddressesResponseBodyAnycastListAnycastEipBindInfoList> AnycastEipBindInfoList { get; set; }
            public class ListAnycastEipAddressesResponseBodyAnycastListAnycastEipBindInfoList : TeaModel {
                /// <summary>
                /// <para>The ID of the cloud resource with which the Anycast EIP is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-2zebb08phyczzawe****</para>
                /// </summary>
                [NameInMap("BindInstanceId")]
                [Validation(Required=false)]
                public string BindInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the region where the cloud resource is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-west-1</para>
                /// </summary>
                [NameInMap("BindInstanceRegionId")]
                [Validation(Required=false)]
                public string BindInstanceRegionId { get; set; }

                /// <summary>
                /// <para>The type of cloud resource with which the Anycast EIP is associated.</para>
                /// <list type="bullet">
                /// <item><description><b>SlbInstance</b>: an internal-facing Classic Load Balancer (CLB) instance deployed in a virtual private cloud (VPC). CLB is formerly known as Server Load Balancer (SLB).</description></item>
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
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-23T01:37:38Z</para>
                /// </summary>
                [NameInMap("BindTime")]
                [Validation(Required=false)]
                public string BindTime { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Anycast EIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aeip-2zeerraiwb7ujsxdc****</para>
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
            /// <para>The service status of the Anycast EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b></description></item>
            /// <item><description><b>FinancialLocked</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The time when the Anycast EIP was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-22T01:37:38Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the Anycast EIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docdesc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The billing method of the Anycast EIP.</para>
            /// <para><b>PostPaid</b>: pay-as-you-go</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The metering method of the Anycast EIP.</para>
            /// <para><b>PayByTraffic</b>: pay-by-data-transfer</para>
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
            /// <para>The ID of the resource group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzthsmwsnfuni</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The access area of the Anycast EIP.</para>
            /// <para><b>international</b>: regions outside the Chinese mainland</para>
            /// 
            /// <b>Example:</b>
            /// <para>international</para>
            /// </summary>
            [NameInMap("ServiceLocation")]
            [Validation(Required=false)]
            public string ServiceLocation { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource is created by the service account.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no</description></item>
            /// <item><description><b>1</b>: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>Associating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The information about the tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListAnycastEipAddressesResponseBodyAnycastListTags> Tags { get; set; }
            public class ListAnycastEipAddressesResponseBodyAnycastListTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If <b>NextToken</b> is not empty, the value of NextToken can be used in the next request to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
