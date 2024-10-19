// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateBackendResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0d105f80a8f340408bd34954d4e4ff22</para>
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66D84355-164D-53ED-81FF-03DCF181DE24</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
