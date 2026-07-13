// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeTransferDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The domain name. Use this parameter to query the transfer records of a specific domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.top</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the source account. Use this parameter to query the list of domain names transferred from this account to the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1*******</para>
        /// </summary>
        [NameInMap("FromUserId")]
        [Validation(Required=false)]
        public long? FromUserId { get; set; }

        /// <summary>
        /// <para>The language of the response.</para>
        /// <para>Valid values:</para>
        /// <para>zh: Chinese</para>
        /// <para>en: English</para>
        /// <para>The default value is zh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the destination account. Use this parameter to query the list of domain names transferred from the current account to this account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1*******</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

        /// <summary>
        /// <para>The type of transfer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IN: The list of domain names transferred to the current account.</para>
        /// </description></item>
        /// <item><description><para>OUT: The list of domain names transferred from the current account.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IN</para>
        /// </summary>
        [NameInMap("TransferType")]
        [Validation(Required=false)]
        public string TransferType { get; set; }

    }

}
