// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ScrollDomainListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the domain name group. You can call the <a href="https://help.aliyun.com/document_detail/69362.html">QueryDomainGroupList</a> operation to obtain the ID of the domain name group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// <para>The status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: All.</description></item>
        /// <item><description><b>1</b>: The domain name needs to be renewed.</description></item>
        /// <item><description><b>2</b>: The domain name needs to be redeemed.</description></item>
        /// <item><description><b>3</b>: The domain name is normal.</description></item>
        /// <item><description><b>4</b>: The domain name is being transferred from Alibaba Cloud.</description></item>
        /// <item><description><b>5</b>: The information about the domain name registrant is being modified.</description></item>
        /// <item><description><b>6</b>: Real-name verification is not performed on the domain name.</description></item>
        /// <item><description><b>7</b>: Real-name verification for the domain name fails. Real-name reverification is required.</description></item>
        /// <item><description><b>8</b>: The domain name is being reviewed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public int? DomainStatus { get; set; }

        /// <summary>
        /// <para>The end of the time range to query domain names based on expiration dates. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1541520000000</para>
        /// </summary>
        [NameInMap("EndExpirationDate")]
        [Validation(Required=false)]
        public long? EndExpirationDate { get; set; }

        /// <summary>
        /// <para>The end of domain name length to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EndLength")]
        [Validation(Required=false)]
        public int? EndLength { get; set; }

        /// <summary>
        /// <para>The end of the time range to query domain names based on registration dates. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1541520000000</para>
        /// </summary>
        [NameInMap("EndRegistrationDate")]
        [Validation(Required=false)]
        public long? EndRegistrationDate { get; set; }

        /// <summary>
        /// <para>The keyword that is used to exclude domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Excluded")]
        [Validation(Required=false)]
        public string Excluded { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude the prefix keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExcludedPrefix")]
        [Validation(Required=false)]
        public bool? ExcludedPrefix { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude the suffix keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExcludedSuffix")]
        [Validation(Required=false)]
        public bool? ExcludedSuffix { get; set; }

        /// <summary>
        /// <para>The composition of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Form")]
        [Validation(Required=false)]
        public int? Form { get; set; }

        /// <summary>
        /// <para>The keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>Specifies whether the keyword is the prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("KeyWordPrefix")]
        [Validation(Required=false)]
        public bool? KeyWordPrefix { get; set; }

        /// <summary>
        /// <para>Specifies whether the keyword is the suffix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("KeyWordSuffix")]
        [Validation(Required=false)]
        public bool? KeyWordSuffix { get; set; }

        /// <summary>
        /// <para>The language of the error message to return if the request fails. Valid values:</para>
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>New gTLD</b></description></item>
        /// <item><description><b>gTLD</b></description></item>
        /// <item><description><b>ccTLD</b></description></item>
        /// <item><description><b>other</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gTLD</para>
        /// </summary>
        [NameInMap("ProductDomainType")]
        [Validation(Required=false)]
        public string ProductDomainType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw6bpc6n7zai</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The scroll ID. This parameter is a technical parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ScrollId")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query domain names based on expiration dates. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1541520000000</para>
        /// </summary>
        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        /// <summary>
        /// <para>The start of the domain name length to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartLength")]
        [Validation(Required=false)]
        public int? StartLength { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query domain names based on registration dates. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1541520000000</para>
        /// </summary>
        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        /// <summary>
        /// <para>The suffixes of domain names to be queried. Separate multiple suffixes with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>com</para>
        /// </summary>
        [NameInMap("Suffixs")]
        [Validation(Required=false)]
        public string Suffixs { get; set; }

        /// <summary>
        /// <para>The publishing status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: The domain name is published at a fixed price.</description></item>
        /// <item><description><b>3</b>: The domain name is published with the price negotiable.</description></item>
        /// <item><description><b>4</b>: The domain name is published for bidding.</description></item>
        /// <item><description><b>6</b>: The domain name is published with price push.</description></item>
        /// <item><description><b>-1</b>: The domain name is not published.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("TradeType")]
        [Validation(Required=false)]
        public int? TradeType { get; set; }

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
