// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainListRequest : TeaModel {
        /// <summary>
        /// <para>The name of the domain name registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Guangzhou Jinye Renewable Resources Recycling Co., Ltd</para>
        /// </summary>
        [NameInMap("Ccompany")]
        [Validation(Required=false)]
        public string Ccompany { get; set; }

        /// <summary>
        /// <para>The ID of the domain name group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public string DomainGroupId { get; set; }

        /// <summary>
        /// <para>The domain name that you want to search for.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query domain names based on expiration dates. Set the value to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Only queries by day are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndExpirationDate")]
        [Validation(Required=false)]
        public long? EndExpirationDate { get; set; }

        /// <summary>
        /// <para>The end of the time range to query domain names based on registration dates. Set the value to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Only queries by day are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndRegistrationDate")]
        [Validation(Required=false)]
        public long? EndRegistrationDate { get; set; }

        /// <summary>
        /// <para>The language of the error message to return if the request fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The order of the information based on which the domain names are sorted, such as the registration date and expiration date. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b>: ascending order</description></item>
        /// <item><description><b>DESC</b>: descending order</description></item>
        /// </list>
        /// <remarks>
        /// <para> If this parameter is not specified, the default value <b>DESC</b> is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("OrderByType")]
        [Validation(Required=false)]
        public string OrderByType { get; set; }

        /// <summary>
        /// <para>The field that you use to sort the domain names. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RegistrationDate</b>: registration date</description></item>
        /// <item><description><b>ExpirationDate</b>: expiration date</description></item>
        /// </list>
        /// <remarks>
        /// <para> If this parameter is not specified, the domain names are sorted by the time when they were added to the database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RegistrationDate</para>
        /// </summary>
        [NameInMap("OrderKeyType")]
        [Validation(Required=false)]
        public string OrderKeyType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>New gTLD</b>: new generic top-level domain names</description></item>
        /// <item><description><b>gTLD</b>: generic top-level domain names</description></item>
        /// <item><description><b>ccTLD</b>: country code top-level domain names</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>New gTLD</para>
        /// </summary>
        [NameInMap("ProductDomainType")]
        [Validation(Required=false)]
        public string ProductDomainType { get; set; }

        /// <summary>
        /// <para>The category of the domain names that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: the domain names that need to be renewed</description></item>
        /// <item><description><b>2</b>: the domain names that need to be redeemed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2indvyxgpfti</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query domain names based on expiration dates. Set the value to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Only queries by day are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query domain names based on registration dates. Set the value to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Only queries by day are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        /// <summary>
        /// <para>The tags to add to the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<QueryDomainListRequestTag> Tag { get; set; }
        public class QueryDomainListRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag to add to the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag to add to the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The IP address of the client. Set the value to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
