// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryAdvancedDomainListRequest : TeaModel {
        /// <summary>
        /// <para>Domain group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// <para>Sorting field based on lexicographic order of domain names. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Descending order  </description></item>
        /// <item><description><b>true</b>: Ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DomainNameSort")]
        [Validation(Required=false)]
        public bool? DomainNameSort { get; set; }

        /// <summary>
        /// <para>Domain status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: All.</description></item>
        /// <item><description><b>1</b>: Renewal required urgently.</description></item>
        /// <item><description><b>2</b>: Redemption required urgently.</description></item>
        /// <item><description><b>3</b>: Normal.</description></item>
        /// <item><description><b>4</b>: Transferring out from HiChina.</description></item>
        /// <item><description><b>5</b>: Registrant information being modified.</description></item>
        /// <item><description><b>6</b>: Identity verification not completed.</description></item>
        /// <item><description><b>7</b>: Review failed; re-initiate identity verification.</description></item>
        /// <item><description><b>8</b>: Under review.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public int? DomainStatus { get; set; }

        /// <summary>
        /// <para>End time for expiration date range query, represented as the number of milliseconds since 00:00:00 UTC on January 1, 1970.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndExpirationDate")]
        [Validation(Required=false)]
        public long? EndExpirationDate { get; set; }

        /// <summary>
        /// <para>End length for domain name length range query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EndLength")]
        [Validation(Required=false)]
        public int? EndLength { get; set; }

        /// <summary>
        /// <para>The end time of the registration date range query, expressed as the number of milliseconds since 00:00 on January 1, 1970, UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndRegistrationDate")]
        [Validation(Required=false)]
        public long? EndRegistrationDate { get; set; }

        /// <summary>
        /// <para>Excluded keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Excluded")]
        [Validation(Required=false)]
        public string Excluded { get; set; }

        /// <summary>
        /// <para>Keyword to exclude at the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExcludedPrefix")]
        [Validation(Required=false)]
        public bool? ExcludedPrefix { get; set; }

        /// <summary>
        /// <para>Keyword to exclude at the end.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExcludedSuffix")]
        [Validation(Required=false)]
        public bool? ExcludedSuffix { get; set; }

        /// <summary>
        /// <para>Sorting field based on expiration date. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Descending order.</description></item>
        /// <item><description><b>true</b>: Ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExpirationDateSort")]
        [Validation(Required=false)]
        public bool? ExpirationDateSort { get; set; }

        /// <summary>
        /// <para>Domain name composition information:  </para>
        /// <list type="bullet">
        /// <item><description><b>11</b>: Numeric-only domain name  </description></item>
        /// <item><description><b>12</b>: Letter-only domain name  </description></item>
        /// <item><description><b>13</b>: Mixed domain name (combination of letters and numbers)  </description></item>
        /// <item><description><b>14</b>: Chinese domain name</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Form")]
        [Validation(Required=false)]
        public int? Form { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain is a premium domain. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No  </description></item>
        /// <item><description><b>true</b>: Yes</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsPremiumDomain")]
        [Validation(Required=false)]
        public bool? IsPremiumDomain { get; set; }

        /// <summary>
        /// <para>Keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>Keyword at the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("KeyWordPrefix")]
        [Validation(Required=false)]
        public bool? KeyWordPrefix { get; set; }

        /// <summary>
        /// <para>Keyword at the end.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("KeyWordSuffix")]
        [Validation(Required=false)]
        public bool? KeyWordSuffix { get; set; }

        /// <summary>
        /// <para>The language of error messages returned by the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
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
        /// <para>Page number for paging. The minimum value is <b>0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Page size for paging. The minimum value is <b>1</b> and the maximum value is <b>200</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Domain name type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>New gTLD</b> (new top-level domain).</description></item>
        /// <item><description><b>gTLD</b> (generic top-level domain).</description></item>
        /// <item><description><b>ccTLD</b> (country code top-level domain).</description></item>
        /// <item><description><b>other</b> (other top-level domains not listed above).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gTLD</para>
        /// </summary>
        [NameInMap("ProductDomainType")]
        [Validation(Required=false)]
        public string ProductDomainType { get; set; }

        /// <summary>
        /// <para>Sorting field, used to sort by domain name type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Descending order.</description></item>
        /// <item><description><b>true</b>: Ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProductDomainTypeSort")]
        [Validation(Required=false)]
        public bool? ProductDomainTypeSort { get; set; }

        /// <summary>
        /// <para>Sorting field based on registration date. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Descending order.</description></item>
        /// <item><description><b>true</b>: Ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RegistrationDateSort")]
        [Validation(Required=false)]
        public bool? RegistrationDateSort { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw6bpc6n7zai</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Start time for expiration date range query, represented as the number of milliseconds since 00:00:00 UTC on January 1, 1970.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        /// <summary>
        /// <para>The starting length for domain name length range queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("StartLength")]
        [Validation(Required=false)]
        public int? StartLength { get; set; }

        /// <summary>
        /// <para>The start time of the registration date range query, expressed as the number of milliseconds since 00:00 on January 1, 1970, UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        /// <summary>
        /// <para>List of suffixes to query, separated by commas (&quot;,&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.cn</para>
        /// </summary>
        [NameInMap("Suffixs")]
        [Validation(Required=false)]
        public string Suffixs { get; set; }

        /// <summary>
        /// <para>List of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<QueryAdvancedDomainListRequestTag> Tag { get; set; }
        public class QueryAdvancedDomainListRequestTag : TeaModel {
            /// <summary>
            /// <para>Tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>数智</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>废弃</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Publishing status. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: Fixed-price listing published  </description></item>
        /// <item><description><b>13</b>: Negotiable-price listing published  </description></item>
        /// <item><description><b>4</b>: Auction listing published  </description></item>
        /// <item><description><b>6</b>: Priced push listing published  </description></item>
        /// <item><description><b>-1</b>: Domain trading not published</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("TradeType")]
        [Validation(Required=false)]
        public int? TradeType { get; set; }

        /// <summary>
        /// <para>User IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
