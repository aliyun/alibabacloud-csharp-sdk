// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ExportImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The URL that points to the exported image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oss.url">http://oss.url</a></para>
        /// </summary>
        [NameInMap("ExportedImageURL")]
        [Validation(Required=false)]
        public string ExportedImageURL { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43A426AD-3F2E-5DD9-9C08-D4DBDCA48D85</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
