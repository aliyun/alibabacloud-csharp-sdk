// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateAKSPlanRequest : TeaModel {
        [NameInMap("AksServiceInfosJsonStr")]
        [Validation(Required=false)]
        public string AksServiceInfosJsonStr { get; set; }

        [NameInMap("AutoExecution")]
        [Validation(Required=false)]
        public bool? AutoExecution { get; set; }

        [NameInMap("Executor")]
        [Validation(Required=false)]
        public string Executor { get; set; }

        [NameInMap("ExecutorId")]
        [Validation(Required=false)]
        public string ExecutorId { get; set; }

        [NameInMap("ExecutorName")]
        [Validation(Required=false)]
        public string ExecutorName { get; set; }

        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("Context")]
        [Validation(Required=false)]
        public List<CreateAKSPlanRequestContext> Context { get; set; }
        public class CreateAKSPlanRequestContext : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
