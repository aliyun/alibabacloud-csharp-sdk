// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListMediaConvertTemplateGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned in the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination cursor for the next page, in the format of page_N. If this parameter is not returned, all data has been read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>page_2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of transcoding template groups.</para>
        /// </summary>
        [NameInMap("TemplateGroupList")]
        [Validation(Required=false)]
        public List<ListMediaConvertTemplateGroupResponseBodyTemplateGroupList> TemplateGroupList { get; set; }
        public class ListMediaConvertTemplateGroupResponseBodyTemplateGroupList : TeaModel {
            /// <summary>
            /// <para>The application ID. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Multiple applications</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The creation time. The time is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T08:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The group-level configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AutoStreamName&quot;:&quot;{RunId}_master&quot;}</para>
            /// </summary>
            [NameInMap("GroupConfig")]
            [Validation(Required=false)]
            public string GroupConfig { get; set; }

            /// <summary>
            /// <para>The modification time. The time is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T08:00:00Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the transcoding template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcTemplateGroup</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the template group. Valid values: <b>Normal</b>: normal transcoding template group; <b>VideoPackage</b>: video packaging template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4c71a339fe52b4fa6f4527****</para>
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

        }

        /// <summary>
        /// <para>The total number of transcoding template groups that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
