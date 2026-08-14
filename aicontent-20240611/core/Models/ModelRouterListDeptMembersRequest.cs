// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterListDeptMembersRequest : TeaModel {
        /// <summary>
        /// <para>The authorization configuration filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>inherit: only members that inherit department settings.</description></item>
        /// <item><description>custom: only members with custom settings.</description></item>
        /// <item><description>Empty: all members.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inherit</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public string AuthConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the authorized models and the number of associated keys for the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeAuthorization")]
        [Validation(Required=false)]
        public bool? IncludeAuthorization { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the monthly and permanent balance of the member\&quot;s sub-wallet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("includeBalance")]
        [Validation(Required=false)]
        public bool? IncludeBalance { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Filters members by the authorized model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
