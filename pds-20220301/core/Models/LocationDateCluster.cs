// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class LocationDateCluster : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public Address Address { get; set; }

        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("custom_labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> CustomLabels { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("end_time")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("start_time")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
