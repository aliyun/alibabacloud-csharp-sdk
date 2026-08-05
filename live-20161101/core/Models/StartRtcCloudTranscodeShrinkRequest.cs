// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartRtcCloudTranscodeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application to which the channel belongs. The ID can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>********-7074-<b><b>-9ef5-85c19a4</b></b>*</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the channel to which the user to be transcoded belongs. The ID can contain uppercase letters, lowercase letters, digits, underscores (_), and hyphens (-). The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myChannel</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The parameters for the input stream subscription.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputParam")]
        [Validation(Required=false)]
        public string InputParamShrink { get; set; }

        /// <summary>
        /// <para>The idle timeout period in seconds. If a task cannot subscribe to the specified streamer\&quot;s stream and remains idle for longer than this period, the task automatically stops. The value must be an integer from 10 to 14,400. The default value is 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public long? MaxIdleTime { get; set; }

        /// <summary>
        /// <para>The parameters for the transcoded output.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutputParams")]
        [Validation(Required=false)]
        public string OutputParamsShrink { get; set; }

    }

}
