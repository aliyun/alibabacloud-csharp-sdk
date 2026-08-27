// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateScratchRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the resource scenario.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The data display option. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Sources: displays only source node data. This value is applicable when TemplateScratchType is set to ArchitectureDetection.</para>
        /// </description></item>
        /// <item><description><para>Source: displays only source node data. This value is applicable when TemplateScratchType is not set to ArchitectureDetection.</para>
        /// </description></item>
        /// <item><description><para>Provisions: displays only new node data. This value is applicable when TemplateScratchType is not set to ArchitectureDetection.</para>
        /// </description></item>
        /// <item><description><para>All: displays all data.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about source nodes and new nodes, see <a href="https://help.aliyun.com/document_detail/352074.html">Overview</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, node data is not displayed by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Source</para>
        /// </summary>
        [NameInMap("ShowDataOption")]
        [Validation(Required=false)]
        public string ShowDataOption { get; set; }

        /// <summary>
        /// <para>The ID of the resource scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ts-7f7a704cf71c49a6****</para>
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

    }

}
