// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRoleAuthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the service-linked role for WAF is authorized.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The service-linked role is authorized.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The service-linked role is not authorized.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthStatus")]
        [Validation(Required=false)]
        public bool? AuthStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79ECBB08-079C-57C5-A676-***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
