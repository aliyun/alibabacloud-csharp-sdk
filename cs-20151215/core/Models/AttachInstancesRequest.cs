// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesRequest : TeaModel {
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        [NameInMap("is_edge_worker")]
        [Validation(Required=false)]
        public bool? IsEdgeWorker { get; set; }

        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
