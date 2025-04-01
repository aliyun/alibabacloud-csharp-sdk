// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class OpenStructOssSourceConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>demo-bucket</para>
        /// </summary>
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo-object</para>
        /// </summary>
        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

    }

}
