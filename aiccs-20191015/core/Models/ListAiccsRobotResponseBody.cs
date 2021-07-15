// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListAiccsRobotResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAiccsRobotResponseBodyData> Data { get; set; }
        public class ListAiccsRobotResponseBodyData : TeaModel {
            [NameInMap("RobotType")]
            [Validation(Required=false)]
            public string RobotType { get; set; }

            [NameInMap("AtSence")]
            [Validation(Required=false)]
            public string AtSence { get; set; }

            [NameInMap("AtProfession")]
            [Validation(Required=false)]
            public string AtProfession { get; set; }

            [NameInMap("RobotName")]
            [Validation(Required=false)]
            public string RobotName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
