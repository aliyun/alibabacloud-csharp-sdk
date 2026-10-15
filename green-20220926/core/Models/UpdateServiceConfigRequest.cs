// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class UpdateServiceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The client-generated idempotency token. It prevents duplicate operations caused by network retries and must be unique across different requests. Only printable ASCII characters (ASCII 32-126) are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable dry run mode. When set to true, only parameter validation and business logic checks are performed, and resources are not actually created or updated.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The document configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("FileConfig")]
        [Validation(Required=false)]
        public string FileConfig { get; set; }

        /// <summary>
        /// <para>The keyword filter libraries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("KeywordFilterLibs")]
        [Validation(Required=false)]
        public string KeywordFilterLibs { get; set; }

        /// <summary>
        /// <para>The matched keyword libraries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("KeywordHitLibs")]
        [Validation(Required=false)]
        public string KeywordHitLibs { get; set; }

        /// <summary>
        /// <para>The keyword library preprocessing configuration in JSON format. The format maps a libId to a list of preprocessing types, such as {&quot;libId&quot;:[&quot;fps&quot;]}. If this parameter is not passed, the configuration is not updated. An empty object {} clears all configurations. An empty array for a libId clears the configuration for that library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;libId&quot;:[&quot;fps&quot;]}</para>
        /// </summary>
        [NameInMap("KeywordLibProcessConf")]
        [Validation(Required=false)]
        public string KeywordLibProcessConf { get; set; }

        /// <summary>
        /// <para>The human-machine moderation configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ManualMachineConfig")]
        [Validation(Required=false)]
        public string ManualMachineConfig { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The moderation scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pornographic</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The scenario configuration information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("SceneConfig")]
        [Validation(Required=false)]
        public string SceneConfig { get; set; }

        /// <summary>
        /// <para>The service code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The service configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public string ServiceConfig { get; set; }

        /// <summary>
        /// <para>The video configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("VideoConfig")]
        [Validation(Required=false)]
        public string VideoConfig { get; set; }

    }

}
