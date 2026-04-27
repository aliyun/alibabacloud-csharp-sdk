// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudAgentUnlinkRequest : TeaModel {
        /// <summary>
        /// <para>座席工号；取值3-10位正整数，参数cno,uniqueId和requestUniqueId三选一</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cno")]
        [Validation(Required=false)]
        public string Cno { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000002</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>请求唯一标识；参数cno,uniqueId和requestUniqueId三选一。注意：requestUniqueId挂机功能只在呼叫类型为webcall时生效，且需提前在管理后台将功能开启</para>
        /// 
        /// <b>Example:</b>
        /// <para>1233456789</para>
        /// </summary>
        [NameInMap("RequestUniqueId")]
        [Validation(Required=false)]
        public string RequestUniqueId { get; set; }

        /// <summary>
        /// <para>是否座席侧挂机；取值范围：1,2（数字含义，座席侧，非座席侧)，默认座席侧</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Side")]
        [Validation(Required=false)]
        public long? Side { get; set; }

        /// <summary>
        /// <para>通话唯一标识；参数cno,uniqueId和requestUniqueId三选一</para>
        /// 
        /// <b>Example:</b>
        /// <para>1233456789</para>
        /// </summary>
        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

    }

}
