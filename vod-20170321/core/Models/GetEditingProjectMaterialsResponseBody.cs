// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetEditingProjectMaterialsResponseBody : TeaModel {
        /// <summary>
        /// <para>The materials.</para>
        /// </summary>
        [NameInMap("MaterialList")]
        [Validation(Required=false)]
        public GetEditingProjectMaterialsResponseBodyMaterialList MaterialList { get; set; }
        public class GetEditingProjectMaterialsResponseBodyMaterialList : TeaModel {
            [NameInMap("Material")]
            [Validation(Required=false)]
            public List<GetEditingProjectMaterialsResponseBodyMaterialListMaterial> Material { get; set; }
            public class GetEditingProjectMaterialsResponseBodyMaterialListMaterial : TeaModel {
                /// <summary>
                /// <para>The category ID of the material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100005****</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public int? CateId { get; set; }

                /// <summary>
                /// <para>The category name of the material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The thumbnail URL of the material.</para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the material was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-10-19 10:48:17</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test2</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The duration of the material. The value is rounded to four decimal places. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15.16</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// <para>The ID of the material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85befc4118b84c6723e53b80b1****</para>
                /// </summary>
                [NameInMap("MaterialId")]
                [Validation(Required=false)]
                public string MaterialId { get; set; }

                /// <summary>
                /// <para>The type of the material. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>video</b></description></item>
                /// <item><description><b>audio</b></description></item>
                /// <item><description><b>image</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("MaterialType")]
                [Validation(Required=false)]
                public string MaterialType { get; set; }

                /// <summary>
                /// <para>The time when the material was last updated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-10-19 10:48:17</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The size of the mezzanine file. Unit: byte.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1682694</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The URLs of material snapshots. The value is an array.</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public GetEditingProjectMaterialsResponseBodyMaterialListMaterialSnapshots Snapshots { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMaterialListMaterialSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<string> Snapshot { get; set; }

                }

                /// <summary>
                /// <para>The source of the sprite.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The configuration of the sprite.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("SpriteConfig")]
                [Validation(Required=false)]
                public string SpriteConfig { get; set; }

                /// <summary>
                /// <para>The URLs of material sprites. The value is an array.</para>
                /// </summary>
                [NameInMap("Sprites")]
                [Validation(Required=false)]
                public GetEditingProjectMaterialsResponseBodyMaterialListMaterialSprites Sprites { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMaterialListMaterialSprites : TeaModel {
                    [NameInMap("Sprite")]
                    [Validation(Required=false)]
                    public List<string> Sprite { get; set; }

                }

                /// <summary>
                /// <para>The status of the material. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: The material is in draft.</description></item>
                /// <item><description><b>Producing</b>: The material is being produced.</description></item>
                /// <item><description><b>Produced</b>: The material was produced.</description></item>
                /// <item><description><b>ProduceFailed</b>: The material failed to be produced.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag of the material. Multiple tags are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>editing test</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The title of the material.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
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
        /// <para>746FFA07-8BBB-46B1-3E94E3B2915E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
