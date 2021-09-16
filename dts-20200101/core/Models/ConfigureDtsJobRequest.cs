/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureDtsJobRequest : TeaModel {
        [NameInMap("DtsJobName")]
        [Validation(Required=false)]
        public string DtsJobName { get; set; }

        [NameInMap("SourceEndpointInstanceType")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceType { get; set; }

        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        [NameInMap("SourceEndpointEngineName")]
        [Validation(Required=false)]
        public string SourceEndpointEngineName { get; set; }

        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

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

        [NameInMap("DestinationEndpointInstanceType")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceType { get; set; }

        [NameInMap("DestinationEndpointInstanceID")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceID { get; set; }

        [NameInMap("DestinationEndpointEngineName")]
        [Validation(Required=false)]
        public string DestinationEndpointEngineName { get; set; }

        [NameInMap("DestinationEndpointRegion")]
        [Validation(Required=false)]
        public string DestinationEndpointRegion { get; set; }

        [NameInMap("DestinationEndpointIP")]
        [Validation(Required=false)]
        public string DestinationEndpointIP { get; set; }

        [NameInMap("DestinationEndpointPort")]
        [Validation(Required=false)]
        public string DestinationEndpointPort { get; set; }

        [NameInMap("DestinationEndpointDataBaseName")]
        [Validation(Required=false)]
        public string DestinationEndpointDataBaseName { get; set; }

        [NameInMap("DestinationEndpointUserName")]
        [Validation(Required=false)]
        public string DestinationEndpointUserName { get; set; }

        [NameInMap("DestinationEndpointPassword")]
        [Validation(Required=false)]
        public string DestinationEndpointPassword { get; set; }

        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public bool? StructureInitialization { get; set; }

        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public bool? DataInitialization { get; set; }

        [NameInMap("DataSynchronization")]
        [Validation(Required=false)]
        public bool? DataSynchronization { get; set; }

        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        [NameInMap("Reserve")]
        [Validation(Required=false)]
        public string Reserve { get; set; }

        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("DestinationEndpointOracleSID")]
        [Validation(Required=false)]
        public string DestinationEndpointOracleSID { get; set; }

        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

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

        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
