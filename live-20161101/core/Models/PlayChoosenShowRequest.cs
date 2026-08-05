// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class PlayChoosenShowRequest : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the CasterId parameter in the response.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, navigate to <b>ApsaraVideo Live console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> to view the production studio name.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The production studio name in the production studio list on the Cloud Production Studio page is the production studio ID.</description></item>
        /// <item><description>The production studio must be in the running (Status=1) state. Otherwise, the IncorrectCasterStatus error is returned. For a production studio in the idle state, call StartCaster to start the production studio first.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

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
        /// <para>The ID of the show to switch to.</para>
        /// <remarks>
        /// <para>You can obtain the ShowId value from the response parameters of the <a href="https://help.aliyun.com/document_detail/2848051.html">AddShowIntoShowList</a> or <a href="https://help.aliyun.com/document_detail/2848054.html">DescribeShowList</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

    }

}
