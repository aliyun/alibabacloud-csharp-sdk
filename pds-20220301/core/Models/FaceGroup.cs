// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FaceGroup : TeaModel {
        /// <summary>
        /// <para>The time when the face-based group was generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:10:52.83948013+08:00</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The border of the image used as the cover the face-based group.</para>
        /// </summary>
        [NameInMap("group_cover_face_boundary")]
        [Validation(Required=false)]
        public FaceGroupGroupCoverFaceBoundary GroupCoverFaceBoundary { get; set; }
        public class FaceGroupGroupCoverFaceBoundary : TeaModel {
            /// <summary>
            /// <para>The height of the border. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <para>The distance from the left side of the photo to the border. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Left")]
            [Validation(Required=false)]
            public int? Left { get; set; }

            /// <summary>
            /// <para>The distance from the top of the photo to the border. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Top")]
            [Validation(Required=false)]
            public int? Top { get; set; }

            /// <summary>
            /// <para>The width of the border. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <para>The ID of the file used as the cover of the face-based group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6549c959640fbd517c9b4d93b3b36aecc45xxxxx</para>
        /// </summary>
        [NameInMap("group_cover_file_id")]
        [Validation(Required=false)]
        public string GroupCoverFileId { get; set; }

        /// <summary>
        /// <para>The height of the image used as the cover of the face-based group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("group_cover_height")]
        [Validation(Required=false)]
        public long? GroupCoverHeight { get; set; }

        /// <summary>
        /// <para>The URL of the image used as the cover of the face-based group.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx">https://xxx</a></para>
        /// </summary>
        [NameInMap("group_cover_url")]
        [Validation(Required=false)]
        public string GroupCoverUrl { get; set; }

        /// <summary>
        /// <para>The width of the image used as the cover of the face-based group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("group_cover_width")]
        [Validation(Required=false)]
        public long? GroupCoverWidth { get; set; }

        /// <summary>
        /// <para>The ID of the face-based group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster-ae6e3472-999e-410b-b54e-cd5dba****</para>
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the face-based group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The number of photos in the face-based group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("image_count")]
        [Validation(Required=false)]
        public long? ImageCount { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// </summary>
        [NameInMap("remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// <para>The time when the face-based group was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:10:52.83948013+08:00</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
