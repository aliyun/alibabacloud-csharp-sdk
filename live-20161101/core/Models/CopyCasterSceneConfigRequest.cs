// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CopyCasterSceneConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The ID of the source scene, which must be a PVW scene.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1a361f4-bee3-436d-ae6e-d38e6943****</para>
        /// </summary>
        [NameInMap("FromSceneId")]
        [Validation(Required=false)]
        public string FromSceneId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the destination scene, which must be a PGM scene.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05ab713c-676e-49c0-96ce-cc408da1****</para>
        /// </summary>
        [NameInMap("ToSceneId")]
        [Validation(Required=false)]
        public string ToSceneId { get; set; }

    }

}
