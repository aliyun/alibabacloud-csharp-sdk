// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QuerySkillGroupsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QuerySkillGroupsResponseBodyData> Data { get; set; }
        public class QuerySkillGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public int? ChannelType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public long? SkillGroupId { get; set; }

            [NameInMap("SkillGroupName")]
            [Validation(Required=false)]
            public string SkillGroupName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("OnePageSize")]
        [Validation(Required=false)]
        public int? OnePageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>76</para>
        /// </summary>
        [NameInMap("TotalResults")]
        [Validation(Required=false)]
        public int? TotalResults { get; set; }

    }

}
