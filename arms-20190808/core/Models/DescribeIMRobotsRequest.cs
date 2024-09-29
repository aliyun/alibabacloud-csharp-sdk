// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeIMRobotsRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The chatbot IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RobotIds")]
        [Validation(Required=false)]
        public string RobotIds { get; set; }

        /// <summary>
        /// <para>The name of the IM chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chatbot name</para>
        /// </summary>
        [NameInMap("RobotName")]
        [Validation(Required=false)]
        public string RobotName { get; set; }

        /// <summary>
        /// <para>The number of IM chatbots to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
