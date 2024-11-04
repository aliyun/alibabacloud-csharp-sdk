// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DetachGatewayDomainRequest : TeaModel {
        /// <summary>
        /// <para>The custom domain name information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CustomDomain")]
        [Validation(Required=false)]
        public DetachGatewayDomainRequestCustomDomain CustomDomain { get; set; }
        public class DetachGatewayDomainRequestCustomDomain : TeaModel {
            /// <summary>
            /// <para>The custom domain name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The domain name type.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>intranet: internal network.</description></item>
            /// <item><description>internet: public network.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
