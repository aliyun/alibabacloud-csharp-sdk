// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetPreSignedUrlForPutObjectRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.txt</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

    }

}
