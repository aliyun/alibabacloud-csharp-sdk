// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class DeleteSavedQueryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the template.</para>
        /// <para>You can call the <a href="~~ListSavedQueries~~">ListSavedQueries</a> operation to obtain the template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sq-GeAck****</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

    }

}
