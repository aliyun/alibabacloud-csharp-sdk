// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeIMRobotsRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// The chatbot IDs.
        /// </summary>
        [NameInMap("RobotIds")]
        [Validation(Required=false)]
        public string RobotIds { get; set; }

        /// <summary>
        /// The name of the IM chatbot.
        /// </summary>
        [NameInMap("RobotName")]
        [Validation(Required=false)]
        public string RobotName { get; set; }

        /// <summary>
        /// The number of IM chatbots to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
