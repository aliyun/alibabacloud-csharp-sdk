// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The key of the agent. If you omit this parameter, the default agent is used. You can find the key on the Business Management page of your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>A description of the robot. The description can be up to 50 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于手机app的小蜜机器人</para>
        /// </summary>
        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// <para>The language of the robot, such as <c>zh-cn</c> or <c>en-us</c>. The language must be supported by the agent. If you omit this parameter, the agent\&quot;s default language is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-cn</para>
        /// </summary>
        [NameInMap("LanguageCode")]
        [Validation(Required=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>The name of the robot. The maximum length is 50 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>小蜜机器人</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The robot type. The default value is <c>scenario_im</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scenario_im</para>
        /// </summary>
        [NameInMap("RobotType")]
        [Validation(Required=false)]
        public string RobotType { get; set; }

    }

}
