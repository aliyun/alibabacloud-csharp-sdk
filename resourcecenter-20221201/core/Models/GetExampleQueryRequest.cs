// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetExampleQueryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the template.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListExampleQueries~~">ListExampleQueries</a> operation to obtain the template ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sq-0PfKy****</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

    }

}
