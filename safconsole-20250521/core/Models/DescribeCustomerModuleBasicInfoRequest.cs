// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class DescribeCustomerModuleBasicInfoRequest : TeaModel {
        /// <summary>
        /// <para>Authorization type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READ</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>Customer model ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CustomerModuleId")]
        [Validation(Required=false)]
        public int? CustomerModuleId { get; set; }

    }

}
