// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetPreSignedUrlForPutObjectHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a9c3a20210af000</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
