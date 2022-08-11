// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListFunctionsResponseBody : TeaModel {
        [NameInMap("functions")]
        [Validation(Required=false)]
        public List<ListFunctionsResponseBodyFunctions> Functions { get; set; }
        public class ListFunctionsResponseBodyFunctions : TeaModel {
            [NameInMap("caPort")]
            [Validation(Required=false)]
            public int? CaPort { get; set; }

            [NameInMap("codeChecksum")]
            [Validation(Required=false)]
            public string CodeChecksum { get; set; }

            [NameInMap("codeSize")]
            [Validation(Required=false)]
            public long? CodeSize { get; set; }

            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("customContainerConfig")]
            [Validation(Required=false)]
            public CustomContainerConfig CustomContainerConfig { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("environmentVariables")]
            [Validation(Required=false)]
            public Dictionary<string, string> EnvironmentVariables { get; set; }

            [NameInMap("functionId")]
            [Validation(Required=false)]
            public string FunctionId { get; set; }

            [NameInMap("functionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            [NameInMap("handler")]
            [Validation(Required=false)]
            public string Handler { get; set; }

            [NameInMap("initializationTimeout")]
            [Validation(Required=false)]
            public int? InitializationTimeout { get; set; }

            [NameInMap("initializer")]
            [Validation(Required=false)]
            public string Initializer { get; set; }

            [NameInMap("instanceConcurrency")]
            [Validation(Required=false)]
            public int? InstanceConcurrency { get; set; }

            [NameInMap("instanceLifecycleConfig")]
            [Validation(Required=false)]
            public InstanceLifecycleConfig InstanceLifecycleConfig { get; set; }

            [NameInMap("instanceSoftConcurrency")]
            [Validation(Required=false)]
            public int? InstanceSoftConcurrency { get; set; }

            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            [NameInMap("layers")]
            [Validation(Required=false)]
            public List<string> Layers { get; set; }

            [NameInMap("memorySize")]
            [Validation(Required=false)]
            public int? MemorySize { get; set; }

            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
