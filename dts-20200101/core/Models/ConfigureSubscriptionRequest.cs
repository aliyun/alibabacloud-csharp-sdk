// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSubscriptionRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("DtsJobName")]
        [Validation(Required=false)]
        public string DtsJobName { get; set; }

        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        [NameInMap("SourceEndpointInstanceType")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceType { get; set; }

        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public string SourceEndpointPort { get; set; }

        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        [NameInMap("SourceEndpointOwnerID")]
        [Validation(Required=false)]
        public string SourceEndpointOwnerID { get; set; }

        [NameInMap("SourceEndpointRole")]
        [Validation(Required=false)]
        public string SourceEndpointRole { get; set; }

        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        [NameInMap("Reserve")]
        [Validation(Required=false)]
        public string Reserve { get; set; }

        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        [NameInMap("SubscriptionInstanceNetworkType")]
        [Validation(Required=false)]
        public string SubscriptionInstanceNetworkType { get; set; }

        [NameInMap("SubscriptionInstanceVPCId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceVPCId { get; set; }

        [NameInMap("SubscriptionInstanceVSwitchId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceVSwitchId { get; set; }

        [NameInMap("SubscriptionDataTypeDDL")]
        [Validation(Required=false)]
        public bool? SubscriptionDataTypeDDL { get; set; }

        [NameInMap("SubscriptionDataTypeDML")]
        [Validation(Required=false)]
        public bool? SubscriptionDataTypeDML { get; set; }

        [NameInMap("DelayPhone")]
        [Validation(Required=false)]
        public string DelayPhone { get; set; }

        [NameInMap("DelayRuleTime")]
        [Validation(Required=false)]
        public long? DelayRuleTime { get; set; }

        [NameInMap("DelayNotice")]
        [Validation(Required=false)]
        public bool? DelayNotice { get; set; }

        [NameInMap("ErrorPhone")]
        [Validation(Required=false)]
        public string ErrorPhone { get; set; }

        [NameInMap("ErrorNotice")]
        [Validation(Required=false)]
        public bool? ErrorNotice { get; set; }

    }

}
