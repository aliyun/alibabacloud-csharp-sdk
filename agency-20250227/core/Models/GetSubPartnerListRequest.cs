// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetSubPartnerListRequest : TeaModel {
        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The company name of the secondary partner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx有限公司</para>
        /// </summary>
        [NameInMap("SubPartnerCompanyName")]
        [Validation(Required=false)]
        public string SubPartnerCompanyName { get; set; }

        /// <summary>
        /// <para>The PID of the secondary partner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2323431211</para>
        /// </summary>
        [NameInMap("SubPartnerPid")]
        [Validation(Required=false)]
        public string SubPartnerPid { get; set; }

    }

}
