// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentVertexNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The types of the edges that you want to query.</para>
        /// </summary>
        [NameInMap("EdgeLabelList")]
        [Validation(Required=false)]
        public string EdgeLabelListShrink { get; set; }

        /// <summary>
        /// <para>The page number. Valid values start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The ID of the node that you want to query.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~QueryIncidentTracingDetail~~">QueryIncidentTracingDetail</a> operation to query the node ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d6d7738a34cc252219866d223c0093f8</para>
        /// </summary>
        [NameInMap("VertexId")]
        [Validation(Required=false)]
        public string VertexId { get; set; }

        /// <summary>
        /// <para>The node label. Valid values include but are not limited to:</para>
        /// <list type="bullet">
        /// <item><description><b>process</b></description></item>
        /// <item><description><b>file</b></description></item>
        /// <item><description><b>alert</b></description></item>
        /// <item><description><b>ip</b></description></item>
        /// <item><description><b>domain</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>process</para>
        /// </summary>
        [NameInMap("VertexLabel")]
        [Validation(Required=false)]
        public string VertexLabel { get; set; }

    }

}
