// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppAssistantAgentRequest : TeaModel {
        /// <summary>
        /// <para>Agent name</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试业务空间</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250731233102000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Platform type</para>
        /// 
        /// <b>Example:</b>
        /// <para>LINUX64</para>
        /// </summary>
        [NameInMap("PlatformType")]
        [Validation(Required=false)]
        public string PlatformType { get; set; }

    }

}
