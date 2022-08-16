// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FigureCluster : TeaModel {
        [NameInMap("AverageAge")]
        [Validation(Required=false)]
        public float? AverageAge { get; set; }

        [NameInMap("Cover")]
        [Validation(Required=false)]
        public File Cover { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("FaceCount")]
        [Validation(Required=false)]
        public long? FaceCount { get; set; }

        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("ImageCount")]
        [Validation(Required=false)]
        public long? ImageCount { get; set; }

        [NameInMap("MaxAge")]
        [Validation(Required=false)]
        public float? MaxAge { get; set; }

        [NameInMap("MinAge")]
        [Validation(Required=false)]
        public float? MinAge { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("VideoCount")]
        [Validation(Required=false)]
        public long? VideoCount { get; set; }

    }

}
