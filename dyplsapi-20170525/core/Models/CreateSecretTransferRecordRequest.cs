// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreateSecretTransferRecordRequest : TeaModel {
        /// <summary>
        /// <para>迁移后的新号码池key</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC111111</para>
        /// </summary>
        [NameInMap("LastPartnerKey")]
        [Validation(Required=false)]
        public string LastPartnerKey { get; set; }

        /// <summary>
        /// <para>指定号码（单一、批量）迁移;一次最多可迁移500个号码，号码间请换行隔开.</para>
        /// 
        /// <b>Example:</b>
        /// <para>198xxxxxxxx
        /// 138xxxxxxx</para>
        /// </summary>
        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public string NumberList { get; set; }

        /// <summary>
        /// <para>要迁移的原号码池key</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC123456</para>
        /// </summary>
        [NameInMap("OriginPartnerKey")]
        [Validation(Required=false)]
        public string OriginPartnerKey { get; set; }

    }

}
