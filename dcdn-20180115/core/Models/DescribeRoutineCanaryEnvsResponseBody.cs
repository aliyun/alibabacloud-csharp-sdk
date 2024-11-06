// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeRoutineCanaryEnvsResponseBody : TeaModel {
        /// <summary>
        /// <para>The canary release environments that are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>presetCanaryShanghai</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDCD94C0-F7FE-412F-B8F8-7E3C610C78E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
