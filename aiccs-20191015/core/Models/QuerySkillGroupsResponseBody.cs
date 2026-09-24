// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QuerySkillGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QuerySkillGroupsResponseBodyData> Data { get; set; }
        public class QuerySkillGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The channel type of the skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public int? ChannelType { get; set; }

            /// <summary>
            /// <para>The description of the skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automation skill group</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automation skill group</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public long? SkillGroupId { get; set; }

            /// <summary>
            /// <para>The name of the skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automation skill group</para>
            /// </summary>
            [NameInMap("SkillGroupName")]
            [Validation(Required=false)]
            public string SkillGroupName { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("OnePageSize")]
        [Validation(Required=false)]
        public int? OnePageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76</para>
        /// </summary>
        [NameInMap("TotalResults")]
        [Validation(Required=false)]
        public int? TotalResults { get; set; }

    }

}
