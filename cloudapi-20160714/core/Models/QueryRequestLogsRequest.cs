// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class QueryRequestLogsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the request log.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95657ED9-2F6F-426F-BD99-79C8********</para>
        /// </summary>
        [NameInMap("RequestLogId")]
        [Validation(Required=false)]
        public string RequestLogId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
