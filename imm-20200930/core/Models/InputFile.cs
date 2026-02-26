// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class InputFile : TeaModel {
        /// <summary>
        /// <para>The addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// <para>The album.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FirstAlbum</para>
        /// </summary>
        [NameInMap("Album")]
        [Validation(Required=false)]
        public string Album { get; set; }

        /// <summary>
        /// <para>The album artist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("AlbumArtist")]
        [Validation(Required=false)]
        public string AlbumArtist { get; set; }

        /// <summary>
        /// <para>The artist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("Artist")]
        [Validation(Required=false)]
        public string Artist { get; set; }

        /// <summary>
        /// <para>The composer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("Composer")]
        [Validation(Required=false)]
        public string Composer { get; set; }

        /// <summary>
        /// <para>In most cases, you can leave this parameter empty. The Multipurpose Internet Mail Extensions (MIME) type of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/jpeg</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The custom ID of the file. This parameter is optional. When the metadata of the file is indexed into the dataset, the custom ID is stored as the data attribute. You can map the custom ID to other data in your business system. You can configure this parameter based on your business requirements. For example, you can associate a URI with an ID in your business system. We recommend that you set this parameter to a unique value.</para>
        /// <para>This parameter supports prefix searches and sorting during queries. For more information, see <a href="https://help.aliyun.com/document_detail/252856.html">Supported fields and operators</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>member-image-id-0001</para>
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// <para>The custom labels of the file. This parameter is optional. The parameter stores custom key-value labels, which can be used to filter data. For more information, see <a href="https://help.aliyun.com/document_detail/252856.html">Supported fields and operators</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;MemberName&quot;: &quot;Tim&quot;,
        ///       &quot;Enabled&quot;: &quot;True&quot;,
        ///       &quot;ItemCount&quot;: &quot;10&quot;
        /// }</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// <para>This parameter is optional. The persons. This parameter is used to remove a face from a face group or modify a face group. For more information, see <a href="https://help.aliyun.com/document_detail/477175.html">Face clustering</a>.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for the UpdateFileMeta or BatchUpdateFileMeta operation.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Figures")]
        [Validation(Required=false)]
        public List<InputFileFigures> Figures { get; set; }
        public class InputFileFigures : TeaModel {
            /// <summary>
            /// <para>The ID of the face cluster. The following IDs of special face clusters are reserved:</para>
            /// <list type="bullet">
            /// <item><description>figure-cluster-id-independent: indicates that the face does not belong to any face cluster. The face may be added to a face cluster in subsequent face clustering tasks after new images are added to the dataset.</description></item>
            /// <item><description>figure-cluster-id-unavailable: indicates that the face has not been included in a face clustering task since a new image was added to the dataset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Cluster-dbe72fec-b84c-4ab6-885b-3678e64****</para>
            /// </summary>
            [NameInMap("FigureClusterId")]
            [Validation(Required=false)]
            public string FigureClusterId { get; set; }

            /// <summary>
            /// <para>The person ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2cb3c51e-b406-4b0c-af1b-897d88e1****</para>
            /// </summary>
            [NameInMap("FigureId")]
            [Validation(Required=false)]
            public string FigureId { get; set; }

            /// <summary>
            /// <para>The figure type. Set this parameter to <c>face</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>face</para>
            /// </summary>
            [NameInMap("FigureType")]
            [Validation(Required=false)]
            public string FigureType { get; set; }

        }

        /// <summary>
        /// <para>The file hash. In most cases, you can leave this parameter empty. This parameter is required only when the URI parameter specifies a file in Photo and Drive Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d9c280a7c4f67f7ef873e28449dbe17</para>
        /// </summary>
        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        /// <summary>
        /// <para>The intelligent labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The GPS latitude and longitude information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30.134390,120.074997</para>
        /// </summary>
        [NameInMap("LatLong")]
        [Validation(Required=false)]
        public string LatLong { get; set; }

        /// <summary>
        /// <para>In most cases, you can leave this parameter empty. The media type of the file.</para>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>image</description></item>
        /// <item><description>other</description></item>
        /// <item><description>document</description></item>
        /// <item><description>archive</description></item>
        /// <item><description>video</description></item>
        /// <item><description>audio</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The path of the OSS object. In most cases, you can leave this parameter empty. You can specify this parameter only if the URI parameter specifies a file in Photo and Drive Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.jpg</para>
        /// </summary>
        [NameInMap("OSSURI")]
        [Validation(Required=false)]
        public string OSSURI { get; set; }

        /// <summary>
        /// <para>The performer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("Performer")]
        [Validation(Required=false)]
        public string Performer { get; set; }

        /// <summary>
        /// <para>The time when the image was taken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("ProduceTime")]
        [Validation(Required=false)]
        public string ProduceTime { get; set; }

        /// <summary>
        /// <para>The file title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The URI of the file for which you want to create or update an index in the request. This parameter is required. The URI can represent an object in Object Storage Service (OSS) or a file in Photo and Drive Service.</para>
        /// <para>The OSS URI must be in the oss://${Bucket}/${Object} format. <c>${Bucket}</c> specifies the name of the OSS bucket that is in the same region as the current project. <c>${Object}</c> specifies the full file path that contains the object name extension.</para>
        /// <para>The URI of a file in Photo and Drive Service must be in the <c>pds://domains/${domain}/drives/${drive}/files/${file}/revisions/${revision}</c> format.</para>
        /// <remarks>
        /// <para> URIs that start with HTTP are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/sampleobject.jpg</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
