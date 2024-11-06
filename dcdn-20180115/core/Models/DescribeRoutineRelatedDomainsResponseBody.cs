// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeRoutineRelatedDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names associated with a routine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Domains&quot;: [
        ///             &quot;xxx.com&quot;,
        ///             &quot;yyy.com&quot;,
        ///             ...
        ///         ]</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC0E34AC-0239-44A7-AB0E-800DE522C8DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
