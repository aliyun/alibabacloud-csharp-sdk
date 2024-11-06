// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DeleteDcdnUserConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the user feature that you want to delete. Currently, only DCDN Web Application Firewall (WAF) can be deleted. Default value: waf.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf</para>
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

    }

}
