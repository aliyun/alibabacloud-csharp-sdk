// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateEdgeFunctionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The code parameters.</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string CodeShrink { get; set; }

        /// <summary>
        /// <para>The configuration parameters of the edge function.</para>
        /// </summary>
        [NameInMap("CustomConfig")]
        [Validation(Required=false)]
        public string CustomConfigShrink { get; set; }

        /// <summary>
        /// <para>The name of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ef-*****</para>
        /// </summary>
        [NameInMap("EdgeFunctionName")]
        [Validation(Required=false)]
        public string EdgeFunctionName { get; set; }

        /// <summary>
        /// <para>The environment variables.</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string EnvsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the RDS Supabase instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
