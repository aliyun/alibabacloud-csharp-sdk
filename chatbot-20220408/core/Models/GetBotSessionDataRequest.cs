// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GetBotSessionDataRequest : TeaModel {
        /// <summary>
        /// <para>The key for the workspace. If you omit this parameter, the operation uses the default workspace. You can find the key on the business management page of your main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The end time for the query. The format must be <c>yyyyMMdd</c>. For example: <c>20240605</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240605</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the bot instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-7QuUfaqMQe</para>
        /// </summary>
        [NameInMap("RobotInstanceId")]
        [Validation(Required=false)]
        public string RobotInstanceId { get; set; }

        /// <summary>
        /// <para>The start time for the query. The format must be <c>yyyyMMdd</c>. For example: <c>20240505</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240505</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
