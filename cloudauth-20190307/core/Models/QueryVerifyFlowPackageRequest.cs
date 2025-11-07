// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QueryVerifyFlowPackageRequest : TeaModel {
        /// <summary>
        /// <para>Product type:</para>
        /// <list type="bullet">
        /// <item><description><b>FINANCE_VERIFY</b>: Financial Grade Real Person Verification</description></item>
        /// <item><description><b>SMART_VERIFY</b>: Enhanced Real Person Verification (discontinued)</description></item>
        /// <item><description><b>FACE_VERIFY</b>: Real Person Verification (discontinued)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINANCE_VERIFY</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
