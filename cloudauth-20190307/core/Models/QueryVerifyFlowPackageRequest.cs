// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QueryVerifyFlowPackageRequest : TeaModel {
        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FINANCE_VERIFY</b>: Financial-Grade ID Verification</description></item>
        /// <item><description><b>SMART_VERIFY</b>: Enhanced ID Verification (discontinued)</description></item>
        /// <item><description><b>FACE_VERIFY</b>: ID Verification (discontinued).</description></item>
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
