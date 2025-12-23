// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GenerateMergedTableRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Schema Body { get; set; }

        /// <summary>
        /// <para>The specifications of the OpenSearch instance. This parameter is used to check whether the OpenSearch instance meets the special limits on an exclusive instance.</para>
        /// <para>Default value: opensearch.share.common.</para>
        /// <para>For more information, see the description of the spec field in the Quota topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;opensearch.share.common&quot;</para>
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
