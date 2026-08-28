// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListAgentIMChannelsRequest : TeaModel {
        /// <summary>
        /// <para>The IM channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DINGTALK: DingTalk.</description></item>
        /// <item><description>FEISHU: Lark.</description></item>
        /// <item><description>WECOM: WeCom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DINGTALK</para>
        /// </summary>
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page. Default value: 20. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. You do not need to specify this parameter for the first request. For subsequent requests, use the nextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The IM channel status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATING: being created.</description></item>
        /// <item><description>READY: ready.</description></item>
        /// <item><description>UPDATING: being updated.</description></item>
        /// <item><description>FAILED: failed.</description></item>
        /// <item><description>DELETING: being deleted.</description></item>
        /// <item><description>DELETE_FAILED: deletion failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
