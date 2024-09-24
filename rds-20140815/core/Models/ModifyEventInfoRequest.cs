// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyEventInfoRequest : TeaModel {
        /// <summary>
        /// <para>The action-related parameters. You can add action-related parameters based on your business requirements. The parameter value varies with the value of the TaskAction parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;recoverTime\&quot;:\&quot;2023-04-17T14:02:35Z\&quot;,\&quot;recoverMode\&quot;:\&quot;timePoint\&quot;}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <para>The event handling action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>archive</b></description></item>
        /// <item><description><b>undo</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>archive</para>
        /// </summary>
        [NameInMap("EventAction")]
        [Validation(Required=false)]
        public string EventAction { get; set; }

        /// <summary>
        /// <para>The event ID. You can call the DescribeEvents operation to obtain the IDs of the events. Separate multiple event IDs with commas (,). You can specify up to 20 event IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5422964</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/610399.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
