// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAttachedMediaInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the media assets.</para>
        /// </summary>
        [NameInMap("AttachedMediaList")]
        [Validation(Required=false)]
        public List<GetAttachedMediaInfoResponseBodyAttachedMediaList> AttachedMediaList { get; set; }
        public class GetAttachedMediaInfoResponseBodyAttachedMediaList : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-*****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The categories.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<GetAttachedMediaInfoResponseBodyAttachedMediaListCategories> Categories { get; set; }
            public class GetAttachedMediaInfoResponseBodyAttachedMediaListCategories : TeaModel {
                /// <summary>
                /// <para>The ID of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000224338</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The name of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>category test</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The level of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public long? Level { get; set; }

                /// <summary>
                /// <para>The ID of the parent category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000224336</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

            }

            /// <summary>
            /// <para>The time when the auxiliary media asset was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the auxiliary media asset.</para>
            /// <remarks>
            /// <para> This parameter is returned only when a description is specified for the auxiliary media asset.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>description test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the auxiliary media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0222e203cf80f9c22870a4d2c****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The time when the auxiliary media asset was last updated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-31T11:42:20Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The status of the auxiliary media asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Uploading</b></description></item>
            /// <item><description><b>Normal</b></description></item>
            /// <item><description><b>UploadFail</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage address of the auxiliary media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>outin-bfefbb9*****c7426.oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            /// <summary>
            /// <para>The tags of the auxiliary media asset.</para>
            /// <remarks>
            /// <para> This parameter is returned only when tags are specified for the auxiliary media asset.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>tag1,tag2</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The title of the auxiliary media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subtitle test</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The type of the auxiliary media asset.</para>
            /// <list type="bullet">
            /// <item><description><b>watermark</b></description></item>
            /// <item><description><b>subtitle</b></description></item>
            /// <item><description><b>material</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>subtitle</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the auxiliary media asset.</para>
            /// <remarks>
            /// <para> If a CDN domain name is specified, a CDN URL is returned. Otherwise, an OSS URL is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://al*****.cn/subtitle/9843C2*****4E186F19B6.vtt?auth_key=159099f60e0b7fd59">https://al*****.cn/subtitle/9843C2*****4E186F19B6.vtt?auth_key=159099f60e0b7fd59</a>****</para>
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the auxiliary media assets that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public List<string> NonExistMediaIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>221BCB57-B217-42BF-619BD13378F9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
