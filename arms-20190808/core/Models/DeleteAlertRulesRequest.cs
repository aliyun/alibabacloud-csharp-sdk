// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteAlertRulesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the alert rules that you want to delete. The value is a JSON array, for example, <c>[123, 234]</c>. You can call the SearchAlertRules operation and view the <c>Id</c> parameter in the response to obtain the alert rule ID. For more information, see <a href="https://help.aliyun.com/document_detail/175825.html">SearchAlertRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[123, 234]</para>
        /// </summary>
        [NameInMap("AlertIds")]
        [Validation(Required=false)]
        public string AlertIds { get; set; }

        /// <summary>
        /// <para>The region ID. Default value: <c>cn-hangzhou</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
