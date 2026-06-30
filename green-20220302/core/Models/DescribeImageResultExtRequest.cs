// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeImageResultExtRequest : TeaModel {
        /// <summary>
        /// <para>The type of information to obtain. Multiple values are separated by commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>customImage: custom image library hit information</para>
        /// </description></item>
        /// <item><description><para>textInImage: text information in the image</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customImage,textInImage</para>
        /// </summary>
        [NameInMap("InfoType")]
        [Validation(Required=false)]
        public string InfoType { get; set; }

        /// <summary>
        /// <para>The requestId field returned by the enhanced image moderation API</para>
        /// 
        /// <b>Example:</b>
        /// <para>638EDDC65C82AB39319A9F60</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

    }

}
