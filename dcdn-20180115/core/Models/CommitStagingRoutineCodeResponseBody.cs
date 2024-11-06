// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CommitStagingRoutineCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The version number of the code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620876959997924701</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CC228B4-7A67-4016-9C9F-4A4133494A91</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
