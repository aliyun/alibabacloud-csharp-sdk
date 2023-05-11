// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetThingTemplateResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The TSL features returned if the call is successful. Format:
        /// 
        /// ```
        /// 
        /// {
        ///   "properties": [], //The list of properties
        ///   "services": [], //The list of services
        ///   "events": [], //The list of events
        /// }
        ///                                 
        /// ```
        /// 
        /// For more information, see [TSL formats](~~73727~~).
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ThingModelJSON")]
        [Validation(Required=false)]
        public string ThingModelJSON { get; set; }

    }

}
