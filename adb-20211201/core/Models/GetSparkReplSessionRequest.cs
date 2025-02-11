// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkReplSessionRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/455888.html">ListSparkApps</a> operation to query all application IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s202411071444hzdvk486d9d200****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the session that executes the code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public long? SessionId { get; set; }

    }

}
