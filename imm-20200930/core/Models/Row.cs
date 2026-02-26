// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Row : TeaModel {
        /// <summary>
        /// <para>The custom labels.</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public List<KeyValuePair> CustomLabels { get; set; }

        /// <summary>
        /// <para>The OSS URI of the file.</para>
        /// <para>The OSS URI is in the <c>oss://${bucketname}/${objectname}</c> format, where <c>${bucketname}</c> is the name of the OSS bucket that is in the same region as the current project and <c>${objectname}</c> is the path of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/exampleobject.jpg</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
