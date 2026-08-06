// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class SearchMemoriesRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The start time for memory creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-MM-ddTHH:mm:ssZ</para>
        /// </summary>
        [NameInMap("CreateTimeBegin")]
        [Validation(Required=false)]
        public string CreateTimeBegin { get; set; }

        /// <summary>
        /// <para>The end time for memory creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-MM-ddTHH:mm:ssZ</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The memory agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent1</para>
        /// </summary>
        [NameInMap("MemoryAgentId")]
        [Validation(Required=false)]
        public string MemoryAgentId { get; set; }

        /// <summary>
        /// <para>The memory user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("MemoryUserId")]
        [Validation(Required=false)]
        public string MemoryUserId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>who are you</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Specifies the number of top results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public string TopK { get; set; }

    }

}
