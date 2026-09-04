// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetCopilotTurnByClientMessageIdRequest : TeaModel {
        /// <summary>
        /// <para>The client message ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>366932fb-9a83-4a2d-94dd-c925b35f****</para>
        /// </summary>
        [NameInMap("ClientMessageId")]
        [Validation(Required=false)]
        public string ClientMessageId { get; set; }

        /// <summary>
        /// <para>The conversation ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54b6c969-4b75-47be-9f43-71f88aeb****</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The language of the returned message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region where the Threat Analysis data management center is located. Specify the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets belong to the Chinese mainland or China (Hong Kong).</description></item>
        /// <item><description>ap-southeast-1: Your assets belong to regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Traces the service request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400e29b41d4a71644665544****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
