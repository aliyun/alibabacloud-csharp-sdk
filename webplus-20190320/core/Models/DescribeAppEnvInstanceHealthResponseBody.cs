// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeAppEnvInstanceHealthResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EnvInstanceHealth")]
        [Validation(Required=false)]
        public DescribeAppEnvInstanceHealthResponseBodyEnvInstanceHealth EnvInstanceHealth { get; set; }
        public class DescribeAppEnvInstanceHealthResponseBodyEnvInstanceHealth : TeaModel {
            [NameInMap("EnableHealthCheck")]
            [Validation(Required=false)]
            public bool? EnableHealthCheck { get; set; }
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }
            [NameInMap("InstanceHealthList")]
            [Validation(Required=false)]
            public DescribeAppEnvInstanceHealthResponseBodyEnvInstanceHealthInstanceHealthList InstanceHealthList { get; set; }
            public class DescribeAppEnvInstanceHealthResponseBodyEnvInstanceHealthInstanceHealthList : TeaModel {
                [NameInMap("InstanceHealth")]
                [Validation(Required=false)]
                public List<DescribeAppEnvInstanceHealthResponseBodyEnvInstanceHealthInstanceHealthListInstanceHealth> InstanceHealth { get; set; }
                public class DescribeAppEnvInstanceHealthResponseBodyEnvInstanceHealthInstanceHealthListInstanceHealth : TeaModel {
                    [NameInMap("AppStatus")]
                    [Validation(Required=false)]
                    public string AppStatus { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("DisconnectedTime")]
                    [Validation(Required=false)]
                    public string DisconnectedTime { get; set; }

                    [NameInMap("AgentStatus")]
                    [Validation(Required=false)]
                    public string AgentStatus { get; set; }

                }

            }
        };

    }

}
