// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterComponentResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the component. You can use the ID as a request parameter in the API operation that is called to query components in a production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05ab713c-676e-49c0-96ce-cc408da1****</para>
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
