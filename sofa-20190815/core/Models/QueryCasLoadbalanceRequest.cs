// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasLoadbalanceRequest : TeaModel {
        [NameInMap("AppIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppIdsRepeatList { get; set; }

        [NameInMap("AppServiceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppServiceIdsRepeatList { get; set; }

        [NameInMap("ClusterIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> ClusterIdsRepeatList { get; set; }

        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public bool? ClusterMode { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("DomainsRepeatList")]
        [Validation(Required=false)]
        public List<string> DomainsRepeatList { get; set; }

        [NameInMap("HealthLevelsRepeatList")]
        [Validation(Required=false)]
        public List<string> HealthLevelsRepeatList { get; set; }

        [NameInMap("IaasIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IaasIdsRepeatList { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ShareMode")]
        [Validation(Required=false)]
        public bool? ShareMode { get; set; }

        [NameInMap("StatusesRepeatList")]
        [Validation(Required=false)]
        public List<string> StatusesRepeatList { get; set; }

        [NameInMap("VipAddressesRepeatList")]
        [Validation(Required=false)]
        public List<string> VipAddressesRepeatList { get; set; }

        [NameInMap("VipAddressType")]
        [Validation(Required=false)]
        public string VipAddressType { get; set; }

        [NameInMap("VipType")]
        [Validation(Required=false)]
        public string VipType { get; set; }

        [NameInMap("VpcIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> VpcIdsRepeatList { get; set; }

        [NameInMap("VswitchIaasIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> VswitchIaasIdsRepeatList { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
