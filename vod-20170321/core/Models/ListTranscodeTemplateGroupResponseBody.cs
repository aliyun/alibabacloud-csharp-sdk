// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListTranscodeTemplateGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The transcoding template groups.</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroupList")]
        [Validation(Required=false)]
        public List<ListTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupList> TranscodeTemplateGroupList { get; set; }
        public class ListTranscodeTemplateGroupResponseBodyTranscodeTemplateGroupList : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the template group was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-05T10:20:09Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the template group is the default one. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Default</b>: The template group is the default one.</description></item>
            /// <item><description><b>NotDefault</b>: The template group is not the default one.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// <para>The lock status of the transcoding template group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Disabled</b>: The template group is not locked.</description></item>
            /// <item><description><b>Enabled</b>: The template group is locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("Locked")]
            [Validation(Required=false)]
            public string Locked { get; set; }

            /// <summary>
            /// <para>The time when the template group was modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-05T10:22:09Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17a9889fc66852*****d791c886700932</para>
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

        }

    }

}
