// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>Filter the returned results based on Chinese or English. For more information, see RFC7231. Valid values:</para>
        /// <para>zh-CN
        /// en-US
        /// Default value: zh-CN</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

    }

}
