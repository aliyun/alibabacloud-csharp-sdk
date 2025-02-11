// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ExecuteSparkReplStatementRequest : TeaModel {
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
        /// <para>The code that you want to execute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>print(1+1)</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The language type of the code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SCALA</description></item>
        /// <item><description>PYTHON</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PYTHON</para>
        /// </summary>
        [NameInMap("CodeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        /// <summary>
        /// <para>The ID of the session that you want to use to execute the code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public long? SessionId { get; set; }

    }

}
