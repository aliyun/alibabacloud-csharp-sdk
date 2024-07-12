// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class SearchPunishRequestRequest : TeaModel {
        [NameInMap("AntiStatuses")]
        [Validation(Required=false)]
        public List<string> AntiStatuses { get; set; }

        [NameInMap("BussinessCodes")]
        [Validation(Required=false)]
        public List<string> BussinessCodes { get; set; }

        [NameInMap("Class")]
        [Validation(Required=false)]
        public string Class { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("EventCodes")]
        [Validation(Required=false)]
        public List<string> EventCodes { get; set; }

        [NameInMap("ExtRequestId")]
        [Validation(Required=false)]
        public string ExtRequestId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("IdType")]
        [Validation(Required=false)]
        public string IdType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PunishDomain")]
        [Validation(Required=false)]
        public string PunishDomain { get; set; }

        [NameInMap("PunishIp")]
        [Validation(Required=false)]
        public string PunishIp { get; set; }

        [NameInMap("PunishStatuses")]
        [Validation(Required=false)]
        public List<string> PunishStatuses { get; set; }

        [NameInMap("PunishUrl")]
        [Validation(Required=false)]
        public string PunishUrl { get; set; }

        [NameInMap("PunishUrlFull")]
        [Validation(Required=false)]
        public string PunishUrlFull { get; set; }

        [NameInMap("SourceCodes")]
        [Validation(Required=false)]
        public List<string> SourceCodes { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
