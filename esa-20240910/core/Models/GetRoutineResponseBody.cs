// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineResponseBody : TeaModel {
        [NameInMap("CodeVersions")]
        [Validation(Required=false)]
        public List<GetRoutineResponseBodyCodeVersions> CodeVersions { get; set; }
        public class GetRoutineResponseBodyCodeVersions : TeaModel {
            [NameInMap("CodeDescription")]
            [Validation(Required=false)]
            public string CodeDescription { get; set; }

            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DefaultRelatedRecord")]
        [Validation(Required=false)]
        public string DefaultRelatedRecord { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Envs")]
        [Validation(Required=false)]
        public List<GetRoutineResponseBodyEnvs> Envs { get; set; }
        public class GetRoutineResponseBodyEnvs : TeaModel {
            [NameInMap("CanaryAreaList")]
            [Validation(Required=false)]
            public List<string> CanaryAreaList { get; set; }

            [NameInMap("CanaryCodeVersion")]
            [Validation(Required=false)]
            public string CanaryCodeVersion { get; set; }

            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

        }

        [NameInMap("RelatedRecords")]
        [Validation(Required=false)]
        public List<GetRoutineResponseBodyRelatedRecords> RelatedRecords { get; set; }
        public class GetRoutineResponseBodyRelatedRecords : TeaModel {
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

        }

        [NameInMap("RelatedRoutes")]
        [Validation(Required=false)]
        public List<GetRoutineResponseBodyRelatedRoutes> RelatedRoutes { get; set; }
        public class GetRoutineResponseBodyRelatedRoutes : TeaModel {
            [NameInMap("Route")]
            [Validation(Required=false)]
            public string Route { get; set; }

            [NameInMap("RouteId")]
            [Validation(Required=false)]
            public string RouteId { get; set; }

            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
