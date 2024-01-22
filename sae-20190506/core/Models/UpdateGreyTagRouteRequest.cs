// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateGreyTagRouteRequest : TeaModel {
        [NameInMap("AlbRules")]
        [Validation(Required=false)]
        public string AlbRules { get; set; }

        /// <summary>
        /// Canary Release - Regions
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// \[{"condition":"OR","group":"DUBBO","items":\[{"cond":"==","expr":".key1","index":0,"operator":"rawvalue","value":"value1"},{"cond":"==","expr":".key2","index":0,"operator":"rawvalue","value":"value2"}],"methodName":"echo","serviceName":"com.alibaba.edas.boot.EchoService","version":"1.0.0"}]
        /// </summary>
        [NameInMap("DubboRules")]
        [Validation(Required=false)]
        public string DubboRules { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("GreyTagRouteId")]
        [Validation(Required=false)]
        public long? GreyTagRouteId { get; set; }

        /// <summary>
        /// \[{"condition":"OR","items":\[{"cond":"==","name":"grey","operator":"rawvalue","type":"param","value":"true"},{"cond":"==","name":"grey","operator":"rawvalue","type":"cookie","value":"true"},{"cond":"==","name":"grey","operator":"rawvalue","type":"header","value":"true"}],"path":"/post-echo/hi"}]
        /// </summary>
        [NameInMap("ScRules")]
        [Validation(Required=false)]
        public string ScRules { get; set; }

    }

}
