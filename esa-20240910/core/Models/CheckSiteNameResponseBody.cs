// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CheckSiteNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the verification result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: The verification is successful.</description></item>
        /// <item><description><b>Site.AlreadyExist</b>: The website domain name has already been added.</description></item>
        /// <item><description><b>Site.InvalidName</b>: Invalid website domain name.</description></item>
        /// <item><description><b>Site.SubSiteUnavailable</b>: Subdomains are not allowed.</description></item>
        /// <item><description><b>Site.InternalError</b>: An internal error occurs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether a subdomain is specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSubSite")]
        [Validation(Required=false)]
        public bool? IsSubSite { get; set; }

        /// <summary>
        /// <para>The verification message.</para>
        /// </summary>
        [NameInMap("Messeage")]
        [Validation(Required=false)]
        public string Messeage { get; set; }

        /// <summary>
        /// <para>Indicates whether the verification passed.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Passed")]
        [Validation(Required=false)]
        public bool? Passed { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-280B-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
