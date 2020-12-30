// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class CreateWorkGroupRequest : TeaModel {
        [NameInMap("WorkGroupName")]
        [Validation(Required=false)]
        public string WorkGroupName { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("TheoryCutStatus")]
        [Validation(Required=false)]
        public string TheoryCutStatus { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("JobNum")]
        [Validation(Required=false)]
        public int? JobNum { get; set; }

        [NameInMap("TopicNum")]
        [Validation(Required=false)]
        public int? TopicNum { get; set; }

        [NameInMap("TopicPrefix")]
        [Validation(Required=false)]
        public string TopicPrefix { get; set; }

        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
