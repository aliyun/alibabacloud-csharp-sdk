// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class DispatchConsoleAPIForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LiveToken")]
        [Validation(Required=false)]
        public string LiveToken { get; set; }

        /// <summary>
        /// <para>Set the operation to perform on the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>deal</b>: Handle the alert (fencing)</description></item>
        /// <item><description><b>ignore</b>: Ignore</description></item>
        /// <item><description><b>mark_mis_info</b>: Mark as false positive (add to whitelist)</description></item>
        /// <item><description><b>rm_mark_mis_info</b>: Unmark as false positive (remove from whitelist)</description></item>
        /// <item><description><b>offline_handled</b>: Mark as Completed</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disable</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>Error parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;\&quot;]</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>Product code</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbaseue</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("SiteHost")]
        [Validation(Required=false)]
        public string SiteHost { get; set; }

    }

}
