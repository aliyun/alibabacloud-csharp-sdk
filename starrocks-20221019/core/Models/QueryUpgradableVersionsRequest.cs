// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class QueryUpgradableVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the minor versions that you can upgrade to. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The minor versions that you can upgrade to.</description></item>
        /// <item><description>false: The major versions that you can upgrade to.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Minor")]
        [Validation(Required=false)]
        public bool? Minor { get; set; }

    }

}
