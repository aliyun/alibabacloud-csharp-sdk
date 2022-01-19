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

        /// <summary>
        /// CreateTime
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// CustomFields
        /// </summary>
        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public string CustomFields { get; set; }

        /// <summary>
        /// DatasetName
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// FigureClusterIds
        /// </summary>
        [NameInMap("FigureClusterIds")]
        [Validation(Required=false)]
        public List<string> FigureClusterIds { get; set; }

        /// <summary>
        /// Files
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

        /// <summary>
        /// ObjectId
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// ObjectType
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// OwnerId
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// ProjectName
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// StoryEndTime
        /// </summary>
        [NameInMap("StoryEndTime")]
        [Validation(Required=false)]
        public string StoryEndTime { get; set; }

        /// <summary>
        /// StoryName
        /// </summary>
        [NameInMap("StoryName")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        /// <summary>
        /// StoryStartTime
        /// </summary>
        [NameInMap("StoryStartTime")]
        [Validation(Required=false)]
        public string StoryStartTime { get; set; }

        /// <summary>
        /// StorySubType
        /// </summary>
        [NameInMap("StorySubType")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        /// <summary>
        /// StoryType
        /// </summary>
        [NameInMap("StoryType")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

        /// <summary>
        /// UpdateTime
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
