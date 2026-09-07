// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class ListTenantAppRequest : TeaModel {
        /// <summary>
        /// <para>The application name keyword, matched by containment. If this parameter is not specified or is set to an empty string, no name-based filtering is applied. <c>%</c> can be used as a wildcard, and <c>_</c> is matched as a literal character.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleEditor</para>
        /// </summary>
        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. If this parameter is not specified or is set to a value less than or equal to 0, the value 1 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 500. If this parameter is not specified, is set to a value less than or equal to 0, or is set to a value greater than 500, the value 20 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The application source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MARKET: marketplace applications.</description></item>
        /// <item><description>TENANT: applications uploaded by the current tenant.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, both types of visible applications are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
