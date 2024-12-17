// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DeleteParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter template ID, which is globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sys-001*****</para>
        /// </summary>
        [NameInMap("ParamGroupId")]
        [Validation(Required=false)]
        public string ParamGroupId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BE6E619-A657-42E3-AD2D-18F8428A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
