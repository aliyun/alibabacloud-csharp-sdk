// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteAlertRobotsRequest : TeaModel {
        /// <summary>
        /// <para>The chatbot ID.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("robotIds")]
        [Validation(Required=false)]
        public List<string> RobotIds { get; set; }

        /// <summary>
        /// <para>The chatbot type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DING</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
