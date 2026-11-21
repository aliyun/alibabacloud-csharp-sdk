// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpsertUmodelDataRequest : TeaModel {
        /// <summary>
        /// <para>The content of the elements.</para>
        /// </summary>
        [NameInMap("elements")]
        [Validation(Required=false)]
        public List<object> Elements { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: sends a check request without performing actual changes.</description></item>
        /// <item><description>false: sends a normal request.
        /// Default value: false.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Upsert</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

    }

}
