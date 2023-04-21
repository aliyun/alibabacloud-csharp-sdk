// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetConnectionTicketResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the desktop connection task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The status of the task.
        /// 
        /// Valid values:
        /// 
        /// *   FAILED
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     Failed to obtain the token
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   RUNNING
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     The token is being obtained
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   FINISHED
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     The token-based logon is successful
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// The credentials that are used to connect to the cloud desktop. To use the credentials, you must decode the credentials in Base64, save the credentials as a xxx.ica file, and then open the file. Sample Python code:
        /// 
        ///     import base64
        ///     response = {
        ///         "Ticket": "XXXX",
        ///         "RequestId": "XXX-XXX",
        ///     }
        ///     f = open (\"xxx.ica\", \"w\")
        ///     out = base64.b64decode(response[\"Ticket\"])
        ///     f.write(out)
        ///     f.close()
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
