// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetMcpCodePackageUploadUrlRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public GetMcpCodePackageUploadUrlRequestBody Body { get; set; }
        public class GetMcpCodePackageUploadUrlRequestBody : TeaModel {
            /// <summary>
            /// <para>The file name of the ZIP code package.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>server.zip</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

    }

}
