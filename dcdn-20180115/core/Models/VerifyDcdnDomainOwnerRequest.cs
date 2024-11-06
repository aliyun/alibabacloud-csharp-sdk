// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class VerifyDcdnDomainOwnerRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of which you want to verify the ownership. You can specify only one domain name in each call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b>example</b>.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The verification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dnsCheck</b>: by DNS record</description></item>
        /// <item><description><b>fileCheck</b>: by verification file</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dnsCheck</para>
        /// </summary>
        [NameInMap("VerifyType")]
        [Validation(Required=false)]
        public string VerifyType { get; set; }

    }

}
