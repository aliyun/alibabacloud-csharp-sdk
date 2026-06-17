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
        /// <para>The start time for filtering memories by creation time. Must be in UTC and ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-MM-ddTHH:mm:ssZ</para>
        /// </summary>
        [NameInMap("CreateTimeBegin")]
        [Validation(Required=false)]
        public string CreateTimeBegin { get; set; }

        /// <summary>
        /// <para>The end time for filtering memories by creation time. Must be in UTC and ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-MM-ddTHH:mm:ssZ</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The agent ID associated with the memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent1</para>
        /// </summary>
        [NameInMap("MemoryAgentId")]
        [Validation(Required=false)]
        public string MemoryAgentId { get; set; }

        /// <summary>
        /// <para>The user ID associated with the memory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("MemoryUserId")]
        [Validation(Required=false)]
        public string MemoryUserId { get; set; }

        /// <summary>
        /// <para>The search query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>who are you</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public string TopK { get; set; }

    }

}
