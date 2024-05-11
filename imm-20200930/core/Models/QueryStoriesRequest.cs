// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class QueryStoriesRequest : TeaModel {
        [NameInMap("CreateTimeRange")]
        [Validation(Required=false)]
        public TimeRange CreateTimeRange { get; set; }

        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public string CustomLabels { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("FigureClusterIds")]
        [Validation(Required=false)]
        public List<string> FigureClusterIds { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("StoryEndTimeRange")]
        [Validation(Required=false)]
        public TimeRange StoryEndTimeRange { get; set; }

        [NameInMap("StoryName")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        [NameInMap("StoryStartTimeRange")]
        [Validation(Required=false)]
        public TimeRange StoryStartTimeRange { get; set; }

        [NameInMap("StorySubType")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        [NameInMap("StoryType")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

        [NameInMap("WithEmptyStories")]
        [Validation(Required=false)]
        public bool? WithEmptyStories { get; set; }

    }

}
