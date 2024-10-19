// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ExportOASResponseBody : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded data of the exported Swagger file. You can obtain the file by using Base64 decoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UEsDBBQACAAIAABc8FgAAAAAAAAAAAAAAAA...</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876xxxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
