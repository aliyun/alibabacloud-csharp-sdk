// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateCopilotConversationRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The model identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3.7-max</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The planning configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("PlanMode")]
        [Validation(Required=false)]
        public string PlanMode { get; set; }

        /// <summary>
        /// <para>The security project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-incident-****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The region of the data management center for threat analysis. Specify the management center region based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside in regions outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The deep thinking configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("ThinkingMode")]
        [Validation(Required=false)]
        public string ThinkingMode { get; set; }

        /// <summary>
        /// <para>The conversation title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Security incident investigation</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The trace ID of the created span object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400e29b41d4a71644665544****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
