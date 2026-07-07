// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class EticketInfo : TeaModel {
        /// <summary>
        /// <para>The number of available units.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("availableNum")]
        [Validation(Required=false)]
        public long? AvailableNum { get; set; }

        /// <summary>
        /// <para>The unique code for the e-ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taobao******tpg</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status of the e-ticket.</para>
        /// <remarks>
        /// <para>Valid enum values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: valid</para>
        /// </description></item>
        /// <item><description><para>-1: redeemed</para>
        /// </description></item>
        /// <item><description><para>-2: expired</para>
        /// </description></item>
        /// <item><description><para>-5: expired</para>
        /// </description></item>
        /// <item><description><para>-8: expired</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("codeStatus")]
        [Validation(Required=false)]
        public long? CodeStatus { get; set; }

        /// <summary>
        /// <para>The end time of the e-ticket validity period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-02T23:59:59.000+08:00</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of locked units.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("lockNum")]
        [Validation(Required=false)]
        public long? LockNum { get; set; }

        /// <summary>
        /// <para>The URL of the QR code image for the e-ticket.</para>
        /// <remarks>
        /// <para>This field is not currently populated. Distributors must generate the QR code using the <c>code</c> field.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://qrcode.alicdn.com/img.jpg">http://qrcode.alicdn.com/img.jpg</a></para>
        /// </summary>
        [NameInMap("qrcodeUrl")]
        [Validation(Required=false)]
        public string QrcodeUrl { get; set; }

        /// <summary>
        /// <para>The start time of the e-ticket validity period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-04T00:00:00.000+08:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time the e-ticket was redeemed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-04T15:07:59.000+08:00</para>
        /// </summary>
        [NameInMap("useTime")]
        [Validation(Required=false)]
        public string UseTime { get; set; }

        /// <summary>
        /// <para>The number of redeemed units.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("usedNum")]
        [Validation(Required=false)]
        public long? UsedNum { get; set; }

    }

}
