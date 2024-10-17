// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetEditingProjectRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the online editing project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>fb2101bf24b2754cb318787dc</b></b></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The ID of the request source. Valid values:</para>
        /// <para>\- OpenAPI (default): Timeline conversion is not performed.</para>
        /// <para>\- WebSDK: If you specify this value, the project timeline is automatically converted into the frontend style, and the materials in the timeline are associated with the project to enable preview by using frontend web SDKs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebSDK</para>
        /// </summary>
        [NameInMap("RequestSource")]
        [Validation(Required=false)]
        public string RequestSource { get; set; }

    }

}
