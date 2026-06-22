// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEmgUserAgreementResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the emergency vulnerability scan is authorized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Authorized.</description></item>
        /// <item><description><b>false</b>: Not authorized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Auth")]
        [Validation(Required=false)]
        public bool? Auth { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>768BB9F5-8AF3-557F-A489-9BDD64CB3E4C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
