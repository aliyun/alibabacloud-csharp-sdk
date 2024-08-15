// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetSimilarIncidentStatisticsRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("incidentTitle")]
        [Validation(Required=false)]
        public string IncidentTitle { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

    }

}
