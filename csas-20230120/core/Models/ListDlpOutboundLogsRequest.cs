// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDlpOutboundLogsRequest : TeaModel {
        /// <summary>
        /// <para>The current page number, starting from 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the query. UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1754956800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The log ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>da817m4mfrcs6xxxx3hg</para>
        /// </summary>
        [NameInMap("LogId")]
        [Validation(Required=false)]
        public string LogId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The policy action. Single-value exact match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>block_and_hint</para>
        /// </summary>
        [NameInMap("PolicyAction")]
        [Validation(Required=false)]
        public string PolicyAction { get; set; }

        /// <summary>
        /// <para>The original file name. Fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestFile</para>
        /// </summary>
        [NameInMap("SrcFileName")]
        [Validation(Required=false)]
        public string SrcFileName { get; set; }

        /// <summary>
        /// <para>The start time of the query. UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1754870400</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The secondary channel ID in the format of <c>PrimaryChannelID.SubChannelID</c>. Separate multiple values with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.1,3.2</para>
        /// </summary>
        [NameInMap("SubChannelType")]
        [Validation(Required=false)]
        public string SubChannelType { get; set; }

        /// <summary>
        /// <para>The username. Exact match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
