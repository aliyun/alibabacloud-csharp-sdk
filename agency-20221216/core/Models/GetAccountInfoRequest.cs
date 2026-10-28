// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetAccountInfoRequest : TeaModel {
        /// <summary>
        /// <para>The current page number for pagination.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page for pagination. Maximum value: 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The UID of the distribution customer account. Either this parameter or the UserType parameter must be specified. If this parameter is empty, all distribution customer accounts of the specified UserType are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1215848086704806</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

        /// <summary>
        /// <para>The type of the distribution customer account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: End user.</description></item>
        /// <item><description>2: Enterprise customer. </description></item>
        /// <item><description>3: T2 partner.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
