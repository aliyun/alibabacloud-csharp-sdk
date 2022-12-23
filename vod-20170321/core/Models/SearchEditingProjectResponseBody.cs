// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchEditingProjectResponseBody : TeaModel {
        /// <summary>
        /// The list of online editing projects.
        /// </summary>
        [NameInMap("ProjectList")]
        [Validation(Required=false)]
        public SearchEditingProjectResponseBodyProjectList ProjectList { get; set; }
        public class SearchEditingProjectResponseBodyProjectList : TeaModel {
            [NameInMap("Project")]
            [Validation(Required=false)]
            public List<SearchEditingProjectResponseBodyProjectListProject> Project { get; set; }
            public class SearchEditingProjectResponseBodyProjectListProject : TeaModel {
                /// <summary>
                /// The thumbnail URL of the online editing project.
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// The time when the online editing project was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the online editing project.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The duration of the online editing project, which must be consistent with the duration of the timeline.
                /// > The Timeline parameter is not included in response parameters.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// The last time when the online editing project was modified. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The ID of the online editing project.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// The region where the online editing project was created.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The status of the online editing project. Separate multiple states with commas (,). By default, all online editing projects were queried. Valid values:
                /// *   **Normal**: indicates that the online editing project is in draft.
                /// *   **Producing**: indicates that the video is being produced.
                /// *   **Produced**: indicates that the video was produced.
                /// *   **ProduceFailed**: indicates that the video failed to be produced.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The path of the Object Storage Service (OSS) bucket where the produced video is stored.
                /// > To view the path of the OSS bucket, log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com/?spm=a2c4g.11186623.2.15.6948257eaZ4m54#/vod/settings/censored), and choose **Configuration Management** > **Media Management** > **Storage**. On the Storage page, you can view the path of the OSS bucket.
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// The title of the online editing project.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of online editing projects returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
