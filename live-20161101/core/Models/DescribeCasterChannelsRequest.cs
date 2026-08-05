// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterChannelsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description><para>If you call the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation to create a production studio, use the CasterId returned in the response.</para>
        /// </description></item>
        /// <item><description><para>If you create a production studio in the ApsaraVideo Live console, go to the <b>ApsaraVideo Live console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> page to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of a production studio in the list on the Cloud Production Studio page is the ID of the production studio.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
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

    }

}
