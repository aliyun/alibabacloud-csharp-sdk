// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryAdvancedDomainListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DomainNameSort")]
        [Validation(Required=false)]
        public bool? DomainNameSort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public int? DomainStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndExpirationDate")]
        [Validation(Required=false)]
        public long? EndExpirationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EndLength")]
        [Validation(Required=false)]
        public int? EndLength { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndRegistrationDate")]
        [Validation(Required=false)]
        public long? EndRegistrationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Excluded")]
        [Validation(Required=false)]
        public string Excluded { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExcludedPrefix")]
        [Validation(Required=false)]
        public bool? ExcludedPrefix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExcludedSuffix")]
        [Validation(Required=false)]
        public bool? ExcludedSuffix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExpirationDateSort")]
        [Validation(Required=false)]
        public bool? ExpirationDateSort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Form")]
        [Validation(Required=false)]
        public int? Form { get; set; }

        [NameInMap("IsPremiumDomain")]
        [Validation(Required=false)]
        public bool? IsPremiumDomain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("KeyWordPrefix")]
        [Validation(Required=false)]
        public bool? KeyWordPrefix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("KeyWordSuffix")]
        [Validation(Required=false)]
        public bool? KeyWordSuffix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gTLD</para>
        /// </summary>
        [NameInMap("ProductDomainType")]
        [Validation(Required=false)]
        public string ProductDomainType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProductDomainTypeSort")]
        [Validation(Required=false)]
        public bool? ProductDomainTypeSort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RegistrationDateSort")]
        [Validation(Required=false)]
        public bool? RegistrationDateSort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmw6bpc6n7zai</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("StartLength")]
        [Validation(Required=false)]
        public int? StartLength { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>com.cn</para>
        /// </summary>
        [NameInMap("Suffixs")]
        [Validation(Required=false)]
        public string Suffixs { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<QueryAdvancedDomainListRequestTag> Tag { get; set; }
        public class QueryAdvancedDomainListRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("TradeType")]
        [Validation(Required=false)]
        public int? TradeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
