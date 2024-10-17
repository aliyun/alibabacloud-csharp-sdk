// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteEditingProjectsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the online editing project. You can specify multiple IDs separated with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>fb2101bf24bf41cb318787dc</b></b>,<b><b>87dcfb2101bf24bf41cb3187</b></b></para>
        /// </summary>
        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public string ProjectIds { get; set; }

    }

}
