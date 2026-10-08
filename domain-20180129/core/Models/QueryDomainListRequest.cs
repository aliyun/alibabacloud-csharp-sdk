// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainListRequest : TeaModel {
        [NameInMap("AutoRenewEnabled")]
        [Validation(Required=false)]
        public bool? AutoRenewEnabled { get; set; }

        /// <summary>
        /// <para>The name of the domain owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>广州金烨再生资源回收有限公司</para>
        /// </summary>
        [NameInMap("Ccompany")]
        [Validation(Required=false)]
        public string Ccompany { get; set; }

        [NameInMap("Dns")]
        [Validation(Required=false)]
        public string Dns { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the domain group. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/69362.html">QueryDomainGroupList</a> operation.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the domain group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public string DomainGroupId { get; set; }

        /// <summary>
        /// <para>The domain name to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the expiration date range. The value is a Unix timestamp in milliseconds. Currently, only queries by day are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndExpirationDate")]
        [Validation(Required=false)]
        public long? EndExpirationDate { get; set; }

        /// <summary>
        /// <para>The end of the registration date range. The value is a Unix timestamp in milliseconds. Currently, only queries by day are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndRegistrationDate")]
        [Validation(Required=false)]
        public long? EndRegistrationDate { get; set; }

        /// <summary>
        /// <para>The language for API error messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sort order for the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ASC</b>: Ascending.</para>
        /// </description></item>
        /// <item><description><para><b>DESC</b>: Descending.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <b>DESC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("OrderByType")]
        [Validation(Required=false)]
        public string OrderByType { get; set; }

        /// <summary>
        /// <para>The field to use for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RegistrationDate</b>: Sorts by registration date.</para>
        /// </description></item>
        /// <item><description><para><b>ExpirationDate</b>: Sorts by expiration date.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>By default, the results are sorted by the time they were added to the system.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RegistrationDate</para>
        /// </summary>
        [NameInMap("OrderKeyType")]
        [Validation(Required=false)]
        public string OrderKeyType { get; set; }

        /// <summary>
        /// <para>The page number for the paginated results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The domain type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>New gTLD</b>: new generic top-level domain.</para>
        /// </description></item>
        /// <item><description><para><b>gTLD</b>: generic top-level domain.</para>
        /// </description></item>
        /// <item><description><para><b>ccTLD</b>: country-code top-level domain.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>New gTLD</para>
        /// </summary>
        [NameInMap("ProductDomainType")]
        [Validation(Required=false)]
        public string ProductDomainType { get; set; }

        /// <summary>
        /// <para>The type of list to return. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Domain names that require urgent renewal.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Domain names that require urgent redemption.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("Registrar")]
        [Validation(Required=false)]
        public string Registrar { get; set; }

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
        /// <para>The start of the expiration date range. The value is a Unix timestamp in milliseconds. Currently, only queries by day are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        /// <summary>
        /// <para>The start of the registration date range. The value is a Unix timestamp in milliseconds. Currently, only queries by day are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        /// <summary>
        /// <para>A list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<QueryDomainListRequestTag> Tag { get; set; }
        public class QueryDomainListRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>备注</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标签1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The user\&quot;s client IP address. You can set this parameter to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
