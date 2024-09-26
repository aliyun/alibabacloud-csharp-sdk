// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>用于手机app的小蜜机器人</para>
        /// </summary>
        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-cn</para>
        /// </summary>
        [NameInMap("LanguageCode")]
        [Validation(Required=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>小蜜机器人</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>scenario_im</para>
        /// </summary>
        [NameInMap("RobotType")]
        [Validation(Required=false)]
        public string RobotType { get; set; }

    }

}
