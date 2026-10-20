// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RunClusterCheckResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The check ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1697100584236******-ce0da5a1d627e4e9e9f96cae8ad******-clustercheck-lboto</para>
        /// </summary>
        [NameInMap("check_id")]
        [Validation(Required=false)]
        public string CheckId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F04DF81D-5C12-1524-B36A-86E025******</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

