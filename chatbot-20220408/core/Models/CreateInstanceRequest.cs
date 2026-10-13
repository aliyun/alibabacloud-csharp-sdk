// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The workspace key. If this parameter is not specified, the default workspace is accessed. Obtain the key value from the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The description of the chatbot. The description can be up to 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A sample chatbot for the mobile app</para>
        /// </summary>
        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// <para>The language of the chatbot service, such as zh-cn or en-us. Default value: the default language of the workspace. Valid values: the languages supported by the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-cn</para>
        /// </summary>
        [NameInMap("LanguageCode")]
        [Validation(Required=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>The name of the chatbot. The name can be up to 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleChatbot</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the chatbot. Default value: scenario_im.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scenario_im</para>
        /// </summary>
        [NameInMap("RobotType")]
        [Validation(Required=false)]
        public string RobotType { get; set; }

    }

}
