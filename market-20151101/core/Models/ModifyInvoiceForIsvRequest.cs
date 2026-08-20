// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class ModifyInvoiceForIsvRequest : TeaModel {
        /// <summary>
        /// <para>The remarks on the invoice from the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("CheckNotice")]
        [Validation(Required=false)]
        public string CheckNotice { get; set; }

        /// <summary>
        /// <para>The electronic invoicing URL, used for customers to download the invoice.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss.aliyuncs.com/xxxx.png">https://oss.aliyuncs.com/xxxx.png</a></para>
        /// </summary>
        [NameInMap("ElectronUrl")]
        [Validation(Required=false)]
        public string ElectronUrl { get; set; }

        /// <summary>
        /// <para>The invoice application ID. This corresponds to the Result.Id field in the response of the DescribeInvoiceForIsv operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4072040****</para>
        /// </summary>
        [NameInMap("InvoiceId")]
        [Validation(Required=false)]
        public long? InvoiceId { get; set; }

        /// <summary>
        /// <para>The invoice number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1897702****</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>The operation to perform on the current invoice. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: issue the invoice.</description></item>
        /// <item><description>1: reject the invoice.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public int? OperateType { get; set; }

        /// <summary>
        /// <para>The type of the current invoice. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2: digital electronic general invoice.</description></item>
        /// <item><description>3: digital electronic special invoice.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
