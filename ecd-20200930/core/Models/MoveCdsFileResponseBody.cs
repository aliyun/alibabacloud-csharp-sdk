// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MoveCdsFileResponseBody : TeaModel {
        /// <summary>
        /// The result of the modification. A value of success indicates that the modification is successful. If the modification failed, an error message is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message that is returned. This parameter is not returned if the value of Code is success.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The response object when you move a file.
        /// </summary>
        [NameInMap("MoveCdsFileModel")]
        [Validation(Required=false)]
        public MoveCdsFileResponseBodyMoveCdsFileModel MoveCdsFileModel { get; set; }
        public class MoveCdsFileResponseBodyMoveCdsFileModel : TeaModel {
            /// <summary>
            /// The ID of the asynchronous task. This parameter is not returned if you copy files. This parameter is returned if you copy folders in the backend in an asynchronous manner. You can call the GetAsyncTask operation to obtain the ID and details of an asynchronous task.
            /// </summary>
            [NameInMap("AsyncTaskId")]
            [Validation(Required=false)]
            public string AsyncTaskId { get; set; }

            /// <summary>
            /// Indicates whether the file exists.
            /// 
            /// Valid values:
            /// 
            /// *   <!-- -->
            /// 
            ///     true
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   <!-- -->
            /// 
            ///     false
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Exist")]
            [Validation(Required=false)]
            public bool? Exist { get; set; }

            /// <summary>
            /// The ID of the file.
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// 
        /// Valid values:
        /// 
        /// *   <!-- -->
        /// 
        ///     true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   <!-- -->
        /// 
        ///     false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
