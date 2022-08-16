// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Story : TeaModel {
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

        [NameInMap("FigureClusterIds")]
        [Validation(Required=false)]
        public List<string> FigureClusterIds { get; set; }

        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

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

        [NameInMap("StoryEndTime")]
        [Validation(Required=false)]
        public string StoryEndTime { get; set; }

        [NameInMap("StoryName")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        [NameInMap("StoryStartTime")]
        [Validation(Required=false)]
        public string StoryStartTime { get; set; }

        [NameInMap("StorySubType")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        [NameInMap("StoryType")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
