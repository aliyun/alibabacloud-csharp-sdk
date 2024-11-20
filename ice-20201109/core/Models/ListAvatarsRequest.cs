// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAvatarsRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The type of the digital human.</description></item>
        /// <item><description>2DAvatar</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2DAvatar</para>
        /// </summary>
        [NameInMap("AvatarType")]
        [Validation(Required=false)]
        public string AvatarType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The page number.</description></item>
        /// <item><description>Default value: 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The number of entries per page.</description></item>
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
