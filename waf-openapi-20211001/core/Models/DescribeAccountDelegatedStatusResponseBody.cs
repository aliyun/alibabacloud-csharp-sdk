// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAccountDelegatedStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10***********34</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud account. This parameter is returned only if the account is a delegated administrator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account_test</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>Indicates whether the account is a delegated administrator for WAF.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The account is a delegated administrator.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The account is not a delegated administrator.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DelegatedStatus")]
        [Validation(Required=false)]
        public bool? DelegatedStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8161375D-5958-5627-BFDE-DF1458A73E87</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
