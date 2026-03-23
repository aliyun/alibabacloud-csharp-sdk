// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetSendifyInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("BuyResourcePackageUrl")]
        [Validation(Required=false)]
        public string BuyResourcePackageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("BuyUrl")]
        [Validation(Required=false)]
        public string BuyUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.3</para>
        /// </summary>
        [NameInMap("Discount")]
        [Validation(Required=false)]
        public string Discount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("DowngradeUrl")]
        [Validation(Required=false)]
        public string DowngradeUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>到期</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>了解更多</para>
        /// </summary>
        [NameInMap("LearnMoreUrl")]
        [Validation(Required=false)]
        public string LearnMoreUrl { get; set; }

        [NameInMap("Opened")]
        [Validation(Required=false)]
        public bool? Opened { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TRIAL</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>https</para>
        /// </summary>
        [NameInMap("RenewUrl")]
        [Validation(Required=false)]
        public string RenewUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("SpecUpgradeUrl")]
        [Validation(Required=false)]
        public string SpecUpgradeUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VALID</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupportTrial")]
        [Validation(Required=false)]
        public bool? SupportTrial { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>升配链接</para>
        /// </summary>
        [NameInMap("UpgradeUrl")]
        [Validation(Required=false)]
        public string UpgradeUrl { get; set; }

    }

}
