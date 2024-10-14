// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeImageResultExtRequest : TeaModel {
        /// <summary>
        /// <para>The content of the information to be obtained. Multiple values are separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customImage,textInImage</para>
        /// </summary>
        [NameInMap("InfoType")]
        [Validation(Required=false)]
        public string InfoType { get; set; }

        /// <summary>
        /// <para>The reqId field returned by the Url Async Moderation API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>638EDDC65C82AB39319A9F60</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

    }

}
