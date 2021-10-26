// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class TracingConfig : TeaModel {
        [NameInMap("jaegerConfig")]
        [Validation(Required=false)]
        public JaegerConfig JaegerConfig { get; set; }

        /// <summary>
        /// 链路追踪参数
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// 链路追踪类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
