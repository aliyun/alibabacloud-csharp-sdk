// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTicketsRequest : TeaModel {
        /// <summary>
        /// <para>Ticket ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223468****</para>
        /// </summary>
        [NameInMap("CaseId")]
        [Validation(Required=false)]
        public long? CaseId { get; set; }

        /// <summary>
        /// <para>Ticket status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CaseStatus")]
        [Validation(Required=false)]
        public int? CaseStatus { get; set; }

        /// <summary>
        /// <para>Ticket type code (assigned by the system).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1223</para>
        /// </summary>
        [NameInMap("CaseType")]
        [Validation(Required=false)]
        public int? CaseType { get; set; }

        /// <summary>
        /// <para>Channel ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02acfefd3fa14049826ac1a89e1xxxxx</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>Channel Type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not filled in</description></item>
        /// <item><description><b>1</b>: Hotline</description></item>
        /// <item><description><b>2</b>: Online</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public int? ChannelType { get; set; }

        /// <summary>
        /// <para>Current page. Default Value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Assignee ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DealId")]
        [Validation(Required=false)]
        public long? DealId { get; set; }

        /// <summary>
        /// <para>Additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>Log on to the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a> and view the instance ID in <b>Instance Management</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page size. Default Value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29506</para>
        /// </summary>
        [NameInMap("SrType")]
        [Validation(Required=false)]
        public long? SrType { get; set; }

        /// <summary>
        /// <para>Job status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

        /// <summary>
        /// <para>Touch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15030609</para>
        /// </summary>
        [NameInMap("TouchId")]
        [Validation(Required=false)]
        public long? TouchId { get; set; }

    }

}
