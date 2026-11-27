// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityResultRequest : TeaModel {
        /// <summary>
        /// <para>The channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: Online.</description></item>
        /// <item><description><b>hotline</b>: Hotline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The IDs of the skill groups.</para>
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public List<long?> GroupIds { get; set; }

        /// <summary>
        /// <para>The hit status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not hit.</description></item>
        /// <item><description><b>1</b>: Hit.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HitStatus")]
        [Validation(Required=false)]
        public int? HitStatus { get; set; }

        /// <summary>
        /// <para>Instance ID of the AICCS instance. You can obtain instance ID from the Artificial Intelligence Cloud Call Service console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The current page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IDs of the quality inspection tasks.</para>
        /// </summary>
        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public List<long?> ProjectIds { get; set; }

        /// <summary>
        /// <para>The IDs of the quality inspection rules.</para>
        /// </summary>
        [NameInMap("QualityRuleIds")]
        [Validation(Required=false)]
        public List<long?> QualityRuleIds { get; set; }

        /// <summary>
        /// <para>The end time of the session.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-04-18 16:04:20</para>
        /// </summary>
        [NameInMap("TouchEndTime")]
        [Validation(Required=false)]
        public string TouchEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the session.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-18 16:02:20</para>
        /// </summary>
        [NameInMap("TouchStartTime")]
        [Validation(Required=false)]
        public string TouchStartTime { get; set; }

    }

}
