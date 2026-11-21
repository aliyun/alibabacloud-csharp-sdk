// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpsertUmodelCommonSchemaRefRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a check request without performing actual changes.</description></item>
        /// <item><description>false: Sends a normal request.
        /// Default value: false.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The public Umodel schema group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>card-service-daily01</para>
        /// </summary>
        [NameInMap("group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The version number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
