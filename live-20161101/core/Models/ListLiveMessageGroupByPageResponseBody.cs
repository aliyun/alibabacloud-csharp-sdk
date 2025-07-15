// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveMessageGroupByPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of groups.</para>
        /// </summary>
        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<ListLiveMessageGroupByPageResponseBodyGroupList> GroupList { get; set; }
        public class ListLiveMessageGroupByPageResponseBodyGroupList : TeaModel {
            /// <summary>
            /// <para>The list of administrators.</para>
            /// </summary>
            [NameInMap("AdminList")]
            [Validation(Required=false)]
            public List<string> AdminList { get; set; }

            /// <summary>
            /// <para>The time when the group was created. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1698299727</para>
            /// </summary>
            [NameInMap("Createtime")]
            [Validation(Required=false)]
            public long? Createtime { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_77</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>Indicates whether the group is deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Delete")]
            [Validation(Required=false)]
            public bool? Delete { get; set; }

            /// <summary>
            /// <para>The ID of the interactive messaging group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cU9MeBqf****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The additional information about the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testgroupinfo</para>
            /// </summary>
            [NameInMap("GroupInfo")]
            [Validation(Required=false)]
            public string GroupInfo { get; set; }

            /// <summary>
            /// <para>The name of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mytestgroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B5D95365-5A46-1A6A-BBF5-C7B6BDED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
