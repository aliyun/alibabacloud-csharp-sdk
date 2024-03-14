// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneGroupResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneGroupResponseBodyData Data { get; set; }
        public class CreateOrUpdateSwimmingLaneGroupResponseBodyData : TeaModel {
            [NameInMap("AppIds")]
            [Validation(Required=false)]
            public string AppIds { get; set; }

            [NameInMap("CanaryModel")]
            [Validation(Required=false)]
            public int? CanaryModel { get; set; }

            [NameInMap("DbGrayEnable")]
            [Validation(Required=false)]
            public string DbGrayEnable { get; set; }

            [NameInMap("EntryApp")]
            [Validation(Required=false)]
            public string EntryApp { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("MessageQueueFilterSide")]
            [Validation(Required=false)]
            public string MessageQueueFilterSide { get; set; }

            [NameInMap("MessageQueueGrayEnable")]
            [Validation(Required=false)]
            public bool? MessageQueueGrayEnable { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Paths")]
            [Validation(Required=false)]
            public string Paths { get; set; }

            [NameInMap("RecordCanaryDetail")]
            [Validation(Required=false)]
            public bool? RecordCanaryDetail { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// true: The request was successful. false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
