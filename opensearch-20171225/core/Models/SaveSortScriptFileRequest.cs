// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class SaveSortScriptFileRequest : TeaModel {
        /// <summary>
        /// <para>The script content that is encoded in the Base64 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4769#0: *28194492991 a client request body is buffered to a temporary file /usr/local/webserver/openresty/nginx/client_body_temp/0000624474,</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The version number of the script content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-01</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
