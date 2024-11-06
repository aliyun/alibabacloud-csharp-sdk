// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>AppKey。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ba133b2cee4ab9be424674892c33****</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>154EF5DE-3D08-1F2C-A482-281F78D74B7C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
