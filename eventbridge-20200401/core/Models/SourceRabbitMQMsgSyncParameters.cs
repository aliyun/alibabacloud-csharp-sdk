// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SourceRabbitMQMsgSyncParameters : TeaModel {
        [NameInMap("BodyDataType")]
        [Validation(Required=false)]
        public string BodyDataType { get; set; }

        [NameInMap("CloudMigrationTaskId")]
        [Validation(Required=false)]
        public string CloudMigrationTaskId { get; set; }

        [NameInMap("DstClusterHost")]
        [Validation(Required=false)]
        public string DstClusterHost { get; set; }

        [NameInMap("DstClusterType")]
        [Validation(Required=false)]
        public string DstClusterType { get; set; }

        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OrderConsume")]
        [Validation(Required=false)]
        public string OrderConsume { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("PrefetchCount")]
        [Validation(Required=false)]
        public string PrefetchCount { get; set; }

        [NameInMap("Regex")]
        [Validation(Required=false)]
        public string Regex { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("SrcClusterHost")]
        [Validation(Required=false)]
        public string SrcClusterHost { get; set; }

        [NameInMap("SrcClusterType")]
        [Validation(Required=false)]
        public string SrcClusterType { get; set; }

        [NameInMap("SyncMetaType")]
        [Validation(Required=false)]
        public string SyncMetaType { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        [NameInMap("VirtualHostName")]
        [Validation(Required=false)]
        public string VirtualHostName { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
