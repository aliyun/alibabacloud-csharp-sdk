// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class GenerateAliyunCertUrlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AliyunPk")]
        [Validation(Required=false)]
        public string AliyunPk { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("ApplyChannel")]
        [Validation(Required=false)]
        public string ApplyChannel { get; set; }

        [NameInMap("ApplyType")]
        [Validation(Required=false)]
        public string ApplyType { get; set; }

        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        [NameInMap("CertWay")]
        [Validation(Required=false)]
        public string CertWay { get; set; }

        [NameInMap("IgnoreAlreadyCert")]
        [Validation(Required=false)]
        public bool? IgnoreAlreadyCert { get; set; }

        [NameInMap("IsMobile")]
        [Validation(Required=false)]
        public bool? IsMobile { get; set; }

        [NameInMap("IsOpenApp")]
        [Validation(Required=false)]
        public bool? IsOpenApp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubjectType")]
        [Validation(Required=false)]
        public string SubjectType { get; set; }

    }

}
