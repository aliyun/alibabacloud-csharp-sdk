// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class StartAlertRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert rule. You can call the SearchAlertRules operation and view the <c>Id</c> parameter in the response. For more information, see <a href="https://help.aliyun.com/document_detail/175825.html">SearchAlertRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1610***</para>
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public string AlertId { get; set; }

        /// <summary>
        /// <para>The ID of the region. Set the value to <c>cn-hangzhou</c>.</para>
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
