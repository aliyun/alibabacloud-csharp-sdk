// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteCasterSceneConfigRequest : TeaModel {
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
        /// <para>b4810848-bcf9-4aef-bd4a-e6bba2d9****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

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
        /// <para>b5f8c837-ceeb-424f-b30b-68e94e86****</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The type of the setting that you want to delete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Component</b>: component setting</description></item>
        /// <item><description><b>Layout</b>: layout setting</description></item>
        /// <item><description><b>All</b>: component and layout settings</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Component</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
