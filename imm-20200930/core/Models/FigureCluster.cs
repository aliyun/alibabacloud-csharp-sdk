// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FigureCluster : TeaModel {
        /// <summary>
        /// AverageAge
        /// </summary>
        [NameInMap("AverageAge")]
        [Validation(Required=false)]
        public float? AverageAge { get; set; }

        /// <summary>
        /// Cover
        /// </summary>
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
        /// CustomId
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// CustomLabels
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// DatasetName
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// FaceCount
        /// </summary>
        [NameInMap("FaceCount")]
        [Validation(Required=false)]
        public long? FaceCount { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// ImageCount
        /// </summary>
        [NameInMap("ImageCount")]
        [Validation(Required=false)]
        public long? ImageCount { get; set; }

        /// <summary>
        /// MaxAge
        /// </summary>
        [NameInMap("MaxAge")]
        [Validation(Required=false)]
        public float? MaxAge { get; set; }

        /// <summary>
        /// MinAge
        /// </summary>
        [NameInMap("MinAge")]
        [Validation(Required=false)]
        public float? MinAge { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// UpdateTime
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// VideoCount
        /// </summary>
        [NameInMap("VideoCount")]
        [Validation(Required=false)]
        public long? VideoCount { get; set; }

    }

}
