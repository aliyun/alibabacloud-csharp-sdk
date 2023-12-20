// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListEiamInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListEiamInstancesResponseBodyInstances> Instances { get; set; }
        public class ListEiamInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// 实例描述信息
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 实例developer私网域名地址
            /// </summary>
            [NameInMap("DeveloperAPIPrivateDomain")]
            [Validation(Required=false)]
            public string DeveloperAPIPrivateDomain { get; set; }

            /// <summary>
            /// 实例developer公网域名地址
            /// </summary>
            [NameInMap("DeveloperAPIPublicDomain")]
            [Validation(Required=false)]
            public string DeveloperAPIPublicDomain { get; set; }

            /// <summary>
            /// 实例id
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 实例状态，Pending(初始状态)、Creating(创建中)、Running(运行中)、Disabled(禁用)、CreateFailed(创建失败)
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// 实例版本，EIAM2.0/ EIAM1.0
            /// </summary>
            [NameInMap("InstanceVersion")]
            [Validation(Required=false)]
            public string InstanceVersion { get; set; }

            /// <summary>
            /// 实例openApi私网域名地址
            /// </summary>
            [NameInMap("OpenAPIPrivateDomain")]
            [Validation(Required=false)]
            public string OpenAPIPrivateDomain { get; set; }

            /// <summary>
            /// 实例openApi公网域名地址
            /// </summary>
            [NameInMap("OpenAPIPublicDomain")]
            [Validation(Required=false)]
            public string OpenAPIPublicDomain { get; set; }

            /// <summary>
            /// 实例域名地址
            /// </summary>
            [NameInMap("SSODomain")]
            [Validation(Required=false)]
            public string SSODomain { get; set; }

            /// <summary>
            /// 实例的创建时间
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
