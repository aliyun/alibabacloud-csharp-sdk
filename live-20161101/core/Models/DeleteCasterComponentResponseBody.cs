// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteCasterComponentResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio. You can use the ID as a request parameter in the API operation that is called to query the components in the production studio, add an episode list to the production studio, or modify a component in the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The component ID. You can use the ID as a request parameter in the API operation that is called to query the component in the production studio or modify the component in the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21926b36-7dd2-4fde-ae25-51b5bc8e****</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
