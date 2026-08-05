// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveAIProduceRulesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the live stream application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppName</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The primary streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

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

        /// <summary>
        /// <para>The subtitle rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d -8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("RulesId")]
        [Validation(Required=false)]
        public string RulesId { get; set; }

        /// <summary>
        /// <para>The subtitle suffix. This parameter is required. Otherwise, the InvalidParameter error is returned.</para>
        /// <remarks>
        /// <para>Set this parameter to the value of SubtitleName that is specified in the subtitle template.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>et</para>
        /// </summary>
        [NameInMap("SuffixName")]
        [Validation(Required=false)]
        public string SuffixName { get; set; }

    }

}
