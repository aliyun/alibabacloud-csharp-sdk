// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class MoveAppResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of resources that failed to be migrated.</para>
        /// </summary>
        [NameInMap("FailedResourceIds")]
        [Validation(Required=false)]
        public List<string> FailedResourceIds { get; set; }

        /// <summary>
        /// <para>The IDs of resources that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistResourceIds")]
        [Validation(Required=false)]
        public List<string> NonExistResourceIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
