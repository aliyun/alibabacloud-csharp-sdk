// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteAppInfoRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can obtain the value from the AppId response parameter returned by the <a href="https://help.aliyun.com/document_detail/113266.html">Create an application</a> or <a href="https://help.aliyun.com/document_detail/114000.html">List applications</a> API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
