// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddEditingProjectMaterialsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of media assets.</para>
        /// </summary>
        [NameInMap("MaterialList")]
        [Validation(Required=false)]
        public List<AddEditingProjectMaterialsResponseBodyMaterialList> MaterialList { get; set; }
        public class AddEditingProjectMaterialsResponseBodyMaterialList : TeaModel {
            /// <summary>
            /// <para>The category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000487543</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public int? CateId { get; set; }

            /// <summary>
            /// <para>The name of the media asset category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Category 1</para>
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// <para>The URL of the media asset thumbnail.</para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The time when the media asset was created. The time follows the <i>yyyy-mm-dd</i>T<i>hh:mm:ss</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-02T08:26Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234751840694470</para>
            /// </summary>
            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public long? CustomerId { get; set; }

            /// <summary>
            /// <para>The description of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Media asset description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The duration of the media asset. Unit: seconds. The value is accurate to four decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3690.2332</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The ID of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85befc4118b84c6723e53b80b1****</para>
            /// </summary>
            [NameInMap("MaterialId")]
            [Validation(Required=false)]
            public string MaterialId { get; set; }

            /// <summary>
            /// <para>The type of the media asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>video</b>: video</description></item>
            /// <item><description><b>audio</b>: audio-only</description></item>
            /// <item><description><b>image</b>: image</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("MaterialType")]
            [Validation(Required=false)]
            public string MaterialType { get; set; }

            /// <summary>
            /// <para>The time when the media asset was updated. The time follows the <i>yyyy-mm-dd</i>T<i>hh:mm:ss</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-25T07:28:34Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The file size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1682694</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The array of snapshot URLs for the media asset.</para>
            /// </summary>
            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public List<string> Snapshots { get; set; }

            /// <summary>
            /// <para>The sprite configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("SpriteConfig")]
            [Validation(Required=false)]
            public string SpriteConfig { get; set; }

            /// <summary>
            /// <para>The array of sprite URLs for the media asset.</para>
            /// </summary>
            [NameInMap("Sprites")]
            [Validation(Required=false)]
            public List<string> Sprites { get; set; }

            /// <summary>
            /// <para>The status of the media asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: Normal.</description></item>
            /// <item><description><b>Uploading</b>: Uploading.</description></item>
            /// <item><description><b>UploadFail</b>: Upload failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the media asset. Separate multiple tags with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag1,tag2</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The title of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85237CDA-0B54-5CED-BA10-A8A71AA13C1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
