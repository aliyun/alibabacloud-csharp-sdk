// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class EticketInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("availableNum")]
        [Validation(Required=false)]
        public long? AvailableNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>taobao******tpg</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("codeStatus")]
        [Validation(Required=false)]
        public long? CodeStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-02T23:59:59.000+08:00</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("lockNum")]
        [Validation(Required=false)]
        public long? LockNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://qrcode.alicdn.com/img.jpg">http://qrcode.alicdn.com/img.jpg</a></para>
        /// </summary>
        [NameInMap("qrcodeUrl")]
        [Validation(Required=false)]
        public string QrcodeUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-02-04T00:00:00.000+08:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-02-04T15:07:59.000+08:00</para>
        /// </summary>
        [NameInMap("useTime")]
        [Validation(Required=false)]
        public string UseTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("usedNum")]
        [Validation(Required=false)]
        public long? UsedNum { get; set; }

    }

}
