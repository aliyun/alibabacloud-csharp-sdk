// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAppInfosRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of applications. You can obtain application IDs from the response to the <a href="https://help.aliyun.com/document_detail/113266.html">CreateAppInfo</a> or <a href="https://help.aliyun.com/document_detail/114000.html">ListAppInfo</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a maximum of 10 application IDs.</description></item>
        /// <item><description>Separate application IDs with commas (,).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

    }

}
