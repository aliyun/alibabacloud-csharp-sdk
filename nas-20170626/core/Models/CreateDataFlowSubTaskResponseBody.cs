// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowSubTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the data streaming task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subTaskId-370kyfmyknxcyzw****</para>
        /// </summary>
        [NameInMap("DataFlowSubTaskId")]
        [Validation(Required=false)]
        public string DataFlowSubTaskId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A70BEE5D-76D3-49FB-B58F-1F398211A5C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
