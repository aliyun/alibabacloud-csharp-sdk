// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainVerifyDataRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. You can specify only one domain name in each request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.yourdomain.com">www.yourdomain.com</a></para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the global resource plan.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>off</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>on</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("GlobalResourcePlan")]
        [Validation(Required=false)]
        public string GlobalResourcePlan { get; set; }

    }

}
