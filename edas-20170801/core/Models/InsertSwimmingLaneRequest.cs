// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertSwimmingLaneRequest : TeaModel {
        /// <summary>
        /// <para>The information about applications related to the lane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;appId&quot;:&quot;f72deaac-26ba-429a-948d-5fa47c4a****&quot;},{&quot;appId&quot;:&quot;5049d2c8-f997-4fc9-92a2-153506a6****&quot;}]</para>
        /// </summary>
        [NameInMap("AppInfos")]
        [Validation(Required=false)]
        public string AppInfos { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the throttling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRules")]
        [Validation(Required=false)]
        public bool? EnableRules { get; set; }

        /// <summary>
        /// <para>The throttling conditions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;priority&quot;:1,&quot;path&quot;:&quot;/traffic&quot;,&quot;condition&quot;:&quot;AND&quot;,&quot;restItems&quot;:[{&quot;type&quot;:&quot;header&quot;,&quot;name&quot;:&quot;testheader&quot;,&quot;value&quot;:&quot;testvalue&quot;,&quot;cond&quot;:&quot;==&quot;,&quot;operator&quot;:&quot;rawvalue&quot;}]}]</para>
        /// </summary>
        [NameInMap("EntryRules")]
        [Validation(Required=false)]
        public string EntryRules { get; set; }

        /// <summary>
        /// <para>The ID of the lane group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the custom namespace. The ID is in the <c>physical region ID:custom namespace identifier</c> format. Example: <c>cn-hangzhou:test</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// <para>The name of the lane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The tag.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
