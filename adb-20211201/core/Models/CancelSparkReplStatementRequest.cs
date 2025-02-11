// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CancelSparkReplStatementRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/455888.html">ListSparkApps</a> operation to query Spark application IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s202411071444hzdvk486d9d2001****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>456</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public long? SessionId { get; set; }

        /// <summary>
        /// <para>The unique ID of the code block in the Spark job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("StatementId")]
        [Validation(Required=false)]
        public long? StatementId { get; set; }

    }

}
