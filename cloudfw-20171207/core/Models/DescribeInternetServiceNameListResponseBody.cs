// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetServiceNameListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91B01BCD-DFB0-5CA8-9191-5B38C62****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of application names.</para>
        /// </summary>
        [NameInMap("ServiceNameList")]
        [Validation(Required=false)]
        public List<string> ServiceNameList { get; set; }

    }

}
