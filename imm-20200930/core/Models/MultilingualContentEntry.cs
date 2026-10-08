// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class MultilingualContentEntry : TeaModel {
        /// <summary>
        /// <para>The multilingual brief description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No personnel activity at the office desk</para>
        /// </summary>
        [NameInMap("Caption")]
        [Validation(Required=false)]
        public string Caption { get; set; }

        /// <summary>
        /// <para>The multilingual detailed description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a close-up shot of an office desk setup. In the left foreground stands a tall, cylindrical, off-white insulated tumbler. A rectangular black mousepad occupies the center of the desk, holding a black backlit mechanical keyboard. Directly behind the keyboard sits a computer monitor with its screen illuminated, displaying the operating system\&quot;s application dock at the bottom. To the front right of the monitor stands a red metal beverage can, surrounded by a tangle of white data cables and a charging adapter. A small, silver, rectangular device (possibly a USB drive or an adapter) rests in the gap behind the left side of the keyboard, and a tiny pink decorative object is faintly visible on the desk surface. The scene is devoid of human activity; all objects remain motionless.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
