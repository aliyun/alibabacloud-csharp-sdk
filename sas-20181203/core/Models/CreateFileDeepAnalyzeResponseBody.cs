// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDeepAnalyzeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FileNotExist</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The analysis result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;result&quot;: 0,
        ///   &quot;file_analysis&quot;: {
        ///     &quot;summary&quot;: {
        ///       &quot;ai_interpretation&quot;: &quot;The file is a JetBrains PhpStorm stub generation tool script and is a legitimate developer tool. The code uses the PhpParser library to parse PHP source code and generate the PhpStormStubsMap.php mapping file. The DPI engine analysis did not detect any dangerous function invoke, external input processing, code obfuscation, or malicious behavior characteristics. The file is determined to be normal.&quot;
        ///     }
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The phase description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>File hash parsed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7F9C0A1-2B3D-4E5F-8A90-123456XXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The phase status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
