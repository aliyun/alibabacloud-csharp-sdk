// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateSwimmingLaneRequest : TeaModel {
        /// <summary>
        /// <para>The list of applications that are related to the lane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;appId&quot;:&quot;8e7689af-6ddd-4676-8ee6-5fbecdf2****&quot;},{&quot;appId&quot;:&quot;f72deaac-26ba-429a-948d-5fa47c4a****&quot;},{&quot;appId&quot;:&quot;99a2d4b5-99a5-4e25-a964-1bd03a17****&quot;}]</para>
        /// </summary>
        [NameInMap("AppInfos")]
        [Validation(Required=false)]
        public string AppInfos { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the throttling rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRules")]
        [Validation(Required=false)]
        public bool? EnableRules { get; set; }

        /// <summary>
        /// <para>The configuration of the throttling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;priority&quot;:1,&quot;path&quot;:&quot;/traffictest&quot;,&quot;condition&quot;:&quot;AND&quot;,&quot;restItems&quot;:[{&quot;type&quot;:&quot;header&quot;,&quot;name&quot;:&quot;testheader&quot;,&quot;value&quot;:&quot;testheadervalue&quot;,&quot;cond&quot;:&quot;==&quot;,&quot;operator&quot;:&quot;rawvalue&quot;}]}]</para>
        /// </summary>
        [NameInMap("EntryRules")]
        [Validation(Required=false)]
        public string EntryRules { get; set; }

        /// <summary>
        /// <para>The ID of the lane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>224</para>
        /// </summary>
        [NameInMap("LaneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        /// <summary>
        /// <para>The name of the lane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-swimlane</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
