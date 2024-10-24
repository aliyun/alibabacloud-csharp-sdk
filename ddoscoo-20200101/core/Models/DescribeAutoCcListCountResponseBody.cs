// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcListCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of IP addresses in the blacklist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BlackCount")]
        [Validation(Required=false)]
        public int? BlackCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5AC3785F-C789-4622-87A4-F58BE7F6B184</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of IP addresses in the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("WhiteCount")]
        [Validation(Required=false)]
        public int? WhiteCount { get; set; }

    }

}
