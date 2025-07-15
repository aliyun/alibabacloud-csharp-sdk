// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterVideoResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF60DB6A-7FD6-426E-9288-122CC1A52FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource. This parameter can be used as a request parameter in the API operation that you can call to delete the video source in the production studio or modify the video source in the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e5542d98-b08c-46bf-83e9-5b09d08c****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
