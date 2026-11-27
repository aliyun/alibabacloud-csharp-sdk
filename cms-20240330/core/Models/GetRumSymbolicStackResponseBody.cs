// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetRumSymbolicStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The column number restored by the JS SourceMap.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("column")]
        [Validation(Required=false)]
        public long? Column { get; set; }

        /// <summary>
        /// <para>The line number restored by the JS SourceMap.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("line")]
        [Validation(Required=false)]
        public long? Line { get; set; }

        /// <summary>
        /// <para>The list of symbolicated stack lines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;\tat com.example.UserService.getUser(UserService.java:25)&quot;]</para>
        /// </summary>
        [NameInMap("lines")]
        [Validation(Required=false)]
        public List<string> Lines { get; set; }

        /// <summary>
        /// <para>The symbol name restored by the JS SourceMap.</para>
        /// 
        /// <b>Example:</b>
        /// <para>handleClick</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source file path restored by the JS SourceMap.</para>
        /// 
        /// <b>Example:</b>
        /// <para>src/app.js</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ID of the exception thread.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main-thread</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <para>The list of source code context lines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;line1&quot;]</para>
        /// </summary>
        [NameInMap("traceInfo")]
        [Validation(Required=false)]
        public List<string> TraceInfo { get; set; }

        /// <summary>
        /// <para>The highlighted line number of the error line in traceInfo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("traceMarkLine")]
        [Validation(Required=false)]
        public long? TraceMarkLine { get; set; }

    }

}
