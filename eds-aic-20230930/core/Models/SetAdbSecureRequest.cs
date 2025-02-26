// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class SetAdbSecureRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud phone instances. You can specify a maximum of 50 cloud phone instances.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The status of the ADB authentication feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The ADB authentication feature is disabled.</description></item>
        /// <item><description>1: The ADB authentication feature is enabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
