// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateBotSpecRequest : TeaModel {
        /// <summary>
        /// <para>The bot instance specifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise_bot</para>
        /// </summary>
        [NameInMap("BotInstanceLevel")]
        [Validation(Required=false)]
        public string BotInstanceLevel { get; set; }

        /// <summary>
        /// <para>The bot instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-bot-9tuv*********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
