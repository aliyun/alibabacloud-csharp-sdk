// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryContactInfoRequest : TeaModel {
        /// <summary>
        /// <para>The contact type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>registrant</b>: Domain name registrant.  </description></item>
        /// <item><description><b>tech</b>: Technical contact.  </description></item>
        /// <item><description><b>admin</b>: Administrative contact.  </description></item>
        /// <item><description><b>billing</b>: Billing contact.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("ContactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

        /// <summary>
        /// <para>Domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

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
