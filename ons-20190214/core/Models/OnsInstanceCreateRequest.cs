// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceCreateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the instance. The name must meet the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The name of the instance must be unique in the region where the instance is deployed.</description></item>
        /// <item><description>The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test instance</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
