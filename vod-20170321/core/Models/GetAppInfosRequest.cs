// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAppInfosRequest : TeaModel {
        /// <summary>
        /// <para>The list of application IDs. The list consists of one or more application IDs. An application ID is the value of the AppId parameter returned by the <a href="https://help.aliyun.com/document_detail/113266.html">CreateAppInfo</a> or <a href="https://help.aliyun.com/document_detail/114000.html">GetAppInfos</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>A maximum of 10 IDs are supported.</description></item>
        /// <item><description>Separate multiple IDs with commas (,).</description></item>
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
