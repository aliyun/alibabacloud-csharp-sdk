// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListGroupChatMessagesRequest : TeaModel {
        /// <summary>
        /// <para>Cloud Contact Center instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Call ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chat-65382141036853491</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Token for the next page. This is a 32-character UUID. Leave this parameter empty when requesting the first page. For subsequent pages, use the NextPageToken value from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b2ad450b116e4f8396e58108acf5c020</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>Page size. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Sorting order. Default is descending.</para>
        /// <para>Valid values:</para>
        /// <para>ASC: ascending.</para>
        /// <para>DESC: descending.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
