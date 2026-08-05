// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateCasterSceneConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description><para>If you create a production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, use the CasterId value from the response.</para>
        /// </description></item>
        /// <item><description><para>If you create a production studio in the ApsaraVideo Live console, find the ID on the <b>Cloud Production Studio</b> page. Navigate to this page by choosing <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> in the ApsaraVideo Live console.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the production studio in the list is its ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80787064-1c94-4dc1-85ce-9409960a****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>A list of component IDs. The components in the array are layered from bottom to top.</para>
        /// <remarks>
        /// <para>N indicates the sequence number. For example, ComponentId.1 is the ID of the first component and ComponentId.2 is the ID of the second component.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;98778372-c30f-4442-85ba-2e3e4e3d****&quot;]</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public List<string> ComponentId { get; set; }

        /// <summary>
        /// <para>The ID of the layout. If you query the layout list for the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848028.html">DescribeCasterLayouts</a> operation, use the LayoutId value from the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eeab74fb-379d-4599-a93d-86d16a05****</para>
        /// </summary>
        [NameInMap("LayoutId")]
        [Validation(Required=false)]
        public string LayoutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the scene.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>242b4e2c-c30f-4442-85ba-2e3e4e3d****</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
