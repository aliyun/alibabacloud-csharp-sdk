/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesRequest : TeaModel {
        /// <summary>
        /// 待添加的实例列表。
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// 容器运行时。
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public AttachInstancesRequestRuntime Runtime { get; set; }
        public class AttachInstancesRequestRuntime : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }
        };

        /// <summary>
        /// 自定义镜像ID。
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// 是否格式化数据盘。
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// 是否保留实例名称。
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        /// <summary>
        /// CPU策略。
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        /// <summary>
        /// key_pair名称，与login_password二选一
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// password，与key_pair二选一。
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// 是否为边缘节点。
        /// </summary>
        [NameInMap("is_edge_worker")]
        [Validation(Required=false)]
        public bool? IsEdgeWorker { get; set; }

        /// <summary>
        /// 用户自定义数据。
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// 节点池ID，欲将节点添加到哪个节点池中。。
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// RDS实例列表。
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// 节点标签。
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<AttachInstancesRequestTags> Tags { get; set; }
        public class AttachInstancesRequestTags : TeaModel {
            /// <summary>
            /// 标签名。
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 标签值。
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
