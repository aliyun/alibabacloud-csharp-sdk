// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListTongyiChatHistorysRequest : TeaModel {
        /// <summary>
        /// <para>The key of the business space. If this parameter is not specified, the default business space is accessed. You can obtain the key value on the business management page of the primary account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is in the yyyy-MM-dd HH:mm:ss format, such as 2024-04-01 08:00:00.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-01 08:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of data entries. Default value: 30. Maximum value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The ID of the robot instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-7QuUfaqMQe</para>
        /// </summary>
        [NameInMap("RobotInstanceId")]
        [Validation(Required=false)]
        public string RobotInstanceId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is in the yyyy-MM-dd HH:mm:ss format, such as 2024-04-01 00:00:00.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
