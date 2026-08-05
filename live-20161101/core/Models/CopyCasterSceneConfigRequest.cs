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
        /// <item><description><para>If you create a production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, use the CasterId value that is returned in the response.</para>
        /// </description></item>
        /// <item><description><para>If you create a production studio in the ApsaraVideo Live console, go to the <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> page. The ID of the production studio is in the <b>Instance ID/Name</b> column.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The production studio name in the list on the Cloud Production Studio page of the ApsaraVideo Live console is the production studio ID.</para>
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
        /// <para>The ID of the source scene. The scene must be a PVW scene.</para>
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
        /// <para>The ID of the destination scene. The scene must be a PGM scene.</para>
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
