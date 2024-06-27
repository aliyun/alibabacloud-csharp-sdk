// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateCustVariableRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("eventCodes")]
        [Validation(Required=false)]
        public string EventCodes { get; set; }

        [NameInMap("historyValueType")]
        [Validation(Required=false)]
        public string HistoryValueType { get; set; }

        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        [NameInMap("outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("timeType")]
        [Validation(Required=false)]
        public string TimeType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("twCount")]
        [Validation(Required=false)]
        public int? TwCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("velocityFC")]
        [Validation(Required=false)]
        public string VelocityFC { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("velocityTW")]
        [Validation(Required=false)]
        public string VelocityTW { get; set; }

    }

}
