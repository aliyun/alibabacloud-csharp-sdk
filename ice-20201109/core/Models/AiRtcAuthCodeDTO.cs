// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AiRtcAuthCodeDTO : TeaModel {
        /// <summary>
        /// <para>Activation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01 06:57:43</para>
        /// </summary>
        [NameInMap("ActivatedTime")]
        [Validation(Required=false)]
        public string ActivatedTime { get; set; }

        /// <summary>
        /// <para>Authorization code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iU1IeJech7***</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>Creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-23T13:33:49Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>Device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device-***</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>license。</para>
        /// 
        /// <b>Example:</b>
        /// <para>a659a06659a***</para>
        /// </summary>
        [NameInMap("License")]
        [Validation(Required=false)]
        public string License { get; set; }

        /// <summary>
        /// <para>Batch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11096067***</para>
        /// </summary>
        [NameInMap("LicenseItemId")]
        [Validation(Required=false)]
        public string LicenseItemId { get; set; }

        /// <summary>
        /// <para>Update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-23T13:33:49Z</para>
        /// </summary>
        [NameInMap("ModificationTime")]
        [Validation(Required=false)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// <para>Status:</para>
        /// <list type="bullet">
        /// <item><description>1 - Activated</description></item>
        /// <item><description>2 - Not activated</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Type:</para>
        /// <list type="bullet">
        /// <item><description>1 - Voice call</description></item>
        /// <item><description>2 - Visual understanding</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
