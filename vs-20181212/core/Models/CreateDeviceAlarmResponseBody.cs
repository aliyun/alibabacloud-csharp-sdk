// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateDeviceAlarmResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("AlarmDelay")]
        [Validation(Required=false)]
        public long? AlarmDelay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0hyNgTdgv2D000195842</para>
        /// </summary>
        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public string AlarmId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>76E11E6A-4441-51C9-AF60-D354362257A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rtmp://demo.aliyundoc.com/live/310101<em><b><b>7542007?auth_key=1639130258-0-0-b2b04fe85ece6</b></b></em>a6b1a42bc7e</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
