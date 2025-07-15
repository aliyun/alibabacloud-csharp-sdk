// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeStudioLayoutsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio instance.</para>
        /// <list type="bullet">
        /// <item><description>If you call the <a href="https://help.aliyun.com/document_detail/69338.html">CreateCaster</a> operation to create a production studio instance, you can obtain the instance ID from the CasterId parameter in the response.</description></item>
        /// <item><description>If you create a production studio instance in the ApsaraVideo Live console, perform the following operations to obtain the instance ID: Log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane. Then, view the instance ID on the <b>Production Studio Management</b> page.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value displayed in the Name column for an instance on the Production Studio Management page is the ID of the instance.</para>
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
        /// <para>The ID of the layout.</para>
        /// <para>You can specify multiple layout IDs and separate them with commas (,). If you leave this parameter empty, all layouts of the production studio are returned.</para>
        /// <para>If you call the <a href="https://help.aliyun.com/document_detail/215388.html">AddStudioLayout</a> operation to configure a layout for a virtual studio, you can obtain the ID of the layout from the LayoutId parameter in the response.</para>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
