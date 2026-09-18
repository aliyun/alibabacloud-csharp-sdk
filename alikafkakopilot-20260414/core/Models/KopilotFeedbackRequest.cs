// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaKopilot20260414.Models
{
    public class KopilotFeedbackRequest : TeaModel {
        /// <summary>
        /// <para>The user feedback comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>good</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The user satisfaction level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: satisfied</description></item>
        /// <item><description>-1: not satisfied</description></item>
        /// <item><description>0: cancel the evaluation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e356c91c-8220-425c-9d86-********</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The primary key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5243231*****</para>
        /// </summary>
        [NameInMap("TurnId")]
        [Validation(Required=false)]
        public string TurnId { get; set; }

    }

}
