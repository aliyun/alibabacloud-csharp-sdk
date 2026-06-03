// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class QueryDomainListRequest : TeaModel {
        [NameInMap("Ccompany")]
        [Validation(Required=false)]
        public string Ccompany { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndExpirationDate")]
        [Validation(Required=false)]
        public long? EndExpirationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndRegistrationDate")]
        [Validation(Required=false)]
        public long? EndRegistrationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("OrderByType")]
        [Validation(Required=false)]
        public string OrderByType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ExpirationDate</para>
        /// </summary>
        [NameInMap("OrderKeyType")]
        [Validation(Required=false)]
        public string OrderKeyType { get; set; }

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
        /// <para>50</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("StartExpirationDate")]
        [Validation(Required=false)]
        public long? StartExpirationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("StartRegistrationDate")]
        [Validation(Required=false)]
        public long? StartRegistrationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
