// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class EventCenterQueryEventsShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        [NameInMap("BusName")]
        [Validation(Required=false)]
        public string BusName { get; set; }

        /// <summary>
        /// 本次读取的最大数据量，默认值为100。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 用来标记当前开始读取的位置。置空表示从头开始。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
