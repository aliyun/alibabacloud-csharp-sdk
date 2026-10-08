// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckDomainRequest : TeaModel {
        /// <summary>
        /// <para>Domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test**.xin</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Operation command. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>create</b>: Purchase.  </description></item>
        /// <item><description><b>renew</b>: Renewal.  </description></item>
        /// <item><description><b>transfer</b>: Transfer-in.  </description></item>
        /// <item><description><b>restore</b>: Redeem.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>create</para>
        /// </summary>
        [NameInMap("FeeCommand")]
        [Validation(Required=false)]
        public string FeeCommand { get; set; }

        /// <summary>
        /// <para>Currency type. Valid value: <b>USD</b> (US Dollar).</para>
        /// 
        /// <b>Example:</b>
        /// <para>USD</para>
        /// </summary>
        [NameInMap("FeeCurrency")]
        [Validation(Required=false)]
        public string FeeCurrency { get; set; }

        /// <summary>
        /// <para>Registration period in years. Unit: <b>year</b>. Valid range: <b>1</b> to <b>10</b> years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeePeriod")]
        [Validation(Required=false)]
        public int? FeePeriod { get; set; }

        /// <summary>
        /// <para>Language of error messages returned by the API. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.  </description></item>
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

    }

}
