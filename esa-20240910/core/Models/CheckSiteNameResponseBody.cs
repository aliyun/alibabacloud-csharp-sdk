// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CheckSiteNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the validation result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: Success.</description></item>
        /// <item><description><b>Site.AlreadyExist</b>: The user has already added this site.</description></item>
        /// <item><description><b>Site.InvalidName</b>: The site name is invalid.</description></item>
        /// <item><description><b>Site.SubSiteUnavailable</b>: The subsite is unavailable.</description></item>
        /// <item><description><b>Site.InternalError</b>: Other errors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the site is a subsite. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The site is a subsite.</description></item>
        /// <item><description><b>false</b>: The site is not a subsite.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSubSite")]
        [Validation(Required=false)]
        public bool? IsSubSite { get; set; }

        /// <summary>
        /// <para>The validation message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Site name is available.</para>
        /// </summary>
        [NameInMap("Messeage")]
        [Validation(Required=false)]
        public string Messeage { get; set; }

        /// <summary>
        /// <para>Indicates whether the validation is passed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Passed.</description></item>
        /// <item><description><b>false</b>: Not passed.</description></item>
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
