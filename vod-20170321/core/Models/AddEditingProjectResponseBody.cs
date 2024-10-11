// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddEditingProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the online editing project. For more information about the structure, see <a href="https://help.aliyun.com/document_detail/52839.html">EditingProject</a>.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public AddEditingProjectResponseBodyProject Project { get; set; }
        public class AddEditingProjectResponseBodyProject : TeaModel {
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
            /// <para>testtimeline001desciption</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the online editing project was last modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
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
            /// <para>fb2101bf24bf4df34c4cb3187****</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The status of the online editing project. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: the online editing project is in draft.</description></item>
            /// <item><description><b>Producing</b>: the video is being produced.</description></item>
            /// <item><description><b>Produced</b>: the video is produced.</description></item>
            /// <item><description><b>ProduceFailed</b>: the video failed to be produced.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The title of the online editing project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testtimeline</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4EBD2BF-5EB0-4476-8829-9D94E1B1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
