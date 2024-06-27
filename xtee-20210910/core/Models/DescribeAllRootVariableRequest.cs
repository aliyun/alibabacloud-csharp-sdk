// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAllRootVariableRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("deviceVariableIds")]
        [Validation(Required=false)]
        public string DeviceVariableIds { get; set; }

        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        [NameInMap("expressionVariableIds")]
        [Validation(Required=false)]
        public string ExpressionVariableIds { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("nativeVariableIds")]
        [Validation(Required=false)]
        public string NativeVariableIds { get; set; }

        [NameInMap("queryVariableIds")]
        [Validation(Required=false)]
        public string QueryVariableIds { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("velocityVariableIds")]
        [Validation(Required=false)]
        public string VelocityVariableIds { get; set; }

    }

}
