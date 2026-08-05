// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeStudioLayoutsRequest : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the CasterId parameter value returned by the CreateCaster operation.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, go to <b>ApsaraVideo Live console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The production studio name in the production studio list on the Cloud Production Studio page is the production studio ID.</description></item>
        /// <item><description>Only virtual studio production studios (NormType=4) are supported. If you pass in a production studio ID of another type, InvalidCaster.NotFound is returned. Call DescribeCasters and filter by NormType=4 to obtain the virtual studio production studio ID.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0d-f228-4a64-af62-20e91b96****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The layout ID.
        /// Separate multiple layout IDs with commas (,). If this parameter is not specified, all layouts under the production studio are returned.</para>
        /// <para>If you added virtual studio layout settings by calling the <a href="https://help.aliyun.com/document_detail/2848062.html">AddStudioLayout</a> operation, check the LayoutId parameter value returned by the AddStudioLayout operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
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

    }

}
