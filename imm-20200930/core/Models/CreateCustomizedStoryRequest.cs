// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateCustomizedStoryRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Cover")]
        [Validation(Required=false)]
        public CreateCustomizedStoryRequestCover Cover { get; set; }
        public class CreateCustomizedStoryRequestCover : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<CreateCustomizedStoryRequestFiles> Files { get; set; }
        public class CreateCustomizedStoryRequestFiles : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoryName")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StorySubType")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoryType")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

    }

}
