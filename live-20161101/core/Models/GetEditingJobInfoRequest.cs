// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetEditingJobInfoRequest : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the CasterId parameter in the response.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, navigate to <b>ApsaraVideo Live console</b> &gt; <b>Production Studios</b> &gt; <b>Cloud Production Studio</b> to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The name of the production studio in the production studio list on the Cloud Production Studio page is the production studio ID.</description></item>
        /// <item><description>CasterId must be a production studio with NormType=6 (playlist mode). Using a production studio with other NormType values (such as 1 or 3) returns InvalidShowList.NotFound. You can filter by NormType=6 in the DescribeCasters response.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97****</para>
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
        /// <para>The ID of the show to query.</para>
        /// <remarks>
        /// <para>You can obtain the ShowId value from the response of the <a href="https://help.aliyun.com/document_detail/370861.html">AddShowIntoShowList</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>72200b81-b761-4c10-842a-a0726d97****</para>
        /// </summary>
        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

    }

}
