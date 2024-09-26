// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateBaselineShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the alerting feature. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AlertEnabled")]
        [Validation(Required=false)]
        public bool? AlertEnabled { get; set; }

        /// <summary>
        /// <para>The alert margin threshold of the baseline. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("AlertMarginThreshold")]
        [Validation(Required=false)]
        public int? AlertMarginThreshold { get; set; }

        /// <summary>
        /// <para>The alert settings of the baseline.</para>
        /// </summary>
        [NameInMap("AlertSettings")]
        [Validation(Required=false)]
        public string AlertSettingsShrink { get; set; }

        /// <summary>
        /// <para>The baseline ID. You can call the <a href="https://help.aliyun.com/document_detail/2261507.html">ListBaselines</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000010800007</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

        /// <summary>
        /// <para>The name of the baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BaselineName</para>
        /// </summary>
        [NameInMap("BaselineName")]
        [Validation(Required=false)]
        public string BaselineName { get; set; }

        /// <summary>
        /// <para>The type of the baseline. Valid values: DAILY and HOURLY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAILY</para>
        /// </summary>
        [NameInMap("BaselineType")]
        [Validation(Required=false)]
        public string BaselineType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the baseline. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The ancestor nodes of nodes in the baseline. Separate the ancestor nodes with commas (,). If a large number of ancestor nodes exist, we recommend that you create a zero load node and configure the zero load node as the descendant node of nodes in the baseline to facilitate node management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>The settings of the committed completion time of the baseline.</para>
        /// </summary>
        [NameInMap("OvertimeSettings")]
        [Validation(Required=false)]
        public string OvertimeSettingsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account used by the baseline owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3726346****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The priority of the baseline. Valid values: {1,3,5,7,8}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call the <a href="https://help.aliyun.com/document_detail/2261507.html">ListBaselines</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2043</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The ID of the node that you want to disassociate from the baseline. You can specify multiple node IDs. Separate multiple node IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("RemoveNodeIds")]
        [Validation(Required=false)]
        public string RemoveNodeIds { get; set; }

    }

}
