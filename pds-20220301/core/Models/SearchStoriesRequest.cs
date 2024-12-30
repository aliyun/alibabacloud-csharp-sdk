// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchStoriesRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>image/resize,m_fill,h_128,w_128,limit_0/format,jpg</para>
        /// </summary>
        [NameInMap("cover_image_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string CoverImageThumbnailProcess { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>video/snapshot,t_1000,f_jpg,w_0,h_0,m_fast,ar_auto</para>
        /// </summary>
        [NameInMap("cover_video_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string CoverVideoThumbnailProcess { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("create_time_range")]
        [Validation(Required=false)]
        public SearchStoriesRequestCreateTimeRange CreateTimeRange { get; set; }
        public class SearchStoriesRequestCreateTimeRange : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-31T00:00:00+08:00</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2016-12-31T00:00:00+08:00</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value1,key2!=value2</para>
        /// </summary>
        [NameInMap("custom_labels")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustomLabels { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("face_group_ids")]
        [Validation(Required=false)]
        public List<string> FaceGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDODBhNDQ2Nzhl***</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("story_end_time_range")]
        [Validation(Required=false)]
        public SearchStoriesRequestStoryEndTimeRange StoryEndTimeRange { get; set; }
        public class SearchStoriesRequestStoryEndTimeRange : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-31T00:00:00+08:00</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2016-12-31T00:00:00+08:00</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9132e0d8-fe92-4e56-86c3-f5f112308003</para>
        /// </summary>
        [NameInMap("story_id")]
        [Validation(Required=false)]
        public string StoryId { get; set; }

        [NameInMap("story_name")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("story_start_time_range")]
        [Validation(Required=false)]
        public SearchStoriesRequestStoryStartTimeRange StoryStartTimeRange { get; set; }
        public class SearchStoriesRequestStoryStartTimeRange : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-31T00:00:00+08:00</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2016-12-31T00:00:00+08:00</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PeopleMemory</para>
        /// </summary>
        [NameInMap("story_type")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("url_expire_sec")]
        [Validation(Required=false)]
        [Obsolete]
        public long? UrlExpireSec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("with_empty_stories")]
        [Validation(Required=false)]
        public bool? WithEmptyStories { get; set; }

    }

}
