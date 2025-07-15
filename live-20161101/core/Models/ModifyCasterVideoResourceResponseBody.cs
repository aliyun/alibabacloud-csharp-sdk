// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterVideoResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio. This parameter is used in the requests of the following operations: DescribeCasterVideoResources, AddCasterLayout, and DescribeCasterLayouts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

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
        /// <para>The ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98461064-1c94-4dc1-85ce-94098764****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
