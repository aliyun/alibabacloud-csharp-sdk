// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DeleteExecutionsRequest : TeaModel {
        /// <summary>
        /// <para>The execution IDs.</para>
        /// <para>You can specify multiple execution IDs in a JSON array in the format of <c>[&quot;xxxxxxxxx&quot;, &quot;yyyyyyyyy&quot;, ... &quot;zzzzzzzzz&quot;]</c>. You can specify up to 100 execution IDs at a time. Separate multiple IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;exec-xxx&quot;]</para>
        /// </summary>
        [NameInMap("ExecutionIds")]
        [Validation(Required=false)]
        public string ExecutionIds { get; set; }

        /// <summary>
        /// <para>Whether to force delete the running task, the default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
