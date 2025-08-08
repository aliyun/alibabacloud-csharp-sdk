// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class ModifyInvoiceForIsvRequest : TeaModel {
        [NameInMap("CheckNotice")]
        [Validation(Required=false)]
        public string CheckNotice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oss.aliyuncs.com/xxxx.png">https://oss.aliyuncs.com/xxxx.png</a></para>
        /// </summary>
        [NameInMap("ElectronUrl")]
        [Validation(Required=false)]
        public string ElectronUrl { get; set; }

        [NameInMap("InvoiceId")]
        [Validation(Required=false)]
        public long? InvoiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1897702****</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public int? OperateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
