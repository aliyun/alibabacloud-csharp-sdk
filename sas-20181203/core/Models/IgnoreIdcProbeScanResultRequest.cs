// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class IgnoreIdcProbeScanResultRequest : TeaModel {
        /// <summary>
        /// <para>The operation that you want to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: adds the scan result to the whitelist.</description></item>
        /// <item><description><b>2</b>: ignores the scan result.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IgnoreAction")]
        [Validation(Required=false)]
        public int? IgnoreAction { get; set; }

        /// <summary>
        /// <para>The ID of the scan result. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeIdcProbeScanResultList~~">DescribeIdcProbeScanResultList</a> operation to query the ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>332098932,332098964,332098963</para>
        /// </summary>
        [NameInMap("ScanResultIds")]
        [Validation(Required=false)]
        public string ScanResultIds { get; set; }

    }

}
