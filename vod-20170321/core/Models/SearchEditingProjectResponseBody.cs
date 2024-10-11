// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchEditingProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of online editing projects.</para>
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
                /// <para>The thumbnail URL of the online editing project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cover_url</para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the online editing project was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-01-11T12:00:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the online editing project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test project 001</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The duration of the online editing project, which must be consistent with the duration of the timeline.</para>
                /// <remarks>
                /// <para>The Timeline parameter is not included in response parameters.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>22.65</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// <para>The last time when the online editing project was modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-01-11T13:00:00Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The ID of the online editing project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25cfc178d2de4*****e77aebed6afcd</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The region where the online editing project was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status of the online editing project. Separate multiple states with commas (,). By default, all online editing projects were queried. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: indicates that the online editing project is in draft.</description></item>
                /// <item><description><b>Producing</b>: indicates that the video is being produced.</description></item>
                /// <item><description><b>Produced</b>: indicates that the video was produced.</description></item>
                /// <item><description><b>ProduceFailed</b>: indicates that the video failed to be produced.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The path of the Object Storage Service (OSS) bucket where the produced video is stored.</para>
                /// <remarks>
                /// <para>To view the path of the OSS bucket, log on to the <a href="https://vod.console.aliyun.com/?spm=a2c4g.11186623.2.15.6948257eaZ4m54#/vod/settings/censored">ApsaraVideo VOD console</a>, and choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Storage</b>. On the Storage page, you can view the path of the OSS bucket.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>location_s</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The title of the online editing project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video_150873681****</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9262E3DA-07FA-48*****62-FCBB6BC61D08</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of online editing projects returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
