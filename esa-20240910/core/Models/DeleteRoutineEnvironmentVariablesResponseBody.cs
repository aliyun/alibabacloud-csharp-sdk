// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DeleteRoutineEnvironmentVariablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of environment variable keys that were deleted successfully.</para>
        /// </summary>
        [NameInMap("DeletedKeys")]
        [Validation(Required=false)]
        public List<string> DeletedKeys { get; set; }

        /// <summary>
        /// <para>The list of environment variable keys that failed to be deleted.</para>
        /// </summary>
        [NameInMap("FailedKeys")]
        [Validation(Required=false)]
        public List<string> FailedKeys { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
