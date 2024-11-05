// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetAccountInfoRequest : TeaModel {
        /// <summary>
        /// <para>Message</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Success</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>10 (Value &lt;= 20)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1215848086704806</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

        /// <summary>
        /// <para>Result Code - Error Code. Value Range:</para>
        /// <list type="bullet">
        /// <item><description>200 OK</description></item>
        /// <item><description>1109 System Error</description></item>
        /// <item><description>3029: Invalid UID</description></item>
        /// <item><description>3062: UID and UserType are both empty.</description></item>
        /// <item><description>3063: UserType value out of range.</description></item>
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
