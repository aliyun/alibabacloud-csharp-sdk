// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppCallbackSecretKeyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>a656b296a30xxxxxxxxxx1cd4</para>
        /// </summary>
        [NameInMap("CallbackSecretKey")]
        [Validation(Required=false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
