// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetManagedRuleRequest : TeaModel {
        /// <summary>
        /// <para>The identifier of the managed rule.</para>
        /// <para>For more information about how to obtain the identifier of a managed rule, see <a href="https://help.aliyun.com/document_detail/421144.html">ListManagedRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cdn-domain-https-enabled</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
