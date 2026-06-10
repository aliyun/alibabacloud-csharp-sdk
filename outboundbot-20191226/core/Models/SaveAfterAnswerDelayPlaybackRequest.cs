// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveAfterAnswerDelayPlaybackRequest : TeaModel {
        /// <summary>
        /// <para>Delay before playback starts, in seconds. Default is 0 if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AfterAnswerDelayPlayback")]
        [Validation(Required=false)]
        public int? AfterAnswerDelayPlayback { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>980116ec-2d3d-4747-8059-dc25e7af8501</para>
        /// </summary>
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

        /// <summary>
        /// <para>Policy level (required)</para>
        /// <list type="bullet">
        /// <item><description>2: Instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StrategyLevel")]
        [Validation(Required=false)]
        public int? StrategyLevel { get; set; }

    }

}
