// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateTriggerRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// event source，如OSS，使用该role去invoke function
        /// </summary>
        [NameInMap("invocationRole")]
        [Validation(Required=false)]
        public string InvocationRole { get; set; }

        /// <summary>
        /// service版本
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// event source的Aliyun Resource Name（ARN
        /// </summary>
        [NameInMap("sourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public object TriggerConfig { get; set; }

        /// <summary>
        /// trigger名称
        /// </summary>
        [NameInMap("triggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// trigger类型，如 oss, log, tablestore, timer, http, cdn_events, mns_topic
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
