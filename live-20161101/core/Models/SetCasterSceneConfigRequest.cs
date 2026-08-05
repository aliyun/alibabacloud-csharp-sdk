// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetCasterSceneConfigRequest : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the CasterId parameter returned by the CreateCaster operation.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, go to <b>ApsaraVideo Live console</b> &gt; <b>Production Studios</b> &gt; <b>China Cloud Production Studio</b> to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the production studio in the production studio list on the China Cloud Production Studio page is the production studio ID.</para>
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
        /// <para>The list of component IDs. The components are arranged in bottom-to-top order within the array.</para>
        /// <remarks>
        /// <para>N indicates the sequence number. For example:<br>ComponentId.1 indicates the first component ID.<br>ComponentId.2 indicates the second component ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[ &quot;a2b8e671-2fe5-4642-a2ec-bf931826****&quot;, &quot;a2b8e671-2fe5-4642-a2ec-28374657****&quot;]</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public List<string> ComponentId { get; set; }

        /// <summary>
        /// <para>The layout ID. If you call the <a href="https://help.aliyun.com/document_detail/2848028.html">DescribeCasterLayouts</a> operation to query the layout list of a production studio, check the LayoutId parameter returned by the DescribeCasterLayouts operation.</para>
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
        /// <para>The scene ID. The scene must have been started by calling StartCasterScene. Otherwise, the IncorrectSceneStatus error is returned.</para>
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
