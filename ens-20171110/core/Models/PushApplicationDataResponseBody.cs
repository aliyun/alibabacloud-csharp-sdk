// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PushApplicationDataResponseBody : TeaModel {
        /// <summary>
        /// The push results of data files.
        /// </summary>
        [NameInMap("PushResults")]
        [Validation(Required=false)]
        public PushApplicationDataResponseBodyPushResults PushResults { get; set; }
        public class PushApplicationDataResponseBodyPushResults : TeaModel {
            [NameInMap("PushResult")]
            [Validation(Required=false)]
            public List<PushApplicationDataResponseBodyPushResultsPushResult> PushResult { get; set; }
            public class PushApplicationDataResponseBodyPushResultsPushResult : TeaModel {
                /// <summary>
                /// The name of the data file.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The push result. The value is of the enumeration type. Valid values:
                /// 
                /// *   0: The push operation is successful.
                /// *   100: The push operation has been performed and the file is pushed.
                /// *   200: The push operation has been performed and the file is being pushed to specific file servers.
                /// *   300: The push operation failed. You must trigger the push operation again. The ResultDescrip parameter indicates the error description.
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public int? ResultCode { get; set; }

                /// <summary>
                /// The description of the push status.
                /// </summary>
                [NameInMap("ResultDescrip")]
                [Validation(Required=false)]
                public string ResultDescrip { get; set; }

                /// <summary>
                /// The version number of the data file.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
