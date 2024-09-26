// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetAlertMessageRequest : TeaModel {
        /// <summary>
        /// <para>The alert ID. You can all the <a href="https://help.aliyun.com/document_detail/173961.html">ListAlertMessages</a> operation to obtain the alert ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1421</para>
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public string AlertId { get; set; }

    }

}
