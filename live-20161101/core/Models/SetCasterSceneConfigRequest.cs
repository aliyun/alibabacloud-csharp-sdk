// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetCasterSceneConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/69338.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
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
        /// <para>The IDs of the components. Components in the scene are listed from the bottom to the top in an array.</para>
        /// <remarks>
        /// <para> N indicates a sequence number. Examples:\
        /// ComponentId.1 indicates the ID of the first component.\
        /// ComponentId.2 indicates the ID of the second component.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[ &quot;a2b8e671-2fe5-4642-a2ec-bf931826****&quot;, &quot;a2b8e671-2fe5-4642-a2ec-28374657****&quot;]</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public List<string> ComponentId { get; set; }

        /// <summary>
        /// <para>The ID of the layout. If you call the <a href="https://help.aliyun.com/document_detail/60260.html">DescribeCasterLayouts</a> operation to query the layouts of the production studio, check the value of the response parameter LayoutId to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c6da077-f037-49e8-8440-3be13393****</para>
        /// </summary>
        [NameInMap("LayoutId")]
        [Validation(Required=false)]
        public string LayoutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
