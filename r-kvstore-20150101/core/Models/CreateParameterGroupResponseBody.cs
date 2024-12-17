// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-51ii2ienn0dg0xi8****</para>
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62DA5BE5-F9C9-527C-ACCB-4D783C297A3A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
