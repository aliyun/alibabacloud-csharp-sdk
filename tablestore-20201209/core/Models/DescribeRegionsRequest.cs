// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>A parameter to ensure idempotence.</para>
        /// <remarks>
        /// <para>This parameter ensures that each request is processed only once. Generate a unique value on the client for each request. The value can be up to 64 ASCII characters long and must not contain non-ASCII characters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
