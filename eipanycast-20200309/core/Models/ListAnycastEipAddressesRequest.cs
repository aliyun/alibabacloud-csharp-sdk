// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class ListAnycastEipAddressesRequest : TeaModel {
        /// <summary>
        /// <para>The IP address that is allocated to the Anycast EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139.95.XX.XX</para>
        /// </summary>
        [NameInMap("AnycastEipAddress")]
        [Validation(Required=false)]
        public string AnycastEipAddress { get; set; }

        /// <summary>
        /// <para>The ID of the Anycast EIP.</para>
        /// <remarks>
        /// <para> To ensure the accuracy of the query result, we do not recommend that you specify <b>AnycastIds</b> and <b>AnycastId</b> at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aeip-2zeerraiwb7ujsxdc****</para>
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// <para>The IDs of Anycast EIPs.</para>
        /// <para>You can enter at most 50 Anycast EIP IDs.</para>
        /// <remarks>
        /// <para> To ensure the accuracy of the query result, we do not recommend that you specify <b>AnycastIds</b> and <b>AnycastId</b> at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AnycastIds")]
        [Validation(Required=false)]
        public List<string> AnycastIds { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud resources with which the Anycast EIPs are associated.</para>
        /// <para>You can enter at most 100 cloud resource IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2zebb08phyczzawe****</para>
        /// </summary>
        [NameInMap("BindInstanceIds")]
        [Validation(Required=false)]
        public List<string> BindInstanceIds { get; set; }

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
        /// <para>The billing method of the Anycast EIP.</para>
        /// <para>Set the value to <b>PostPaid</b>, which specifies the pay-as-you-go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The metering method of the Anycast EIP.</para>
        /// <para>Set the value to <b>PayByTraffic</b>, which specifies the pay-by-data-transfer metering method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>20 to 100</b>. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the Anycast EIP.</para>
        /// <para>The name must be 0 to 128 characters in length, and can contain digits, hyphens (-), and underscores (_). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of NextToken.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>Set the value to <b>international</b>, which specifies the regions outside the Chinese mainland.</para>
        /// 
        /// <b>Example:</b>
        /// <para>international</para>
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

        /// <summary>
        /// <para>The status of the Anycast EIP. Valid values:</para>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListAnycastEipAddressesRequestTags> Tags { get; set; }
        public class ListAnycastEipAddressesRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. You cannot specify empty strings as tag keys.</para>
            /// <para>The key can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The key must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. The key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para> You must specify at least one of <b>Tag.N</b> (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. It can be an empty string.</para>
            /// <para>The value cannot exceed 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). The value must start with a letter but cannot start with <c>aliyun</c> or <c>acs:</c>. The value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para> You must specify at least one of <b>Tag.N</b> (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
