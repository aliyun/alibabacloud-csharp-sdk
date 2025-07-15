// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetCustomTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{height:1080,scale:[16:9],gop:60,bframes:30,cdesc:h264}</para>
        /// </summary>
        [NameInMap("CustomTemplate")]
        [Validation(Required=false)]
        public string CustomTemplate { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC1E78D3-FA8B-4457-DEE2-6093E1232254</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestTemplate</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
